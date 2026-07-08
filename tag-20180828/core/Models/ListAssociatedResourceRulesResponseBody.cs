// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListAssociatedResourceRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>You can use the <c>NextToken</c> parameter to determine whether there is a token that can be used to start the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>NextToken</c> is empty, no next query is performed.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned for <c>NextToken</c>, the value is the token that is used for the next query.</para>
        /// </description></item>
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
        /// <para>The Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6E27F22C-EDA3-132E-A53F-77DE3BC2343D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of associated resource rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListAssociatedResourceRulesResponseBodyRules> Rules { get; set; }
        public class ListAssociatedResourceRulesResponseBodyRules : TeaModel {
            [NameInMap("ExistingStatus")]
            [Validation(Required=false)]
            public string ExistingStatus { get; set; }

            /// <summary>
            /// <para>The name of the associated resource rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule:UpdateLoadBalancerZones-UpdateLoadBalancerAddressTypeConfig-TagAlb:Alb-LoadBalancer:Vpc-Eip</para>
            /// </summary>
            [NameInMap("SettingName")]
            [Validation(Required=false)]
            public string SettingName { get; set; }

            /// <summary>
            /// <para>The status of the associated resource rule. Valid values: <c>Enable</c> and <c>Disable</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Disable/Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The Tag Keys to which the rule applies.</para>
            /// </summary>
            [NameInMap("TagKeys")]
            [Validation(Required=false)]
            public List<string> TagKeys { get; set; }

        }

    }

}
