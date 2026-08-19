// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreatePrivateAccessPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Set of application IDs for the private access policy. Up to 100 application IDs can be entered. Required when <b>ApplicationType</b> is <b>Application</b>. Mutually exclusive with <b>TagIds</b>.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>Set of custom user groups for the private access policy. Required when the user group type is <b>Custom</b>. Mutually exclusive with the user group ID set. Up to 10 custom user groups can be entered.</para>
        /// </summary>
        [NameInMap("CustomUserAttributes")]
        [Validation(Required=false)]
        public List<CreatePrivateAccessPolicyRequestCustomUserAttributes> CustomUserAttributes { get; set; }
        public class CreatePrivateAccessPolicyRequestCustomUserAttributes : TeaModel {
            /// <summary>
            /// <para>The ID of the identity source for the custom user group. Required when the custom user group type is <b>department</b>.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>department</para>
            /// </summary>
            [NameInMap("UserGroupType")]
            [Validation(Required=false)]
            public string UserGroupType { get; set; }

            /// <summary>
            /// <para>Value of the custom user group attribute.</para>
            /// <list type="bullet">
            /// <item><description>When the user group type is <b>username</b>, it represents the value of the username. The length is 1 to 128 characters, supporting Chinese and uppercase and lowercase English letters, and can include numbers, periods (.), underscores (_), hyphens (-), asterisks (*), at (@) symbols, and spaces.</description></item>
            /// <item><description>When the user group type is <b>department</b>, it represents the value of the department. For example: OU=Department1,OU=SASE DingTalk.</description></item>
            /// <item><description>When the user group type is <b>email</b>, it represents the value of the email. For example: <a href="mailto:username@example.com">username@example.com</a>.</description></item>
            /// <item><description>When the user group type is <b>telephone</b>, it represents the value of the telephone. For example: 13900001234.</description></item>
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
        /// <para>Description of the private access policy. The length is 1 to 128 characters, supporting Chinese and uppercase and lowercase English letters, and can include numbers, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution policy for not meeting the security baseline. Values:</para>
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
        /// <para>Name of the private access policy. The length is 1 to 128 characters, supporting Chinese and uppercase and lowercase English letters, and can include numbers, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private_access_policy_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Action of the private access policy. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Block</b>: Block.</description></item>
        /// <item><description><b>Allow</b>: Allow.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Allow</para>
        /// </summary>
        [NameInMap("PolicyAction")]
        [Validation(Required=false)]
        public string PolicyAction { get; set; }

        /// <summary>
        /// <para>The priority of the private access policy. The number 1 indicates the highest priority. Range: 1~1000, with the maximum value being the total number of private access policies.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Set of tag IDs for the private access policy. Up to 100 tag IDs can be entered. Required when <b>ApplicationType</b> is <b>Tag</b>. Mutually exclusive with <b>ApplicationIds</b>.</para>
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
        /// <para>The ID of the trusted process group.</para>
        /// </summary>
        [NameInMap("TrustedProcessGroupIds")]
        [Validation(Required=false)]
        public List<string> TrustedProcessGroupIds { get; set; }

        /// <summary>
        /// <para>The switch status of the trusted process. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("TrustedProcessStatus")]
        [Validation(Required=false)]
        public string TrustedProcessStatus { get; set; }

        /// <summary>
        /// <para>The ID of the trusted software.</para>
        /// </summary>
        [NameInMap("TrustedSoftwareIds")]
        [Validation(Required=false)]
        public List<string> TrustedSoftwareIds { get; set; }

        /// <summary>
        /// <para>Set of user group IDs for the private access policy. Required when the user group type is <b>Normal</b>. Mutually exclusive with the custom user group set. Up to 2000 user group IDs can be entered.</para>
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
        /// <para>This parameter is required.</para>
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
        /// <para>Disabled</para>
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
