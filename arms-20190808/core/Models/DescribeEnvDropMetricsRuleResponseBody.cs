// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeEnvDropMetricsRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEnvDropMetricsRuleResponseBodyData Data { get; set; }
        public class DescribeEnvDropMetricsRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The metrics to be dropped. Metrics are separated by line breaks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kube_pod_created</para>
            /// </summary>
            [NameInMap("DropMetrics")]
            [Validation(Required=false)]
            public string DropMetrics { get; set; }

            /// <summary>
            /// <para>The name of the metric drop rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ruleName1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7781D4A-2818-41E7-B7BB-79D809E9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
