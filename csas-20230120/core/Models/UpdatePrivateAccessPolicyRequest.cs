// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdatePrivateAccessPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Set of application IDs for the private access policy. A single policy supports up to 100 private access application IDs.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>Application type of the private access policy. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Application</b>: Application.</description></item>
        /// <item><description><b>Tag</b>: Tag.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Application</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>Set of custom user attributes for the private access policy, required when the user group type is <b>Custom</b>. Mutually exclusive with the user group ID set. The total number of custom user groups is limited to 10.</para>
        /// </summary>
        [NameInMap("CustomUserAttributes")]
        [Validation(Required=false)]
        public List<UpdatePrivateAccessPolicyRequestCustomUserAttributes> CustomUserAttributes { get; set; }
        public class UpdatePrivateAccessPolicyRequestCustomUserAttributes : TeaModel {
            /// <summary>
            /// <para>The identity source ID of the custom user group. Required when the custom user group type is <b>department</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("IdpId")]
            [Validation(Required=false)]
            public int? IdpId { get; set; }

            /// <summary>
            /// <para>Relation of the custom user group. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>Equal</b>: Equal.</description></item>
            /// <item><description><b>Unequal</b>: Not equal.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Equal</para>
            /// </summary>
            [NameInMap("Relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

            /// <summary>
            /// <para>Type of the custom user group. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>username</b>: Username.</description></item>
            /// <item><description><b>department</b>: Department.</description></item>
            /// <item><description><b>email</b>: Email.</description></item>
            /// <item><description><b>telephone</b>: Telephone.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>department</para>
            /// </summary>
            [NameInMap("UserGroupType")]
            [Validation(Required=false)]
            public string UserGroupType { get; set; }

            /// <summary>
            /// <para>Custom user group attribute values. - When the user group type is <b>username</b>, it represents the value of the username. The length should be 1 to 128 characters, supporting Chinese and case-sensitive English letters, and can include numbers, half-width periods (.), underscores (_), hyphens (-), asterisks (*), at symbols (@), and spaces. - When the user group type is <b>department</b>, it represents the value of the department. For example: OU=Department1,OU=SASE DingTalk. - When the user group type is <b>email</b>, it represents the value of the email. For example: <a href="mailto:username@example.com">username@example.com</a>. - When the user group type is <b>telephone</b>, it represents the value of the mobile phone. For example: 13900001234.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OU=部门1,OU=SASE钉钉</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Description of the private access policy. Length should be 1 to 128 characters, supporting Chinese and English letters (both uppercase and lowercase), and can include numbers, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution strategy for not meeting the security baseline. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Block</b>: Block.</description></item>
        /// <item><description><b>Observe</b>: Observe.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Block</para>
        /// </summary>
        [NameInMap("DeviceAttributeAction")]
        [Validation(Required=false)]
        public string DeviceAttributeAction { get; set; }

        /// <summary>
        /// <para>The ID of the security baseline policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dag-d3f64e8bdd4a****</para>
        /// </summary>
        [NameInMap("DeviceAttributeId")]
        [Validation(Required=false)]
        public string DeviceAttributeId { get; set; }

        /// <summary>
        /// <para>The modification type of the private access policy. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b> (default): Use the values of <b>ApplicationIds</b>, <b>UserGroupIds</b>, and <b>CustomUserAttributes</b> to overwrite the original application ID set, user group ID set, and custom user attribute set, respectively.</description></item>
        /// <item><description><b>Append</b>: Add the values provided in <b>ApplicationIds</b>, <b>UserGroupIds</b>, and <b>CustomUserAttributes</b> to the original application ID set, user group ID set, and custom user attribute set, respectively.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Action of the private access policy. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Block</b>: Block.</description></item>
        /// <item><description><b>Allow</b>: Allow.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Allow</para>
        /// </summary>
        [NameInMap("PolicyAction")]
        [Validation(Required=false)]
        public string PolicyAction { get; set; }

        /// <summary>
        /// <para>ID of the private access policy. Value sources:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessPolicies~~">ListPrivateAccessPolicies</a>: Batch query for private access policies.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessPolicy~~">CreatePrivateAccessPolicy</a>: Create a private access policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-policy-63b2f1844b86****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The priority of the private access policy. The number 1 indicates the highest priority. Range: 1~1000, with the maximum value being the total number of private access policies minus one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The status of the private access policy. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Set of tag IDs for the private access policy. A single policy supports up to 100 private access tag IDs.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

        /// <summary>
        /// <para>The trigger template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dag-d3f64e8bdd4a****</para>
        /// </summary>
        [NameInMap("TriggerTemplateId")]
        [Validation(Required=false)]
        public string TriggerTemplateId { get; set; }

        /// <summary>
        /// <para>Trusted process group ID.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("TrustedProcessGroupIds")]
        [Validation(Required=false)]
        public List<string> TrustedProcessGroupIds { get; set; }

        /// <summary>
        /// <para>Trusted process switch status. Values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b>: On. </para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: Off.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("TrustedProcessStatus")]
        [Validation(Required=false)]
        public string TrustedProcessStatus { get; set; }

        /// <summary>
        /// <para>Trusted Software ID.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("TrustedSoftwareIds")]
        [Validation(Required=false)]
        public List<string> TrustedSoftwareIds { get; set; }

        /// <summary>
        /// <para>Set of user group IDs for the private access policy, required when the user group type is <b>Normal</b>. Mutually exclusive with the custom user group set. A single policy supports up to 10,000 user groups, and a maximum of 2,000 user group IDs can be modified at once.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>User group type of the private access policy. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Normal user group.</description></item>
        /// <item><description><b>Custom</b>: Custom user group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("UserGroupMode")]
        [Validation(Required=false)]
        public string UserGroupMode { get; set; }

        /// <summary>
        /// <para>The start time when the zero trust policy takes effect, represented as a timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ValidFrom")]
        [Validation(Required=false)]
        public long? ValidFrom { get; set; }

        /// <summary>
        /// <para>Switch status for effective time. Values: - <b>Enabled</b>: On. - <b>Disabled</b>: Off.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("ValidTimeStatus")]
        [Validation(Required=false)]
        public string ValidTimeStatus { get; set; }

        /// <summary>
        /// <para>The expiration time of the zero trust policy, in seconds timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764727544</para>
        /// </summary>
        [NameInMap("ValidUntil")]
        [Validation(Required=false)]
        public long? ValidUntil { get; set; }

    }

}
