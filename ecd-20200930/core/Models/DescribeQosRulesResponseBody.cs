// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeQosRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of QoS rules.</para>
        /// </summary>
        [NameInMap("QosRules")]
        [Validation(Required=false)]
        public List<DescribeQosRulesResponseBodyQosRules> QosRules { get; set; }
        public class DescribeQosRulesResponseBodyQosRules : TeaModel {
            /// <summary>
            /// <para>The number of associated cloud desktops.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public string DesktopCount { get; set; }

            [NameInMap("DesktopGroupCount")]
            [Validation(Required=false)]
            public int? DesktopGroupCount { get; set; }

            /// <summary>
            /// <para>The download bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Download")]
            [Validation(Required=false)]
            public string Download { get; set; }

            /// <summary>
            /// <para>The network package ID.</para>
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
            /// <para>The QoS rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("QosRuleName")]
            [Validation(Required=false)]
            public string QosRuleName { get; set; }

            /// <summary>
            /// <para>The upload bandwidth.</para>
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
