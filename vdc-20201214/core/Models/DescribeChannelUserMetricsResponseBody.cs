// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeChannelUserMetricsResponseBody : TeaModel {
        [NameInMap("MetricDatas")]
        [Validation(Required=false)]
        public List<DescribeChannelUserMetricsResponseBodyMetricDatas> MetricDatas { get; set; }
        public class DescribeChannelUserMetricsResponseBodyMetricDatas : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeChannelUserMetricsResponseBodyMetricDatasNodes> Nodes { get; set; }
            public class DescribeChannelUserMetricsResponseBodyMetricDatasNodes : TeaModel {
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

        }

        [NameInMap("OverallData")]
        [Validation(Required=false)]
        public DescribeChannelUserMetricsResponseBodyOverallData OverallData { get; set; }
        public class DescribeChannelUserMetricsResponseBodyOverallData : TeaModel {
            [NameInMap("TotalBadExpNum")]
            [Validation(Required=false)]
            public long? TotalBadExpNum { get; set; }

            [NameInMap("TotalJoinFailNum")]
            [Validation(Required=false)]
            public long? TotalJoinFailNum { get; set; }

            [NameInMap("TotalPubUserNum")]
            [Validation(Required=false)]
            public long? TotalPubUserNum { get; set; }

            [NameInMap("TotalSubUserNum")]
            [Validation(Required=false)]
            public long? TotalSubUserNum { get; set; }

            [NameInMap("TotalUserNum")]
            [Validation(Required=false)]
            public long? TotalUserNum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
