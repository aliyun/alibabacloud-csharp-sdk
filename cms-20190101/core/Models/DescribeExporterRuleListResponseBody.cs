// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeExporterRuleListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>A value of 200 indicates success. Any other value indicates failure.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public DescribeExporterRuleListResponseBodyDatapoints Datapoints { get; set; }
        public class DescribeExporterRuleListResponseBodyDatapoints : TeaModel {
            [NameInMap("Datapoint")]
            [Validation(Required=false)]
            public List<DescribeExporterRuleListResponseBodyDatapointsDatapoint> Datapoint { get; set; }
            public class DescribeExporterRuleListResponseBodyDatapointsDatapoint : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Describe")]
                [Validation(Required=false)]
                public string Describe { get; set; }

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

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("TargetWindows")]
                [Validation(Required=false)]
                public string TargetWindows { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
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
        /// <para>Indicates whether the call was successful. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Successful.</description></item>
        /// <item><description><c>false</c>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
