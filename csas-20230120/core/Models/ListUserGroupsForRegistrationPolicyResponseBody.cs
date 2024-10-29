// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserGroupsForRegistrationPolicyResponseBody : TeaModel {
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListUserGroupsForRegistrationPolicyResponseBodyPolicies> Policies { get; set; }
        public class ListUserGroupsForRegistrationPolicyResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>reg-policy-f25c9e5872e5****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public List<ListUserGroupsForRegistrationPolicyResponseBodyPoliciesUserGroups> UserGroups { get; set; }
            public class ListUserGroupsForRegistrationPolicyResponseBodyPoliciesUserGroups : TeaModel {
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public List<ListUserGroupsForRegistrationPolicyResponseBodyPoliciesUserGroupsAttributes> Attributes { get; set; }
                public class ListUserGroupsForRegistrationPolicyResponseBodyPoliciesUserGroupsAttributes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("IdpId")]
                    [Validation(Required=false)]
                    public int? IdpId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Equal</para>
                    /// </summary>
                    [NameInMap("Relation")]
                    [Validation(Required=false)]
                    public string Relation { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>department</para>
                    /// </summary>
                    [NameInMap("UserGroupType")]
                    [Validation(Required=false)]
                    public string UserGroupType { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-09-27 18:10:25</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user_group_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>usergroup-6f1ef2fc56b6****</para>
                /// </summary>
                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D89009C7-54C6-51B6-BAE7-3F373920C6BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
