// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The responses code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of alert rules in each state.</para>
        /// </summary>
        [NameInMap("MetricRuleCount")]
        [Validation(Required=false)]
        public DescribeMetricRuleCountResponseBodyMetricRuleCount MetricRuleCount { get; set; }
        public class DescribeMetricRuleCountResponseBodyMetricRuleCount : TeaModel {
            /// <summary>
            /// <para>The number of alert rules with active alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Alarm")]
            [Validation(Required=false)]
            public int? Alarm { get; set; }

            /// <summary>
            /// <para>The number of disabled alert rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Disable")]
            [Validation(Required=false)]
            public int? Disable { get; set; }

            /// <summary>
            /// <para>The number of alert rules without data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Nodata")]
            [Validation(Required=false)]
            public int? Nodata { get; set; }

            /// <summary>
            /// <para>The number of alert rules without active alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Ok")]
            [Validation(Required=false)]
            public int? Ok { get; set; }

            /// <summary>
            /// <para>The total number of alert rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FF38D33A-67C1-40EB-AB65-FAEE51EDB644</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
