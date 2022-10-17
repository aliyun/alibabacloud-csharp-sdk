// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectLungNoduleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectLungNoduleResponseBodyData Data { get; set; }
        public class DetectLungNoduleResponseBodyData : TeaModel {
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DetectLungNoduleResponseBodyDataSeries> Series { get; set; }
            public class DetectLungNoduleResponseBodyDataSeries : TeaModel {
                [NameInMap("Elements")]
                [Validation(Required=false)]
                public List<DetectLungNoduleResponseBodyDataSeriesElements> Elements { get; set; }
                public class DetectLungNoduleResponseBodyDataSeriesElements : TeaModel {
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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
