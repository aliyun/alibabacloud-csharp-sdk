// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeEndPointMetricDataResponseBody : TeaModel {
        [NameInMap("PubMetrics")]
        [Validation(Required=false)]
        public List<DescribeEndPointMetricDataResponseBodyPubMetrics> PubMetrics { get; set; }
        public class DescribeEndPointMetricDataResponseBodyPubMetrics : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeEndPointMetricDataResponseBodyPubMetricsNodes> Nodes { get; set; }
            public class DescribeEndPointMetricDataResponseBodyPubMetricsNodes : TeaModel {
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubMetrics")]
        [Validation(Required=false)]
        public List<DescribeEndPointMetricDataResponseBodySubMetrics> SubMetrics { get; set; }
        public class DescribeEndPointMetricDataResponseBodySubMetrics : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeEndPointMetricDataResponseBodySubMetricsNodes> Nodes { get; set; }
            public class DescribeEndPointMetricDataResponseBodySubMetricsNodes : TeaModel {
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
