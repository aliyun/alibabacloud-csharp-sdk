// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessPolicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of private access policies.</para>
        /// </summary>
        [NameInMap("Polices")]
        [Validation(Required=false)]
        public List<ListPrivateAccessPolicesResponseBodyPolices> Polices { get; set; }
        public class ListPrivateAccessPolicesResponseBodyPolices : TeaModel {
            /// <summary>
            /// <para>The collection of application IDs of the private access policy. This field has a value when the application type is <b>Application</b>.</para>
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
            /// <para>The creation time of the private access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-10 15:50:23</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The collection of custom user group attributes. Multiple custom user group attributes have an OR relationship and take effect by union.</para>
            /// </summary>
            [NameInMap("CustomUserAttributes")]
            [Validation(Required=false)]
            public List<ListPrivateAccessPolicesResponseBodyPolicesCustomUserAttributes> CustomUserAttributes { get; set; }
            public class ListPrivateAccessPolicesResponseBodyPolicesCustomUserAttributes : TeaModel {
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
                /// <para>The relation of the user group. Valid values:</para>
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
                /// <para>The type of the user group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>username</b>: Username.</description></item>
                /// <item><description><b>department</b>: Department.</description></item>
                /// <item><description><b>email</b>: Email.</description></item>
                /// <item><description><b>telephone</b>: Mobile phone.</description></item>
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
                /// <item><description>When the user group type is <b>username</b>, this indicates the value of the username. The value must be 1 to 128 characters in length and supports Chinese characters and uppercase and lowercase English letters. It can contain digits, periods (.), underscores (_), and hyphens (-).</description></item>
                /// <item><description>When the user group type is <b>department</b>, this indicates the value of the department. For example: OU=Department1,OU=SASE DingTalk.</description></item>
                /// <item><description>When the user group type is <b>email</b>, this indicates the value of the email. For example: <a href="mailto:username@example.com">username@example.com</a>.</description></item>
                /// <item><description>When the user group type is <b>telephone</b>, this indicates the value of the mobile phone. For example: 13900001234.</description></item>
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
            /// <para>The description of the private access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一条内网访问策略</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The action to take when the security baseline is not met. Valid values:</para>
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
            /// <para>The ID of the private access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-policy-63b2f1844b86****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The priority of the private access policy. A value of 1 indicates the highest priority.</para>
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
            /// <para>The collection of tag IDs of the private access policy. This field has a value when the application type is <b>Tag</b>.</para>
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
            /// <para>The list of trusted process group IDs.</para>
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
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("TrustedProcessStatus")]
            [Validation(Required=false)]
            public string TrustedProcessStatus { get; set; }

            /// <summary>
            /// <para>The list of trusted software IDs.</para>
            /// </summary>
            [NameInMap("TrustedSoftwareIds")]
            [Validation(Required=false)]
            public List<string> TrustedSoftwareIds { get; set; }

            /// <summary>
            /// <para>The collection of user group IDs for the private access policy. This field has a value when the user group type is <b>Normal</b>.</para>
            /// </summary>
            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<string> UserGroupIds { get; set; }

            /// <summary>
            /// <para>The user group type of the private access policy. Valid values:</para>
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
            /// <para>The effective start time of the zero trust policy, in second-level Unix timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ValidFrom")]
            [Validation(Required=false)]
            public long? ValidFrom { get; set; }

            /// <summary>
            /// <para>The status of the effective time switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("ValidTimeStatus")]
            [Validation(Required=false)]
            public string ValidTimeStatus { get; set; }

            /// <summary>
            /// <para>The effective end time of the zero trust policy, in second-level Unix timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1764727544</para>
            /// </summary>
            [NameInMap("ValidUntil")]
            [Validation(Required=false)]
            public long? ValidUntil { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>748CFDC7-1EB6-5B8B-9405-DA76ED5BB60D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of private access policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
