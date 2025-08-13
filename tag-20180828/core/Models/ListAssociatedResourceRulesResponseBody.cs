// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListAssociatedResourceRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>Determine if there is a token for the next query based on <c>NextToken</c>. Values:</para>
        /// <list type="bullet">
        /// <item><description>If <c>NextToken</c> is empty, it indicates there is no next query.</description></item>
        /// <item><description>If <c>NextToken</c> has a value, that value is the token for the next query start.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6E27F22C-EDA3-132E-A53F-77DE3BC2343D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of associated resource tag rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListAssociatedResourceRulesResponseBodyRules> Rules { get; set; }
        public class ListAssociatedResourceRulesResponseBodyRules : TeaModel {
            [NameInMap("ExistingStatus")]
            [Validation(Required=false)]
            public string ExistingStatus { get; set; }

            /// <summary>
            /// <para>Setting name of the associated resource tag rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule:UpdateLoadBalancerZones-UpdateLoadBalancerAddressTypeConfig-TagAlb:Alb-LoadBalancer:Vpc-Eip</para>
            /// </summary>
            [NameInMap("SettingName")]
            [Validation(Required=false)]
            public string SettingName { get; set; }

            /// <summary>
            /// <para>Whether the associated resource tag rule is enabled. Values:</para>
            /// <list type="bullet">
            /// <item><description>Enable: Enabled.</description></item>
            /// <item><description>Disable: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disable/Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>List of tag keys for the associated resource tag rule.</para>
            /// </summary>
            [NameInMap("TagKeys")]
            [Validation(Required=false)]
            public List<string> TagKeys { get; set; }

        }

    }

}
