// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeQosRulesResponseBody : TeaModel {
        [NameInMap("QosRules")]
        [Validation(Required=false)]
        public List<DescribeQosRulesResponseBodyQosRules> QosRules { get; set; }
        public class DescribeQosRulesResponseBodyQosRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public string DesktopCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Download")]
            [Validation(Required=false)]
            public string Download { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>np-5cjh3sqs1ty3s02xq</para>
            /// </summary>
            [NameInMap("NetworkPackageId")]
            [Validation(Required=false)]
            public string NetworkPackageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qos-chvkz5ekzgcb6bo0f</para>
            /// </summary>
            [NameInMap("QosRuleId")]
            [Validation(Required=false)]
            public string QosRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("QosRuleName")]
            [Validation(Required=false)]
            public string QosRuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Upload")]
            [Validation(Required=false)]
            public string Upload { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
