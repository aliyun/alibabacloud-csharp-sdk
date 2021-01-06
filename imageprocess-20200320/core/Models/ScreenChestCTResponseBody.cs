// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ScreenChestCTResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScreenChestCTResponseBodyData Data { get; set; }
        public class ScreenChestCTResponseBodyData : TeaModel {
            [NameInMap("LungNodule")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataLungNodule LungNodule { get; set; }
            public class ScreenChestCTResponseBodyDataLungNodule : TeaModel {
                [NameInMap("Series")]
                [Validation(Required=false)]
                public List<ScreenChestCTResponseBodyDataLungNoduleSeries> Series { get; set; }
                public class ScreenChestCTResponseBodyDataLungNoduleSeries : TeaModel {
                    [NameInMap("SeriesInstanceUid")]
                    [Validation(Required=false)]
                    public string SeriesInstanceUid { get; set; }

                    [NameInMap("Elements")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataLungNoduleSeriesElements> Elements { get; set; }
                    public class ScreenChestCTResponseBodyDataLungNoduleSeriesElements : TeaModel {
                        [NameInMap("Z")]
                        [Validation(Required=false)]
                        public float? Z { get; set; }

                        [NameInMap("Lobe")]
                        [Validation(Required=false)]
                        public string Lobe { get; set; }

                        [NameInMap("MeanValue")]
                        [Validation(Required=false)]
                        public float? MeanValue { get; set; }

                        [NameInMap("ImageZ")]
                        [Validation(Required=false)]
                        public float? ImageZ { get; set; }

                        [NameInMap("Lung")]
                        [Validation(Required=false)]
                        public string Lung { get; set; }

                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        [NameInMap("SOPInstanceUID")]
                        [Validation(Required=false)]
                        public string SOPInstanceUID { get; set; }

                        [NameInMap("ImageX")]
                        [Validation(Required=false)]
                        public float? ImageX { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        [NameInMap("Volume")]
                        [Validation(Required=false)]
                        public float? Volume { get; set; }

                        [NameInMap("ImageY")]
                        [Validation(Required=false)]
                        public float? ImageY { get; set; }

                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public float? Diameter { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                    }

                    [NameInMap("Origin")]
                    [Validation(Required=false)]
                    public List<float?> Origin { get; set; }

                    [NameInMap("Report")]
                    [Validation(Required=false)]
                    public string Report { get; set; }

                    [NameInMap("Spacing")]
                    [Validation(Required=false)]
                    public List<float?> Spacing { get; set; }

                }

            }
            [NameInMap("CACS")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataCACS CACS { get; set; }
            public class ScreenChestCTResponseBodyDataCACS : TeaModel {
                [NameInMap("ResultUrl")]
                [Validation(Required=false)]
                public string ResultUrl { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

            }
            [NameInMap("Covid")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataCovid Covid { get; set; }
            public class ScreenChestCTResponseBodyDataCovid : TeaModel {
                [NameInMap("NormalProbability")]
                [Validation(Required=false)]
                public string NormalProbability { get; set; }

                [NameInMap("NewProbability")]
                [Validation(Required=false)]
                public string NewProbability { get; set; }

                [NameInMap("LesionRatio")]
                [Validation(Required=false)]
                public string LesionRatio { get; set; }

                [NameInMap("OtherProbability")]
                [Validation(Required=false)]
                public string OtherProbability { get; set; }

                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

            }
        };

    }

}
