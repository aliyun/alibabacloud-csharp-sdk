// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeQosRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of QoS rules.</para>
        /// </summary>
        [NameInMap("QosRules")]
        [Validation(Required=false)]
        public List<DescribeQosRulesResponseBodyQosRules> QosRules { get; set; }
        public class DescribeQosRulesResponseBodyQosRules : TeaModel {
            /// <summary>
            /// <para>The number of cloud computers in the pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public string DesktopCount { get; set; }

            /// <summary>
            /// <para>The number of cloud computer pools associated with the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopGroupCount")]
            [Validation(Required=false)]
            public int? DesktopGroupCount { get; set; }

            /// <summary>
            /// <para>The downstream bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Download")]
            [Validation(Required=false)]
            public string Download { get; set; }

            /// <summary>
            /// <para>The premium Internet bandwidth ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np-5cjh3sqs1ty3s02xq</para>
            /// </summary>
            [NameInMap("NetworkPackageId")]
            [Validation(Required=false)]
            public string NetworkPackageId { get; set; }

            /// <summary>
            /// <para>The QoS rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qos-chvkz5ekzgcb6bo0f</para>
            /// </summary>
            [NameInMap("QosRuleId")]
            [Validation(Required=false)]
            public string QosRuleId { get; set; }

            /// <summary>
            /// <para>The name of the QoS rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office network QoS rule</para>
            /// </summary>
            [NameInMap("QosRuleName")]
            [Validation(Required=false)]
            public string QosRuleName { get; set; }

            /// <summary>
            /// <para>The upstream bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Upload")]
            [Validation(Required=false)]
            public string Upload { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
