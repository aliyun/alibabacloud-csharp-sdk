// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserGroupsForRegistrationPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of device registration policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListUserGroupsForRegistrationPolicyResponseBodyPolicies> Policies { get; set; }
        public class ListUserGroupsForRegistrationPolicyResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The ID of the device registration policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>reg-policy-f25c9e5872e5****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>A collection of user groups associated with the device registration policy.</para>
            /// </summary>
            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public List<ListUserGroupsForRegistrationPolicyResponseBodyPoliciesUserGroups> UserGroups { get; set; }
            public class ListUserGroupsForRegistrationPolicyResponseBodyPoliciesUserGroups : TeaModel {
                /// <summary>
                /// <para>A collection of user group attributes.</para>
                /// </summary>
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public List<ListUserGroupsForRegistrationPolicyResponseBodyPoliciesUserGroupsAttributes> Attributes { get; set; }
                public class ListUserGroupsForRegistrationPolicyResponseBodyPoliciesUserGroupsAttributes : TeaModel {
                    /// <summary>
                    /// <para>The identity provider ID for the user group. This field appears only when UserGroupType is <b>department</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("IdpId")]
                    [Validation(Required=false)]
                    public int? IdpId { get; set; }

                    /// <summary>
                    /// <para>The relation for the user group. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Equal</b>: Equal to.</para>
                    /// </description></item>
                    /// <item><description><para><b>Unequal</b>: Not equal to.</para>
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
                    /// <para>The type of the user group. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>username</b>: A username.</para>
                    /// </description></item>
                    /// <item><description><para><b>department</b>: A department.</para>
                    /// </description></item>
                    /// <item><description><para><b>email</b>: An email address.</para>
                    /// </description></item>
                    /// <item><description><para><b>telephone</b>: A phone number.</para>
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
                    /// <item><description><para>If UserGroupType is <b>username</b>, this is the username. It must be 1–128 characters long and can contain uppercase and lowercase letters, Chinese characters, digits, periods (.), underscores (_), and hyphens (-).</para>
                    /// </description></item>
                    /// <item><description><para>If UserGroupType is <b>department</b>, this is the department name. Example: OU=Department 1,OU=SASE DingTalk.</para>
                    /// </description></item>
                    /// <item><description><para>If UserGroupType is <b>email</b>, this is the email address. Example: username\@example.com.</para>
                    /// </description></item>
                    /// <item><description><para>If UserGroupType is <b>telephone</b>, this is the phone number. Example: 13900001234.</para>
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
                /// <para>The time when the user group was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-27 18:10:25</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>A description of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一条被设备注册策略引用的用户组。</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_group_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the user group.</para>
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
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D89009C7-54C6-51B6-BAE7-3F373920C6BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
