// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeEnvDropMetricsRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEnvDropMetricsRuleResponseBodyData Data { get; set; }
        public class DescribeEnvDropMetricsRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of discarded metrics. Separate multiple metrics with line feeds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kube_pod_created</para>
            /// </summary>
            [NameInMap("DropMetrics")]
            [Validation(Required=false)]
            public string DropMetrics { get; set; }

            /// <summary>
            /// <para>The name of the discarded metric rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ruleName1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7781D4A-2818-41E7-B7BB-79D809E9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
