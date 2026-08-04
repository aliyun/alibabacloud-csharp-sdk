// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdatePrivateAccessPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of applications associated with the internal network access policy. A single policy supports up to 100 application IDs.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>The application type for the internal network access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Application</b>: Application.</para>
        /// </description></item>
        /// <item><description><para><b>Tag</b>: Tag.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Application</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>This parameter specifies a collection of custom user groups for the private network access policy. It is required when the user group type is <b>Custom</b>. This collection is mutually exclusive with the user group ID collection, and you can specify a maximum of 10 custom user groups.</para>
        /// </summary>
        [NameInMap("CustomUserAttributes")]
        [Validation(Required=false)]
        public List<UpdatePrivateAccessPolicyRequestCustomUserAttributes> CustomUserAttributes { get; set; }
        public class UpdatePrivateAccessPolicyRequestCustomUserAttributes : TeaModel {
            /// <summary>
            /// <para>The identity provider ID for the custom user attribute. This parameter is required when UserGroupType is <b>department</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("IdpId")]
            [Validation(Required=false)]
            public int? IdpId { get; set; }

            /// <summary>
            /// <para>The relation used to match the custom user attribute. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Equal</b>: Equal to.</para>
            /// </description></item>
            /// <item><description><para><b>Unequal</b>: Not equal to.</para>
            /// </description></item>
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
            /// <para>The type of the custom user attribute. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>username</b>: Username.</para>
            /// </description></item>
            /// <item><description><para><b>department</b>: Department.</para>
            /// </description></item>
            /// <item><description><para><b>email</b>: Email address.</para>
            /// </description></item>
            /// <item><description><para><b>telephone</b>: Phone number.</para>
            /// </description></item>
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
            /// <para>The value of the custom user attribute.</para>
            /// <list type="bullet">
            /// <item><description><para>If UserGroupType is <b>username</b>, this is the username. The value must be 1 to 128 characters in length. It can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), asterisks (\*), at signs (@), and spaces.</para>
            /// </description></item>
            /// <item><description><para>If UserGroupType is <b>department</b>, this is the department name. Example: OU=Department 1,OU=SASE DingTalk.</para>
            /// </description></item>
            /// <item><description><para>If UserGroupType is <b>email</b>, this is the email address. Example: username\@example.com.</para>
            /// </description></item>
            /// <item><description><para>If UserGroupType is <b>telephone</b>, this is the phone number. Example: 13900001234.</para>
            /// </description></item>
            /// </list>
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
        /// <para>A description of the internal network access policy. The description must be 1 to 128 characters in length. It can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一条内网访问策略</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The action taken when a device does not meet the security baseline. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Block</b>: Block access.</para>
        /// </description></item>
        /// <item><description><para><b>Observe</b>: Monitor access.</para>
        /// </description></item>
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
        /// <para>The method used to update the internal network access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Cover</b> (default): Replace the existing application IDs, user group IDs, and custom user attributes with the values specified in <b>ApplicationIds</b>, <b>UserGroupIds</b>, and <b>CustomUserAttributes</b>.</para>
        /// </description></item>
        /// <item><description><para><b>Append</b>: Add the values specified in <b>ApplicationIds</b>, <b>UserGroupIds</b>, and <b>CustomUserAttributes</b> to the existing application IDs, user group IDs, and custom user attributes.</para>
        /// </description></item>
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
        /// <para>The action that the internal network access policy takes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Block</b>: Block access.</para>
        /// </description></item>
        /// <item><description><para><b>Allow</b>: Allow access.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Allow</para>
        /// </summary>
        [NameInMap("PolicyAction")]
        [Validation(Required=false)]
        public string PolicyAction { get; set; }

        /// <summary>
        /// <para>The ID of the internal network access policy. Get this value from one of the following operations:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~ListPrivateAccessPolices~~">ListPrivateAccessPolices</a>: List internal network access policies in batches.</para>
        /// </description></item>
        /// <item><description><para><a href="~~CreatePrivateAccessPolicy~~">CreatePrivateAccessPolicy</a>: Create an internal network access policy.</para>
        /// </description></item>
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
        /// <para>The priority of the internal network access policy. Priority 1 is the highest. Valid values: 1 to 1000. The maximum value is the total number of internal network access policies minus 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The status of the internal network access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The IDs of tags associated with the internal network access policy. A single policy supports up to 100 tag IDs.</para>
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
        /// <para>The IDs of trusted process groups.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("TrustedProcessGroupIds")]
        [Validation(Required=false)]
        public List<string> TrustedProcessGroupIds { get; set; }

        /// <summary>
        /// <para>The status of the trusted process feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: Disabled.</para>
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
        /// <para>The IDs of trusted software.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("TrustedSoftwareIds")]
        [Validation(Required=false)]
        public List<string> TrustedSoftwareIds { get; set; }

        /// <summary>
        /// <para>The IDs of user groups associated with the internal network access policy. This parameter is required when UserGroupMode is set to Normal. This parameter is mutually exclusive with <b>CustomUserAttributes</b>. A single policy supports up to 10,000 user groups. You can update up to 2,000 user group IDs at a time.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The user group type for the internal network access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: Regular user group.</para>
        /// </description></item>
        /// <item><description><para><b>Custom</b>: Custom user group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("UserGroupMode")]
        [Validation(Required=false)]
        public string UserGroupMode { get; set; }

        /// <summary>
        /// <para>The start time of the zero-trust policy\&quot;s effective period, in seconds since the Unix epoch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ValidFrom")]
        [Validation(Required=false)]
        public long? ValidFrom { get; set; }

        /// <summary>
        /// <para>The status of the effective time feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("ValidTimeStatus")]
        [Validation(Required=false)]
        public string ValidTimeStatus { get; set; }

        /// <summary>
        /// <para>The end time of the zero-trust policy\&quot;s effective period, in seconds since the Unix epoch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764727544</para>
        /// </summary>
        [NameInMap("ValidUntil")]
        [Validation(Required=false)]
        public long? ValidUntil { get; set; }

    }

}
