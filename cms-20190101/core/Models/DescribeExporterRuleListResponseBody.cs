// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeExporterRuleListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// > The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the data export rules.
        /// </summary>
        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public DescribeExporterRuleListResponseBodyDatapoints Datapoints { get; set; }
        public class DescribeExporterRuleListResponseBodyDatapoints : TeaModel {
            [NameInMap("Datapoint")]
            [Validation(Required=false)]
            public List<DescribeExporterRuleListResponseBodyDatapointsDatapoint> Datapoint { get; set; }
            public class DescribeExporterRuleListResponseBodyDatapointsDatapoint : TeaModel {
                /// <summary>
                /// The time when the rule was created. The value is a UNIX timestamp.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The description of the rule.
                /// </summary>
                [NameInMap("Describe")]
                [Validation(Required=false)]
                public string Describe { get; set; }

                /// <summary>
                /// The associated dimensions.
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                [NameInMap("DstName")]
                [Validation(Required=false)]
                public DescribeExporterRuleListResponseBodyDatapointsDatapointDstName DstName { get; set; }
                public class DescribeExporterRuleListResponseBodyDatapointsDatapointDstName : TeaModel {
                    [NameInMap("DstName")]
                    [Validation(Required=false)]
                    public List<string> DstName { get; set; }

                }

                /// <summary>
                /// Indicates whether the rule is enabled.
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// The name of the metric.
                /// 
                /// > For more information, see [DescribeMetricMetaList](https://help.aliyun.com/document_detail/98846.html) or [Appendix 1: Metrics](https://help.aliyun.com/document_detail/28619.html).
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// The namespace of the service.
                /// 
                /// > For more information, see [DescribeMetricMetaList](https://help.aliyun.com/document_detail/98846.html) or [Appendix 1: Metrics](https://help.aliyun.com/document_detail/28619.html).
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The name of the data export rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The time window of the exported data.\\
                /// Multiple windows are separated with commas (,).
                /// 
                /// > Data in a time window of less than 60 seconds cannot be exported.
                /// </summary>
                [NameInMap("TargetWindows")]
                [Validation(Required=false)]
                public string TargetWindows { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
