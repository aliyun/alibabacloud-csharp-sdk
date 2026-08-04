// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPolicesForPrivateAccessTagResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D169859-A4F2-5EC8-853B-8447787C0D8A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of private network access tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListPolicesForPrivateAccessTagResponseBodyTags> Tags { get; set; }
        public class ListPolicesForPrivateAccessTagResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>Collection of private network access policies.</para>
            /// </summary>
            [NameInMap("Polices")]
            [Validation(Required=false)]
            public List<ListPolicesForPrivateAccessTagResponseBodyTagsPolices> Polices { get; set; }
            public class ListPolicesForPrivateAccessTagResponseBodyTagsPolices : TeaModel {
                /// <summary>
                /// <para>The application type of the private network access policy. Values:</para>
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
                /// <para>Creation time of the private network access policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-21 14:10:16</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>A collection of custom user group attributes. Multiple custom user group attributes have an OR relationship and take effect as a union.</para>
                /// </summary>
                [NameInMap("CustomUserAttributes")]
                [Validation(Required=false)]
                public List<ListPolicesForPrivateAccessTagResponseBodyTagsPolicesCustomUserAttributes> CustomUserAttributes { get; set; }
                public class ListPolicesForPrivateAccessTagResponseBodyTagsPolicesCustomUserAttributes : TeaModel {
                    /// <summary>
                    /// <para>The identity provider ID of the user group. This value exists if the custom user group type is <b>department</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("IdpId")]
                    [Validation(Required=false)]
                    public int? IdpId { get; set; }

                    /// <summary>
                    /// <para>The relationship of the user group. Values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Equal</b>: Equal.</para>
                    /// </description></item>
                    /// <item><description><para><b>Unequal</b>: Unequal.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Equal</para>
                    /// </summary>
                    [NameInMap("Relation")]
                    [Validation(Required=false)]
                    public string Relation { get; set; }

                    /// <summary>
                    /// <para>The type of user group. Values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>username</b>: Username.</para>
                    /// </description></item>
                    /// <item><description><para><b>department</b>: Department.</para>
                    /// </description></item>
                    /// <item><description><para><b>email</b>: Mailbox.</para>
                    /// </description></item>
                    /// <item><description><para><b>telephone</b>: Mobile phone.</para>
                    /// </description></item>
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
                    /// <item><description><para>If the user group type is <b>username</b>, this indicates the username\&quot;s value. The length is 1 to 128 characters. It supports Chinese characters, uppercase and lowercase English letters, and can include numbers, periods (.), underscores (_), and hyphens (-).</para>
                    /// </description></item>
                    /// <item><description><para>If the user group type is <b>department</b>, this indicates the department\&quot;s value. For example: OU=Department 1,OU=SASE DingTalk.</para>
                    /// </description></item>
                    /// <item><description><para>If the user group type is <b>email</b>, this indicates the mailbox\&quot;s value. For example: username\@example.com.</para>
                    /// </description></item>
                    /// <item><description><para>If the user group type is <b>telephone</b>, this indicates the mobile phone\&quot;s value. For example: 13900001234.</para>
                    /// </description></item>
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
                /// <para>Description of the private network access policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一条内网访问策略</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Private network access policy name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>private_access_policy_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The action that the private access policy performs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Block</b>: Blocks access.</para>
                /// </description></item>
                /// <item><description><para><b>Allow</b>: Allows access.</para>
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
                /// <para>Private network access policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pa-policy-867ef4007c8a****</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                /// <summary>
                /// <para>The private network access policy priority. The number 1 indicates the highest priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The status of the private network access policy. Values:</para>
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
                /// <para>The user group type of the private network access policy. Values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Normal</b>: Normal user group.</para>
                /// </description></item>
                /// <item><description><para><b>Custom</b>: Custom user group.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("UserGroupType")]
                [Validation(Required=false)]
                public string UserGroupType { get; set; }

            }

            /// <summary>
            /// <para>Private network access tag ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-b927baf3e592****</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

    }

}
