using BionicVisionVR.Resources;

namespace Assets.BionicVisionVR.Coding.Structs
{
    public struct BlockSettings
    {
        public float rho;
        public float lambda; 
        public int xElectrodeCount;
        public int yElectrodeCount;
        public int electrodeSpacing;
        public float xPosition;
        public float yPosition;
        public float rotation; 

        public BlockSettings(float _rho, float _lambda, int _xElectrodeCount, int _yElectrodeCount, int _electrodeSpacing, float _xPosition, float _yPosition, float _rotation)
        {
            rho = _rho;
            lambda = _lambda;
            xElectrodeCount = _xElectrodeCount;
            yElectrodeCount = _yElectrodeCount;
            electrodeSpacing = _electrodeSpacing;
            xPosition = _xPosition;
            yPosition = _yPosition;
            rotation = _rotation; 
        }

        public static BlockSettings GetPreDefinedBlockSettings(PreDefinedBlocks block)
        {
            BlockSettings returnBlock;
            switch (block)
            {
                case PreDefinedBlocks.MicrosoftFellowship1:
                    returnBlock = new BlockSettings(100, 130, 17, 17, 500, 0, 0, 0);
                    break;
                case PreDefinedBlocks.MicrosoftFellowship2:
                    returnBlock = new BlockSettings(300, 350, 17, 17, 300, 0, 0, 0);
                    break; 
                case PreDefinedBlocks.MicrosoftFellowship3:
                    returnBlock = new BlockSettings(100, 130, 17, 17, 500, 0, 0, 0);
                    break; 
                case PreDefinedBlocks.Argus2Rho100Lambda100:
                    returnBlock = new BlockSettings(100, 100, 10, 6, 575, 0, 0, 45); 
                    break;
                // case PreDefinedBlocks.LetterTask1:
                //     returnBlock = new BlockSettings(75, 75, 10, 6, 575, 0, 0, 45); 
                //     break;
                case PreDefinedBlocks.LetterTask1:
                                              returnBlock = new BlockSettings(100, 50, 10, 6, 575, 0, 0, 45); 
                                              break;
                case PreDefinedBlocks.LetterTask2:
                    returnBlock = new BlockSettings(300, 50, 10, 6, 575, 0, 0, 45); 
                    break;
                case PreDefinedBlocks.LetterTask3:
                    returnBlock = new BlockSettings(300, 100, 10, 6, 575, 0, 0, 45); 
                    break;
                case PreDefinedBlocks.LetterTask4:
                    returnBlock = new BlockSettings(300, 150, 10, 6, 575, 0, 0, 45); 
                    break;
                // case PreDefinedBlocks.LetterTask5:
                //     returnBlock = new BlockSettings(125, 125, 10, 6, 575, 0, 0, 45); 
                //     break;
                case PreDefinedBlocks.LetterTask5:
                    returnBlock = new BlockSettings(300, 1000, 10, 6, 575, 0, 0, 45); 
                    break;
                case PreDefinedBlocks.LetterTask6:
                    returnBlock = new BlockSettings(300, 500, 10, 6, 575, 0, 0, 45); 
                    break;
                case PreDefinedBlocks.LetterTask7:
                    returnBlock = new BlockSettings(500, 100, 10, 6, 575, 0, 0, 45); 
                    break;
                case PreDefinedBlocks.LetterTask8:
                    returnBlock = new BlockSettings(500, 300, 10, 6, 575, 0, 0, 45); 
                    break;
                // case PreDefinedBlocks.LetterTask9:
                //     returnBlock = new BlockSettings(300, 200, 10, 6, 575, 0, 0, 45); 
                //     break;
                case PreDefinedBlocks.LetterTask9:
                    returnBlock = new BlockSettings(500, 5000, 10, 6, 575, 0, 0, 45); 
                    break;
                case PreDefinedBlocks.TestMaxScoreboard:
                    returnBlock = new BlockSettings(50, 50, 100, 100, 350, 0, 0, 0);
                    break;

                case PreDefinedBlocks.ObjectTask_10x6y_1:
                    returnBlock = new BlockSettings(100, 50, 10, 6, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_10x6y_2:
                    returnBlock = new BlockSettings(300, 50, 10, 6, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_10x6y_3:
                    returnBlock = new BlockSettings(500, 50, 10, 6, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_10x6y_4:
                    returnBlock = new BlockSettings(100, 1000, 10, 6, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_10x6y_5:
                    returnBlock = new BlockSettings(300, 1000, 10, 6, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_10x6y_6:
                    returnBlock = new BlockSettings(500, 1000, 10, 6, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_10x6y_7:
                    returnBlock = new BlockSettings(100, 5000, 10, 6, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_10x6y_8:
                    returnBlock = new BlockSettings(300, 5000, 10, 6, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_10x6y_9:
                    returnBlock = new BlockSettings(500, 5000, 10, 6, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_16x10y_1:
                    returnBlock = new BlockSettings(100, 50, 16, 10, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_16x10y_2:
                    returnBlock = new BlockSettings(300, 50, 16, 10, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_16x10y_3:
                    returnBlock = new BlockSettings(500, 50, 16, 10, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_16x10y_4:
                    returnBlock = new BlockSettings(100, 1000, 16, 10, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_16x10y_5:
                    returnBlock = new BlockSettings(300, 1000, 16, 10, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_16x10y_6:
                    returnBlock = new BlockSettings(500, 1000, 16, 10, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_16x10y_7:
                    returnBlock = new BlockSettings(100, 5000, 16, 10, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_16x10y_8:
                    returnBlock = new BlockSettings(300, 5000, 16, 10, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_16x10y_9:
                    returnBlock = new BlockSettings(500, 5000, 16, 10, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_31x19y_1:
                    returnBlock = new BlockSettings(100, 50, 31, 19, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_31x19y_2:
                    returnBlock = new BlockSettings(300, 50, 31, 19, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_31x19y_3:
                    returnBlock = new BlockSettings(500, 50, 31, 19, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_31x19y_4:
                    returnBlock = new BlockSettings(100, 1000, 31, 19, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_31x19y_5:
                    returnBlock = new BlockSettings(300, 1000, 31, 19, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_31x19y_6:
                    returnBlock = new BlockSettings(500, 1000, 31, 19, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_31x19y_7:
                    returnBlock = new BlockSettings(100, 5000, 31, 19, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_31x19y_8:
                    returnBlock = new BlockSettings(300, 5000, 31, 19, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_31x19y_9:
                    returnBlock = new BlockSettings(500, 5000, 31, 19, 350, 0, 0, 0);
                    break;

                case PreDefinedBlocks.ObjectTask_50x50y_1:
                    returnBlock = new BlockSettings(100, 50, 50, 50, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_2:
                    returnBlock = new BlockSettings(300, 50, 50, 50, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_3:
                    returnBlock = new BlockSettings(500, 50, 50, 50, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_4:
                    returnBlock = new BlockSettings(100, 1000, 50, 50, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_5:
                    returnBlock = new BlockSettings(300, 1000, 50, 50, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_6:
                    returnBlock = new BlockSettings(500, 1000, 50, 50, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_7:
                    returnBlock = new BlockSettings(100, 5000, 50, 50, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_8:
                    returnBlock = new BlockSettings(300, 5000, 50, 50, 350, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_9:
                    returnBlock = new BlockSettings(500, 5000, 50, 50, 350, 0, 0, 0);
                    break;

                case PreDefinedBlocks.ObjectTask_50x50y_250space_1:
                    returnBlock = new BlockSettings(100, 50, 50, 50, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_250space_2:
                    returnBlock = new BlockSettings(300, 50, 50, 50, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_250space_3:
                    returnBlock = new BlockSettings(500, 50, 50, 50, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_250space_4:
                    returnBlock = new BlockSettings(100, 1000, 50, 50, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_250space_5:
                    returnBlock = new BlockSettings(300, 1000, 50, 50, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_250space_6:
                    returnBlock = new BlockSettings(500, 1000, 50, 50, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_250space_7:
                    returnBlock = new BlockSettings(100, 5000, 50, 50, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_250space_8:
                    returnBlock = new BlockSettings(300, 5000, 50, 50, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_50x50y_250space_9:
                    returnBlock = new BlockSettings(500, 5000, 50, 50, 250, 0, 0, 0);
                    break;

                case PreDefinedBlocks.ObjectTask_100x100y_250space_1:
                    returnBlock = new BlockSettings(100, 50, 100, 100, 200, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_100x100y_250space_2:
                    returnBlock = new BlockSettings(300, 50, 100, 100, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_100x100y_250space_3:
                    returnBlock = new BlockSettings(500, 50, 100, 100, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_100x100y_250space_4:
                    returnBlock = new BlockSettings(100, 1000, 100, 100, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_100x100y_250space_5:
                    returnBlock = new BlockSettings(300, 1000, 100, 100, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_100x100y_250space_6:
                    returnBlock = new BlockSettings(500, 1000, 100, 100, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_100x100y_250space_7:
                    returnBlock = new BlockSettings(100, 5000, 100, 100, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_100x100y_250space_8:
                    returnBlock = new BlockSettings(300, 5000, 100, 100, 250, 0, 0, 0);
                    break;
                case PreDefinedBlocks.ObjectTask_100x100y_250space_9:
                    returnBlock = new BlockSettings(500, 5000, 100, 100, 250, 0, 0, 0);
                    break;
                default:
                    returnBlock = new BlockSettings(); 
                    break; 
            }

            return returnBlock; 
        }
    }
}