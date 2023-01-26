﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using BionicVisionVR.Coding.Structs;
using BionicVisionVR.Structs;

public class BinaryHandler
{
    public List<int> ReadFromBinaryFile(string path)
    {
        // Approach one
        using (var filestream = File.Open(path, FileMode.Open))
        using (var binaryStream = new BinaryReader(filestream))
        {
            var pos = 0;
            List<int> result = new List<int>();
            var length = (float) binaryStream.BaseStream.Length;
            while (pos < length)
            {
                int element = binaryStream.ReadInt32();
                result.Add(element);
                pos += sizeof(int);
            }

            return result;
        }
    }
    
    public List<float> ReadFloatsFromBinaryFile(string path)
    {
        // Approach one
        using (var filestream = File.Open(path, FileMode.Open))
        using (var binaryStream = new BinaryReader(filestream))
        {
            var pos = 0;
            List<float> result = new List<float>();
            var length = (float) binaryStream.BaseStream.Length;
            while (pos < length)
            {
                float element = binaryStream.ReadSingle();
                result.Add(element);
                pos += sizeof(float);
            }

            return result;
        }
    }

    public float[,] Read2DArray_float32(int row, int col, string path)
    {
        float[,] rate_buff = new float[row, col];

        // open the file
        using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
        {
            for (int i = 0; i < row; i++)
            {
                // read the doubles out of the byte buffer into the two dimensional array
                // note this assumes machine-endian byte order
                for (int j = 0; j < col; j++)
                {
                    float temp = reader.ReadSingle();
                    rate_buff[i, j] = temp;
                }
            }

            //return rate_buff;
        }

        return rate_buff;
    }

    public AxonSegment[] ReadAxonSegments(string path)
    {
        using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
        {
            AxonSegment[] axon_buff = new AxonSegment[reader.BaseStream.Length/3/sizeof(float)];

            for (int i = 0; i < axon_buff.Length; i++)
            {
                axon_buff[i] = new AxonSegment(new float[] {reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle()});
            }
            return axon_buff;
        }
    }
    
    public void WriteAxonSegments(string path, AxonSegment[] axonSegments)
    {
        using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
        using (var writer = new BinaryWriter(stream))
        {
            foreach (AxonSegment item in axonSegments)
            {
                writer.Write(item.xPosition);
                writer.Write(item.yPosition); 
                writer.Write(item.brightnessContribution);
            }
        }
    }

    public void WriteFloatArray(string path, float[] floatArray)
    {
        using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
        using (var writer = new BinaryWriter(stream))
        {
            foreach (float item in floatArray)
            {
                writer.Write(item);
            }
        }
    }
    
    public void WriteAxonMap(string path, AxonMap axonMap)
    {
        using (var stream = new FileStream(path+"_axonIdxStart", FileMode.Create, FileAccess.Write, FileShare.None))
        using (var writer = new BinaryWriter(stream))
        {
            foreach (int item in axonMap.axonIdxStart)
            {
                writer.Write(item);
            }
        }
        using (var stream = new FileStream(path+"_axonIdxEnd", FileMode.Create, FileAccess.Write, FileShare.None))
        using (var writer = new BinaryWriter(stream))
        {
            foreach (int item in axonMap.axonIdxEnd)
            {
                writer.Write(item);
            }
        }

        WriteAxonSegments(path + "_axonSegments", axonMap.axonSegmentContributions);
    }
    
    public AxonMap ReadAxonMap(string path)
    {
        return new AxonMap(ReadFromBinaryFile(path + "_axonIdxStart").ToArray(),
            ReadFromBinaryFile(path + "_axonIdxEnd").ToArray(), ReadAxonSegments(path + "_axonSegments")); 
    }

    public void WriteElectrodeLocations(string path, Electrode[] electrodes)
    {
        using (var stream = new FileStream(path+"_electrodePositionsX", FileMode.Create, FileAccess.Write, FileShare.None))
        using (var writer = new BinaryWriter(stream))
        {
            foreach (Electrode item in electrodes)
            {
                writer.Write(item.xPosition);
            }
        }
        using (var stream = new FileStream(path+"_electrodePositionsY", FileMode.Create, FileAccess.Write, FileShare.None))
        using (var writer = new BinaryWriter(stream))
        {
            foreach (Electrode item in electrodes)
            {
                writer.Write(item.yPosition); 
            }
        }
    }

    public Electrode[] ReadElectrodeLocations(string path)
    {
        float[] electrodePositionsX = ReadFloatsFromBinaryFile(path + "_electrodePositionsX").ToArray();
        float[] electrodePositionsY = ReadFloatsFromBinaryFile(path + "_electrodePositionsY").ToArray();
        Electrode[] electrodes = new Electrode[electrodePositionsX.Length];

        for (int i = 0; i < electrodes.Length; i++)
        {
            electrodes[i] = new Electrode(electrodePositionsX[i], electrodePositionsY[i], 0);
        }

        return electrodes; 
    }

    public void writeUnityPosition(string path, Vector3 position)
    {
        path = path + "_Positions"; 
        using (var stream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None))
        using (var writer = new BinaryWriter(stream))
        {
            writer.Write(position.x);
            writer.Write(position.y);
            writer.Write(position.z);
        }
    }
    public void writeUnityPositions(string path, Vector3[] positions)
    {
        foreach (Vector3 position in positions)
        {
            writeUnityPosition(path, position);
        }
    }
    
    public void writeUnityRotation(string path, Vector3 rotation)
    {
        path = path + "_Rotations"; 
        using (var stream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None))
        using (var writer = new BinaryWriter(stream))
        {
            writer.Write(rotation.x);
            writer.Write(rotation.y);
            writer.Write(rotation.z);
        }
    }

    public void writeUnityRotations(string path, Vector3[] rotations)
    {
        foreach (Vector3 rotation in rotations)
        {
            writeUnityRotation(path, rotation);
        }
    }
    
    public void writeFloat(string path, float value)
    {
        path = path + "_Floats"; 
        using (var stream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None))
        using (var writer = new BinaryWriter(stream))
        {
            writer.Write(value);
        }
    }
    
    public Vector3[] ReadPositions(string path)
    {
        path = path + "_Positions"; 
        
        using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
        {
            Vector3[] positions = new Vector3[reader.BaseStream.Length/3/sizeof(float)];

            for (int i = 0; i < positions.Length; i++)
            {
                positions[i] = new Vector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
            }
            return positions;
        }
    }
    
    public Vector3[] ReadRotations(string path)
    {
        path = path + "_Rotations"; 
        
        using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
        {
            Vector3[] rotations = new Vector3[reader.BaseStream.Length/3/sizeof(float)];

            for (int i = 0; i < rotations.Length; i++)
            {
                rotations[i] = new Vector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
            }
            return rotations;
        }
    }
    
    public float[] ReadFloats(string path)
    {
        path = path + "_Floats"; 
        
        using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
        {
            float[] values = new float[reader.BaseStream.Length/sizeof(float)];

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = reader.ReadSingle();
            }
            return values;
        }
    }
}