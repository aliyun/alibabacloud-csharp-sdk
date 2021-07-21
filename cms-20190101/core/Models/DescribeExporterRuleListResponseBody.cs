// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeExporterRuleListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public DescribeExporterRuleListResponseBodyDatapoints Datapoints { get; set; }
        public class DescribeExporterRuleListResponseBodyDatapoints : TeaModel {
            [NameInMap("Datapoint")]
            [Validation(Required=false)]
            public List<DescribeExporterRuleListResponseBodyDatapointsDatapoint> Datapoint { get; set; }
            public class DescribeExporterRuleListResponseBodyDatapointsDatapoint : TeaModel {
                public string MetricName { get; set; }
                public string Describe { get; set; }
                public string TargetWindows { get; set; }
                public long? CreateTime { get; set; }
                public bool? Enabled { get; set; }
                public string Dimension { get; set; }
                public string Namespace { get; set; }
                public string RuleName { get; set; }
                public DescribeExporterRuleListResponseBodyDatapointsDatapointDstName DstName { get; set; }
                public class DescribeExporterRuleListResponseBodyDatapointsDatapointDstName : TeaModel {
                    [NameInMap("DstName")]
                    [Validation(Required=false)]
                    public List<string> DstName { get; set; }

                }
            }
        };

    }

}
