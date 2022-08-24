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
                public List<DetectLungNoduleResponseBodyDataSeriesElements> Elements { get; set; }
                public class DetectLungNoduleResponseBodyDataSeriesElements : TeaModel {
                    public string Category { get; set; }
                    public float? Confidence { get; set; }
                    public float? Diameter { get; set; }
                    public float? ImageX { get; set; }
                    public float? ImageY { get; set; }
                    public float? ImageZ { get; set; }
                    public string Lobe { get; set; }
                    public string Lung { get; set; }
                    public float? MeanValue { get; set; }
                    public string SOPInstanceUID { get; set; }
                    public float? Volume { get; set; }
                    public float? X { get; set; }
                    public float? Y { get; set; }
                    public float? Z { get; set; }
                }
                public List<float?> Origin { get; set; }
                public string Report { get; set; }
                public string SeriesInstanceUid { get; set; }
                public List<float?> Spacing { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
