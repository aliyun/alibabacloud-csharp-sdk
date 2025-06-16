// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetPrivateAccessPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>Intranet access policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetPrivateAccessPolicyResponseBodyPolicy Policy { get; set; }
        public class GetPrivateAccessPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>A collection of application IDs for the private access policy. This field has a value when the application type is Application.</para>
            /// </summary>
            [NameInMap("ApplicationIds")]
            [Validation(Required=false)]
            public List<string> ApplicationIds { get; set; }

            /// <summary>
            /// <para>The application type of the private access policy. Possible values:</para>
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
            /// <para>Intranet access policy creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-29 11:26:02</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Collection of custom user group attributes. Multiple custom user group attributes are combined with an OR relationship and take effect as a set.</para>
            /// </summary>
            [NameInMap("CustomUserAttributes")]
            [Validation(Required=false)]
            public List<GetPrivateAccessPolicyResponseBodyPolicyCustomUserAttributes> CustomUserAttributes { get; set; }
            public class GetPrivateAccessPolicyResponseBodyPolicyCustomUserAttributes : TeaModel {
                /// <summary>
                /// <para>The identity provider ID for the custom user group. This field is required when the custom user group type is <b>department</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public int? IdpId { get; set; }

                /// <summary>
                /// <para>Custom user group relationship. Values: - <b>Equal</b>: Equal to. - <b>Unequal</b>: Not equal to.</para>
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
                /// <para>The value of the custom user group attribute.</para>
                /// <list type="bullet">
                /// <item><description>When the user group type is <b>username</b>, it represents the value of the username. The length should be 1 to 128 characters, supporting Chinese and case-sensitive English letters, and can include numbers, periods (.), underscores (_), and hyphens (-).</description></item>
                /// <item><description>When the user group type is <b>department</b>, it represents the value of the department. For example: OU=Department1,OU=SASE DingTalk.</description></item>
                /// <item><description>When the user group type is <b>email</b>, it represents the value of the email. For example: <a href="mailto:username@example.com">username@example.com</a>.</description></item>
                /// <item><description>When the user group type is <b>telephone</b>, it represents the value of the phone number. For example: 13900001234.</description></item>
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
            /// <para>Intranet access policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The action to take if the security baseline is not met. Possible values:</para>
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
            /// <para>Intranet access policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>private_access_policy_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Intranet access policy action. Values:</para>
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
            /// <para>Intranet access policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-policy-63b2f1844b86****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>Intranet access policy priority. A value of 1 indicates the highest priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>Intranet access policy status. Values:</para>
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
            /// <para>A collection of tag IDs for the private access policy. This field has a value when the application type is Tag.</para>
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
            /// <para>A list of trusted process group IDs.</para>
            /// </summary>
            [NameInMap("TrustedProcessGroupIds")]
            [Validation(Required=false)]
            public List<string> TrustedProcessGroupIds { get; set; }

            /// <summary>
            /// <para>The status of the trusted process switch. Possible values:</para>
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
            /// <para>A list of trusted software IDs.</para>
            /// </summary>
            [NameInMap("TrustedSoftwareIds")]
            [Validation(Required=false)]
            public List<string> TrustedSoftwareIds { get; set; }

            /// <summary>
            /// <para>Collection of user group IDs for the intranet access policy. This field is populated when the user group type is Normal.</para>
            /// </summary>
            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<string> UserGroupIds { get; set; }

            /// <summary>
            /// <para>User group type for the intranet access policy. Values:</para>
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

        }

        /// <summary>
        /// <para>The ID of the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E9D7ACD-53D5-56EF-A913-79D148D06299</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
