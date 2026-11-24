// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdatePrivateAccessPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the applications in the private access policy. A single policy supports up to 100 private access application IDs.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>The application type of the private access policy. Valid values:</para>
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
        /// <para>The custom user groups in the private access policy. This parameter is required when the user group type is <b>Custom</b>. This parameter is mutually exclusive with the user group IDs. You can specify up to 10 custom user groups.</para>
        /// </summary>
        [NameInMap("CustomUserAttributes")]
        [Validation(Required=false)]
        public List<UpdatePrivateAccessPolicyRequestCustomUserAttributes> CustomUserAttributes { get; set; }
        public class UpdatePrivateAccessPolicyRequestCustomUserAttributes : TeaModel {
            /// <summary>
            /// <para>The ID of the identity source for the custom user group. This parameter is required when the custom user group type is <b>department</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("IdpId")]
            [Validation(Required=false)]
            public int? IdpId { get; set; }

            /// <summary>
            /// <para>The relation of the custom user group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Equal</b>: Equal to.</description></item>
            /// <item><description><b>Unequal</b>: Not equal to.</description></item>
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
            /// <para>The type of the custom user group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>username</b>: Username.</description></item>
            /// <item><description><b>department</b>: Department.</description></item>
            /// <item><description><b>email</b>: Email address.</description></item>
            /// <item><description><b>telephone</b>: Mobile phone number.</description></item>
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
            /// <para>The value of the custom user group attribute.</para>
            /// <list type="bullet">
            /// <item><description>If the user group type is <b>username</b>, this parameter specifies the username. The value must be 1 to 128 characters in length, and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), asterisks (*), at signs (@), and spaces.</description></item>
            /// <item><description>If the user group type is <b>department</b>, this parameter specifies the department. Example: OU=Department 1,OU=SASE DingTalk.</description></item>
            /// <item><description>If the user group type is <b>email</b>, this parameter specifies the email address. Example: <a href="mailto:username@example.com">username@example.com</a>.</description></item>
            /// <item><description>If the user group type is <b>telephone</b>, this parameter specifies the mobile phone number. Example: 13900001234.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OU=Department 1,OU=SASE DingTalk</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The description of the private access policy. The description must be 1 to 128 characters in length, and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a private access policy</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The action to take when the security baseline is not met. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Block</b>: Blocks.</description></item>
        /// <item><description><b>Observe</b>: Observes.</description></item>
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
        /// <para>The modification type of the private access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b> (default): Overwrites the original application IDs, user group IDs, and custom user groups with the values of the <b>ApplicationIds</b>, <b>UserGroupIds</b>, and <b>CustomUserAttributes</b> parameters.</description></item>
        /// <item><description><b>Append</b>: Appends the values of the <b>ApplicationIds</b>, <b>UserGroupIds</b>, and <b>CustomUserAttributes</b> parameters to the original application IDs, user group IDs, and custom user groups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The Policy Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The action of the private access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Block</b>: Blocks.</description></item>
        /// <item><description><b>Allow</b>: Allows.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Allow</para>
        /// </summary>
        [NameInMap("PolicyAction")]
        [Validation(Required=false)]
        public string PolicyAction { get; set; }

        /// <summary>
        /// <para>The ID of the private access policy. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessPolices~~">ListPrivateAccessPolices</a>: Queries private access policies.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessPolicy~~">CreatePrivateAccessPolicy</a>: Creates a private access policy.</description></item>
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
        /// <para>The policy priority of the internal network access policy. A value of 1 indicates the highest priority. Valid values: 1 to 1000. The maximum value is the total number of internal network access policies minus one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The status of the private access policy. Valid values:</para>
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
        /// <para>The IDs of the tags in the private access policy. A single policy supports up to 100 private access tag IDs.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

        /// <summary>
        /// <para>The ID of the trigger template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dag-d3f64e8bdd4a****</para>
        /// </summary>
        [NameInMap("TriggerTemplateId")]
        [Validation(Required=false)]
        public string TriggerTemplateId { get; set; }

        /// <summary>
        /// <para>The IDs of the trusted process groups.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("TrustedProcessGroupIds")]
        [Validation(Required=false)]
        public List<string> TrustedProcessGroupIds { get; set; }

        /// <summary>
        /// <para>The status of the trusted process switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("TrustedProcessStatus")]
        [Validation(Required=false)]
        public string TrustedProcessStatus { get; set; }

        /// <summary>
        /// <para>The IDs of the trusted software.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("TrustedSoftwareIds")]
        [Validation(Required=false)]
        public List<string> TrustedSoftwareIds { get; set; }

        /// <summary>
        /// <para>The IDs of the user groups in the private access policy. This parameter is required when the user group type is <b>Normal</b>. This parameter is mutually exclusive with the custom user groups. A single policy supports up to 10,000 user groups, and you can modify up to 2,000 user group IDs at a time.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The user group type of the private access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Regular user group.</description></item>
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
        /// <para>The start time when the zero trust policy takes effect. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ValidFrom")]
        [Validation(Required=false)]
        public long? ValidFrom { get; set; }

        /// <summary>
        /// <para>The status of the effective period switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Shutdown.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("ValidTimeStatus")]
        [Validation(Required=false)]
        public string ValidTimeStatus { get; set; }

        /// <summary>
        /// <para>The end time when the zero trust policy takes effect. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764727544</para>
        /// </summary>
        [NameInMap("ValidUntil")]
        [Validation(Required=false)]
        public long? ValidUntil { get; set; }

    }

}
