// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeDSTTopologyResponseBody : TeaModel {
        [NameInMap("EdgeMetrics")]
        [Validation(Required=false)]
        public List<DescribeDSTTopologyResponseBodyEdgeMetrics> EdgeMetrics { get; set; }
        public class DescribeDSTTopologyResponseBodyEdgeMetrics : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeDSTTopologyResponseBodyEdgeMetricsValues> Values { get; set; }
            public class DescribeDSTTopologyResponseBodyEdgeMetricsValues : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<DescribeDSTTopologyResponseBodyEdgeMetricsValuesValue> Value { get; set; }
                public class DescribeDSTTopologyResponseBodyEdgeMetricsValuesValue : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDSTTopologyResponseBodyEdgeMetricsTags> Tags { get; set; }
            public class DescribeDSTTopologyResponseBodyEdgeMetricsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NodeMetrics")]
        [Validation(Required=false)]
        public List<DescribeDSTTopologyResponseBodyNodeMetrics> NodeMetrics { get; set; }
        public class DescribeDSTTopologyResponseBodyNodeMetrics : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeDSTTopologyResponseBodyNodeMetricsValues> Values { get; set; }
            public class DescribeDSTTopologyResponseBodyNodeMetricsValues : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<DescribeDSTTopologyResponseBodyNodeMetricsValuesValue> Value { get; set; }
                public class DescribeDSTTopologyResponseBodyNodeMetricsValuesValue : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDSTTopologyResponseBodyNodeMetricsTags> Tags { get; set; }
            public class DescribeDSTTopologyResponseBodyNodeMetricsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Edges")]
        [Validation(Required=false)]
        public List<DescribeDSTTopologyResponseBodyEdges> Edges { get; set; }
        public class DescribeDSTTopologyResponseBodyEdges : TeaModel {
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribeDSTTopologyResponseBodyNodes> Nodes { get; set; }
        public class DescribeDSTTopologyResponseBodyNodes : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<DescribeDSTTopologyResponseBodyNodesDimensions> Dimensions { get; set; }
            public class DescribeDSTTopologyResponseBodyNodesDimensions : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
