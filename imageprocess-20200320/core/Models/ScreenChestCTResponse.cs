// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ScreenChestCTResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ScreenChestCTResponseData Data { get; set; }
        public class ScreenChestCTResponseData : TeaModel {
            [NameInMap("LungNodule")]
            [Validation(Required=true)]
            public ScreenChestCTResponseDataLungNodule LungNodule { get; set; }
            public class ScreenChestCTResponseDataLungNodule : TeaModel {
                [NameInMap("Series")]
                [Validation(Required=true)]
                public List<ScreenChestCTResponseDataLungNoduleSeries> Series { get; set; }
                public class ScreenChestCTResponseDataLungNoduleSeries : TeaModel {
                    [NameInMap("SeriesInstanceUid")]
                    [Validation(Required=true)]
                    public string SeriesInstanceUid { get; set; }

                    [NameInMap("Report")]
                    [Validation(Required=true)]
                    public string Report { get; set; }

                    [NameInMap("Elements")]
                    [Validation(Required=true)]
                    public List<ScreenChestCTResponseDataLungNoduleSeriesElements> Elements { get; set; }
                    public class ScreenChestCTResponseDataLungNoduleSeriesElements : TeaModel {
                        [NameInMap("Category")]
                        [Validation(Required=true)]
                        public string Category { get; set; }

                        [NameInMap("Confidence")]
                        [Validation(Required=true)]
                        public float? Confidence { get; set; }

                        [NameInMap("Diameter")]
                        [Validation(Required=true)]
                        public float? Diameter { get; set; }

                        [NameInMap("Lobe")]
                        [Validation(Required=true)]
                        public string Lobe { get; set; }

                        [NameInMap("Lung")]
                        [Validation(Required=true)]
                        public string Lung { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=true)]
                        public float? X { get; set; }

                        [NameInMap("Z")]
                        [Validation(Required=true)]
                        public float? Z { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=true)]
                        public float? Y { get; set; }

                        [NameInMap("ImageX")]
                        [Validation(Required=true)]
                        public float? ImageX { get; set; }

                        [NameInMap("ImageY")]
                        [Validation(Required=true)]
                        public float? ImageY { get; set; }

                        [NameInMap("ImageZ")]
                        [Validation(Required=true)]
                        public float? ImageZ { get; set; }

                        [NameInMap("SOPInstanceUID")]
                        [Validation(Required=true)]
                        public string SOPInstanceUID { get; set; }

                        [NameInMap("Volume")]
                        [Validation(Required=true)]
                        public float? Volume { get; set; }

                        [NameInMap("MeanValue")]
                        [Validation(Required=true)]
                        public float? MeanValue { get; set; }

                    }

                    [NameInMap("Origin")]
                    [Validation(Required=true)]
                    public List<float?> Origin { get; set; }

                    [NameInMap("Spacing")]
                    [Validation(Required=true)]
                    public List<float?> Spacing { get; set; }

                }

            }
            [NameInMap("CACS")]
            [Validation(Required=true)]
            public ScreenChestCTResponseDataCACS CACS { get; set; }
            public class ScreenChestCTResponseDataCACS : TeaModel {
                [NameInMap("Score")]
                [Validation(Required=true)]
                public string Score { get; set; }

                [NameInMap("ResultUrl")]
                [Validation(Required=true)]
                public string ResultUrl { get; set; }

            }
            [NameInMap("Covid")]
            [Validation(Required=true)]
            public ScreenChestCTResponseDataCovid Covid { get; set; }
            public class ScreenChestCTResponseDataCovid : TeaModel {
                [NameInMap("NewProbability")]
                [Validation(Required=true)]
                public string NewProbability { get; set; }

                [NameInMap("NormalProbability")]
                [Validation(Required=true)]
                public string NormalProbability { get; set; }

                [NameInMap("OtherProbability")]
                [Validation(Required=true)]
                public string OtherProbability { get; set; }

                [NameInMap("LesionRatio")]
                [Validation(Required=true)]
                public string LesionRatio { get; set; }

                [NameInMap("Mask")]
                [Validation(Required=true)]
                public string Mask { get; set; }

            }
        };

    }

}
