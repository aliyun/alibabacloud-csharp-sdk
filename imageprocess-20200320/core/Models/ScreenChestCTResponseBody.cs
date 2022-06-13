// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ScreenChestCTResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScreenChestCTResponseBodyData Data { get; set; }
        public class ScreenChestCTResponseBodyData : TeaModel {
            [NameInMap("AnalyzeChestVessel")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataAnalyzeChestVessel AnalyzeChestVessel { get; set; }
            public class ScreenChestCTResponseBodyDataAnalyzeChestVessel : TeaModel {
                [NameInMap("AortaInfo")]
                [Validation(Required=false)]
                public ScreenChestCTResponseBodyDataAnalyzeChestVesselAortaInfo AortaInfo { get; set; }
                public class ScreenChestCTResponseBodyDataAnalyzeChestVesselAortaInfo : TeaModel {
                    [NameInMap("Area")]
                    [Validation(Required=false)]
                    public List<string> Area { get; set; }
                    [NameInMap("Coordinates")]
                    [Validation(Required=false)]
                    public List<string> Coordinates { get; set; }
                    [NameInMap("LabelValue")]
                    [Validation(Required=false)]
                    public long? LabelValue { get; set; }
                    [NameInMap("MaxArea")]
                    [Validation(Required=false)]
                    public float? MaxArea { get; set; }
                    [NameInMap("MaxAreaIndex")]
                    [Validation(Required=false)]
                    public long? MaxAreaIndex { get; set; }
                    [NameInMap("MaxDiameter")]
                    [Validation(Required=false)]
                    public float? MaxDiameter { get; set; }
                };

                [NameInMap("PulmonaryInfo")]
                [Validation(Required=false)]
                public ScreenChestCTResponseBodyDataAnalyzeChestVesselPulmonaryInfo PulmonaryInfo { get; set; }
                public class ScreenChestCTResponseBodyDataAnalyzeChestVesselPulmonaryInfo : TeaModel {
                    [NameInMap("Area")]
                    [Validation(Required=false)]
                    public List<string> Area { get; set; }
                    [NameInMap("Coordinates")]
                    [Validation(Required=false)]
                    public List<string> Coordinates { get; set; }
                    [NameInMap("LabelValue")]
                    [Validation(Required=false)]
                    public long? LabelValue { get; set; }
                    [NameInMap("MaxArea")]
                    [Validation(Required=false)]
                    public float? MaxArea { get; set; }
                    [NameInMap("MaxAreaIndex")]
                    [Validation(Required=false)]
                    public long? MaxAreaIndex { get; set; }
                    [NameInMap("MaxDiameter")]
                    [Validation(Required=false)]
                    public float? MaxDiameter { get; set; }
                    [NameInMap("NearestAortaArea")]
                    [Validation(Required=false)]
                    public float? NearestAortaArea { get; set; }
                };

                [NameInMap("ResultURL")]
                [Validation(Required=false)]
                public string ResultURL { get; set; }

            }
            [NameInMap("CACS")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataCACS CACS { get; set; }
            public class ScreenChestCTResponseBodyDataCACS : TeaModel {
                [NameInMap("Detections")]
                [Validation(Required=false)]
                public List<ScreenChestCTResponseBodyDataCACSDetections> Detections { get; set; }
                public class ScreenChestCTResponseBodyDataCACSDetections : TeaModel {
                    [NameInMap("CalciumId")]
                    [Validation(Required=false)]
                    public long? CalciumId { get; set; }

                    [NameInMap("CalciumScore")]
                    [Validation(Required=false)]
                    public float? CalciumScore { get; set; }

                    [NameInMap("CalciumVolume")]
                    [Validation(Required=false)]
                    public float? CalciumVolume { get; set; }

                }

                [NameInMap("ResultUrl")]
                [Validation(Required=false)]
                public string ResultUrl { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("VolumeScore")]
                [Validation(Required=false)]
                public string VolumeScore { get; set; }

            }
            [NameInMap("Covid")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataCovid Covid { get; set; }
            public class ScreenChestCTResponseBodyDataCovid : TeaModel {
                [NameInMap("LesionRatio")]
                [Validation(Required=false)]
                public string LesionRatio { get; set; }

                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                [NameInMap("NewProbability")]
                [Validation(Required=false)]
                public string NewProbability { get; set; }

                [NameInMap("NormalProbability")]
                [Validation(Required=false)]
                public string NormalProbability { get; set; }

                [NameInMap("OtherProbability")]
                [Validation(Required=false)]
                public string OtherProbability { get; set; }

            }
            [NameInMap("DetectLymph")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataDetectLymph DetectLymph { get; set; }
            public class ScreenChestCTResponseBodyDataDetectLymph : TeaModel {
                [NameInMap("Lesions")]
                [Validation(Required=false)]
                public List<ScreenChestCTResponseBodyDataDetectLymphLesions> Lesions { get; set; }
                public class ScreenChestCTResponseBodyDataDetectLymphLesions : TeaModel {
                    [NameInMap("Boxes")]
                    [Validation(Required=false)]
                    public List<float?> Boxes { get; set; }

                    [NameInMap("Diametermm")]
                    [Validation(Required=false)]
                    public List<float?> Diametermm { get; set; }

                    [NameInMap("KeySlice")]
                    [Validation(Required=false)]
                    public long? KeySlice { get; set; }

                    [NameInMap("Recist")]
                    [Validation(Required=false)]
                    public List<List<float?>> Recist { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

            }
            [NameInMap("DetectPdac")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataDetectPdac DetectPdac { get; set; }
            public class ScreenChestCTResponseBodyDataDetectPdac : TeaModel {
                [NameInMap("Lesion")]
                [Validation(Required=false)]
                public ScreenChestCTResponseBodyDataDetectPdacLesion Lesion { get; set; }
                public class ScreenChestCTResponseBodyDataDetectPdacLesion : TeaModel {
                    [NameInMap("Mask")]
                    [Validation(Required=false)]
                    public string Mask { get; set; }
                    [NameInMap("NonPdacVol")]
                    [Validation(Required=false)]
                    public string NonPdacVol { get; set; }
                    [NameInMap("PancVol")]
                    [Validation(Required=false)]
                    public string PancVol { get; set; }
                    [NameInMap("PdacVol")]
                    [Validation(Required=false)]
                    public string PdacVol { get; set; }
                    [NameInMap("Possibilities")]
                    [Validation(Required=false)]
                    public List<string> Possibilities { get; set; }
                };

            }
            [NameInMap("DetectRibFracture")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataDetectRibFracture DetectRibFracture { get; set; }
            public class ScreenChestCTResponseBodyDataDetectRibFracture : TeaModel {
                [NameInMap("Detections")]
                [Validation(Required=false)]
                public List<ScreenChestCTResponseBodyDataDetectRibFractureDetections> Detections { get; set; }
                public class ScreenChestCTResponseBodyDataDetectRibFractureDetections : TeaModel {
                    [NameInMap("CoordinateImage")]
                    [Validation(Required=false)]
                    public List<long?> CoordinateImage { get; set; }

                    [NameInMap("Coordinates")]
                    [Validation(Required=false)]
                    public List<long?> Coordinates { get; set; }

                    [NameInMap("FractureCategory")]
                    [Validation(Required=false)]
                    public long? FractureCategory { get; set; }

                    [NameInMap("FractureConfidence")]
                    [Validation(Required=false)]
                    public float? FractureConfidence { get; set; }

                    [NameInMap("FractureId")]
                    [Validation(Required=false)]
                    public long? FractureId { get; set; }

                    [NameInMap("FractureLocation")]
                    [Validation(Required=false)]
                    public string FractureLocation { get; set; }

                    [NameInMap("FractureSegment")]
                    [Validation(Required=false)]
                    public long? FractureSegment { get; set; }

                }

                [NameInMap("Origin")]
                [Validation(Required=false)]
                public List<float?> Origin { get; set; }

                [NameInMap("ResultURL")]
                [Validation(Required=false)]
                public string ResultURL { get; set; }

                [NameInMap("Spacing")]
                [Validation(Required=false)]
                public List<float?> Spacing { get; set; }

            }
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }
            [NameInMap("LungNodule")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataLungNodule LungNodule { get; set; }
            public class ScreenChestCTResponseBodyDataLungNodule : TeaModel {
                [NameInMap("Series")]
                [Validation(Required=false)]
                public List<ScreenChestCTResponseBodyDataLungNoduleSeries> Series { get; set; }
                public class ScreenChestCTResponseBodyDataLungNoduleSeries : TeaModel {
                    [NameInMap("Elements")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataLungNoduleSeriesElements> Elements { get; set; }
                    public class ScreenChestCTResponseBodyDataLungNoduleSeriesElements : TeaModel {
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public float? Diameter { get; set; }

                        [NameInMap("ImageX")]
                        [Validation(Required=false)]
                        public float? ImageX { get; set; }

                        [NameInMap("ImageY")]
                        [Validation(Required=false)]
                        public float? ImageY { get; set; }

                        [NameInMap("ImageZ")]
                        [Validation(Required=false)]
                        public float? ImageZ { get; set; }

                        [NameInMap("Lobe")]
                        [Validation(Required=false)]
                        public string Lobe { get; set; }

                        [NameInMap("Lung")]
                        [Validation(Required=false)]
                        public string Lung { get; set; }

                        [NameInMap("MeanValue")]
                        [Validation(Required=false)]
                        public float? MeanValue { get; set; }

                        [NameInMap("SOPInstanceUID")]
                        [Validation(Required=false)]
                        public string SOPInstanceUID { get; set; }

                        [NameInMap("Volume")]
                        [Validation(Required=false)]
                        public float? Volume { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                        [NameInMap("Z")]
                        [Validation(Required=false)]
                        public float? Z { get; set; }

                    }

                    [NameInMap("Origin")]
                    [Validation(Required=false)]
                    public List<float?> Origin { get; set; }

                    [NameInMap("Report")]
                    [Validation(Required=false)]
                    public string Report { get; set; }

                    [NameInMap("SeriesInstanceUid")]
                    [Validation(Required=false)]
                    public string SeriesInstanceUid { get; set; }

                    [NameInMap("Spacing")]
                    [Validation(Required=false)]
                    public List<float?> Spacing { get; set; }

                }

            }
            [NameInMap("URLList")]
            [Validation(Required=false)]
            public Dictionary<string, string> URLList { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
