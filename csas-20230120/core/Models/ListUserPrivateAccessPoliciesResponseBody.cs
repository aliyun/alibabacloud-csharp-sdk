// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserPrivateAccessPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of authorized access policies.</para>
        /// </summary>
        [NameInMap("Polices")]
        [Validation(Required=false)]
        public List<ListUserPrivateAccessPoliciesResponseBodyPolices> Polices { get; set; }
        public class ListUserPrivateAccessPoliciesResponseBodyPolices : TeaModel {
            /// <summary>
            /// <para>The collection of custom user group attributes. Multiple custom user group attributes have an OR relationship and take effect as a union.</para>
            /// </summary>
            [NameInMap("CustomUserAttributes")]
            [Validation(Required=false)]
            public List<ListUserPrivateAccessPoliciesResponseBodyPolicesCustomUserAttributes> CustomUserAttributes { get; set; }
            public class ListUserPrivateAccessPoliciesResponseBodyPolicesCustomUserAttributes : TeaModel {
                /// <summary>
                /// <para>The identity provider ID of the user group. This value exists when the custom user group type is <b>department</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public int? IdpId { get; set; }

                /// <summary>
                /// <para>The relationship of the user group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Equal</b>: equal to.</description></item>
                /// <item><description><b>Unequal</b>: not equal to.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Equal</para>
                /// </summary>
                [NameInMap("Relation")]
                [Validation(Required=false)]
                public string Relation { get; set; }

                /// <summary>
                /// <para>The type of the user group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>username</b>: the username.</description></item>
                /// <item><description><b>department</b>: the department.</description></item>
                /// <item><description><b>email</b>: the email address.</description></item>
                /// <item><description><b>telephone</b>: the mobile phone number.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("UserGroupType")]
                [Validation(Required=false)]
                public string UserGroupType { get; set; }

                /// <summary>
                /// <para>The value of the user group attribute.</para>
                /// <list type="bullet">
                /// <item><description>When the user group type is <b>username</b>, this parameter indicates the value of the username. The value must be 1 to 128 characters in length, and can contain Chinese characters, uppercase letters, lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</description></item>
                /// <item><description>When the user group type is <b>department</b>, this parameter indicates the value of the department. For example: OU=Department1,OU=SASE DingTalk.</description></item>
                /// <item><description>When the user group type is <b>email</b>, this parameter indicates the value of the email address. For example: <a href="mailto:username@example.com">username@example.com</a>.</description></item>
                /// <item><description>When the user group type is <b>telephone</b>, this parameter indicates the value of the mobile phone number. For example: 13900001234.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OU=部门1,OU=SASE钉钉</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The associated security baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>device_attribute_name</para>
            /// </summary>
            [NameInMap("DeviceAttributeName")]
            [Validation(Required=false)]
            public string DeviceAttributeName { get; set; }

            /// <summary>
            /// <para>The user group to which the policy belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_group_name</para>
            /// </summary>
            [NameInMap("MatchedUserGroup")]
            [Validation(Required=false)]
            public string MatchedUserGroup { get; set; }

            /// <summary>
            /// <para>The name of the private access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>private_access_policy_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The action of the private access policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Block</b>: blocks the access.</description></item>
            /// <item><description><b>Allow</b>: allows the access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("PolicyAction")]
            [Validation(Required=false)]
            public string PolicyAction { get; set; }

            /// <summary>
            /// <para>The ID of the private access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-policy-1b0d0e8b4bcf****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The priority of the private access policy. The number 1 indicates the highest priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>The list of trusted process group IDs.</para>
            /// </summary>
            [NameInMap("TrustedProcessGroupIds")]
            [Validation(Required=false)]
            public List<string> TrustedProcessGroupIds { get; set; }

            /// <summary>
            /// <para>The list of trusted software IDs.</para>
            /// </summary>
            [NameInMap("TrustedSoftwareIds")]
            [Validation(Required=false)]
            public List<string> TrustedSoftwareIds { get; set; }

            /// <summary>
            /// <para>The user group type of the private access policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: a normal user group.</description></item>
            /// <item><description><b>Custom</b>: a custom user group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("UserGroupMode")]
            [Validation(Required=false)]
            public string UserGroupMode { get; set; }

        }

        /// <summary>
        /// <para>Id of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9D852F87-AFB5-51B8-AACD-F7D0EFB8277D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of authorized access policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
