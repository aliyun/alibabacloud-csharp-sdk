// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeExporterRuleListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the data export rules.</para>
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
                /// <para>The time when the rule was created. The value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1584024616228</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Export monitoring data</para>
                /// </summary>
                [NameInMap("Describe")]
                [Validation(Required=false)]
                public string Describe { get; set; }

                /// <summary>
                /// <para>The associated dimensions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;instanceId&quot;:&quot;xxxxx&quot;}</para>
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
                /// <para>Indicates whether the rule is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The name of the metric.</para>
                /// <remarks>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/28619.html">Appendix 1: Metrics</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>cpu_total</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The namespace of the service.</para>
                /// <remarks>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/28619.html">Appendix 1: Metrics</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>acs_ecs_dashboard</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The name of the data export rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myRuleName</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The time window of the exported data.\
                /// Multiple windows are separated with commas (,).</para>
                /// <remarks>
                /// <para>Data in a time window of less than 60 seconds cannot be exported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>60,300</para>
                /// </summary>
                [NameInMap("TargetWindows")]
                [Validation(Required=false)]
                public string TargetWindows { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>susscess</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BA047CA-8BC6-40BC-BC8F-FBECF35F1993</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
