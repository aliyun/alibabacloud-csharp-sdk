// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessPolicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The private access policies.</para>
        /// </summary>
        [NameInMap("Polices")]
        [Validation(Required=false)]
        public List<ListPrivateAccessPolicesResponseBodyPolices> Polices { get; set; }
        public class ListPrivateAccessPolicesResponseBodyPolices : TeaModel {
            /// <summary>
            /// <para>The IDs of the applications that are specified in the private access policy. If the value of ApplicationType is <b>Application</b>, this parameter is returned.</para>
            /// </summary>
            [NameInMap("ApplicationIds")]
            [Validation(Required=false)]
            public List<string> ApplicationIds { get; set; }

            /// <summary>
            /// <para>The application type of the private access policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Application</b></description></item>
            /// <item><description><b>Tag</b></description></item>
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
            /// <para>The attributes of the custom user group. The attributes of the custom user group are evaluated by using a logical OR. If an attribute is matched, the policy takes effect.</para>
            /// </summary>
            [NameInMap("CustomUserAttributes")]
            [Validation(Required=false)]
            public List<ListPrivateAccessPolicesResponseBodyPolicesCustomUserAttributes> CustomUserAttributes { get; set; }
            public class ListPrivateAccessPolicesResponseBodyPolicesCustomUserAttributes : TeaModel {
                /// <summary>
                /// <para>The ID of the identity provider (IdP) for the user group. If the value of UserGroupType is <b>department</b>, this parameter is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public int? IdpId { get; set; }

                /// <summary>
                /// <para>The logical operator for the user group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Equal</b></description></item>
                /// <item><description><b>Unequal</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Equal</para>
                /// </summary>
                [NameInMap("Relation")]
                [Validation(Required=false)]
                public string Relation { get; set; }

                /// <summary>
                /// <para>The type of the user group, which is the key of the attribute. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>username</b></description></item>
                /// <item><description><b>department</b></description></item>
                /// <item><description><b>email</b></description></item>
                /// <item><description><b>telephone</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("UserGroupType")]
                [Validation(Required=false)]
                public string UserGroupType { get; set; }

                /// <summary>
                /// <para>The value of the attribute.</para>
                /// <list type="bullet">
                /// <item><description>If the value of UserGroupType is <b>username</b>, the value of this parameter is a username. The value must be 1 to 128 characters in length and can contain letters, digits, hyphens (-), underscores (_), and periods (.).</description></item>
                /// <item><description>If the value of UserGroupType is <b>department</b>, the value of this parameter is a department. Examples: OU=Department 1, OU=SASE DingTalk.</description></item>
                /// <item><description>If the value of UserGroupType is <b>email</b>, the value of this parameter is an email address. Example: <a href="mailto:username@example.com">username@example.com</a>.</description></item>
                /// <item><description>If the value of UserGroupType is <b>telephone</b>, the value of this parameter is a mobile phone number. Example: 13900001234.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OU=Department 1, OU=SASE DingTalk</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The description of the private access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a private access policy</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The action that is performed when the security baseline is not met. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Block</b></description></item>
            /// <item><description><b>Observe</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Block</para>
            /// </summary>
            [NameInMap("DeviceAttributeAction")]
            [Validation(Required=false)]
            public string DeviceAttributeAction { get; set; }

            /// <summary>
            /// <para>The ID of the security baseline.</para>
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
            /// <para>The action in the private access policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Block</b></description></item>
            /// <item><description><b>Allow</b></description></item>
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
            /// <para>The priority of the private access policy. The value 1 indicates the highest priority.</para>
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
            /// <item><description><b>Enabled</b></description></item>
            /// <item><description><b>Disabled</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The IDs of the tags that are specified in the private access policy. If the value of ApplicationType is <b>Tag</b>, this parameter is returned.</para>
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
            /// <para>List of trusted process group IDs.</para>
            /// </summary>
            [NameInMap("TrustedProcessGroupIds")]
            [Validation(Required=false)]
            public List<string> TrustedProcessGroupIds { get; set; }

            /// <summary>
            /// <para>Trusted process switch status. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: On.</description></item>
            /// <item><description><b>Disabled</b>: Off.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("TrustedProcessStatus")]
            [Validation(Required=false)]
            public string TrustedProcessStatus { get; set; }

            /// <summary>
            /// <para>List of trusted software IDs.</para>
            /// </summary>
            [NameInMap("TrustedSoftwareIds")]
            [Validation(Required=false)]
            public List<string> TrustedSoftwareIds { get; set; }

            /// <summary>
            /// <para>The IDs of user groups in the private access policy. If the value of UserGroupMode is <b>Normal</b>, this parameter is returned.</para>
            /// </summary>
            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<string> UserGroupIds { get; set; }

            /// <summary>
            /// <para>The type of the user group in the private access policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: regular user group.</description></item>
            /// <item><description><b>Custom</b>: custom user group.</description></item>
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
