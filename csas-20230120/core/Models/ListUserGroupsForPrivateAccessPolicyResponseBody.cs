// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserGroupsForPrivateAccessPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>List of private network access policies.</para>
        /// </summary>
        [NameInMap("Polices")]
        [Validation(Required=false)]
        public List<ListUserGroupsForPrivateAccessPolicyResponseBodyPolices> Polices { get; set; }
        public class ListUserGroupsForPrivateAccessPolicyResponseBodyPolices : TeaModel {
            /// <summary>
            /// <para>Private network access policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-policy-1b0d0e8b4bcf****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>Collection of user groups for the private network access policy.</para>
            /// </summary>
            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public List<ListUserGroupsForPrivateAccessPolicyResponseBodyPolicesUserGroups> UserGroups { get; set; }
            public class ListUserGroupsForPrivateAccessPolicyResponseBodyPolicesUserGroups : TeaModel {
                /// <summary>
                /// <para>Collection of user group properties.</para>
                /// </summary>
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public List<ListUserGroupsForPrivateAccessPolicyResponseBodyPolicesUserGroupsAttributes> Attributes { get; set; }
                public class ListUserGroupsForPrivateAccessPolicyResponseBodyPolicesUserGroupsAttributes : TeaModel {
                    /// <summary>
                    /// <para>The identity source ID of the user group. This value exists if the custom user group type is <b>department</b>.</para>
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
                    /// <para>The type of the user group. Values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>username</b>: username.</para>
                    /// </description></item>
                    /// <item><description><para><b>department</b>: department.</para>
                    /// </description></item>
                    /// <item><description><para><b>email</b>: mailbox.</para>
                    /// </description></item>
                    /// <item><description><para><b>telephone</b>: telephone.</para>
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
                    /// <para>Value of the user group property.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If the user group type is <b>username</b>, this indicates the username\&quot;s value. The length is 1 to 128 characters. It supports Chinese characters and uppercase and lowercase English letters. It can contain numbers, periods (.), underscores (_), and hyphens (-).</para>
                    /// </description></item>
                    /// <item><description><para>If the user group type is <b>department</b>, this indicates the department\&quot;s value, such as OU=Department 1,OU=SASE DingTalk.</para>
                    /// </description></item>
                    /// <item><description><para>If the user group type is <b>email</b>, this indicates the mailbox\&quot;s value, such as username\@example.com.</para>
                    /// </description></item>
                    /// <item><description><para>If the user group type is <b>telephone</b>, this indicates the telephone\&quot;s value, such as 13900001234.</para>
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
                /// <para>User group creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-27 18:10:25</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>User group description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一条被内网访问策略引用的用户组</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>User group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_group_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>User group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>usergroup-6f1ef2fc56b6****</para>
                /// </summary>
                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
