// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserGroupsForPrivateAccessPolicyResponseBody : TeaModel {
        [NameInMap("Polices")]
        [Validation(Required=false)]
        public List<ListUserGroupsForPrivateAccessPolicyResponseBodyPolices> Polices { get; set; }
        public class ListUserGroupsForPrivateAccessPolicyResponseBodyPolices : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pa-policy-1b0d0e8b4bcf****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public List<ListUserGroupsForPrivateAccessPolicyResponseBodyPolicesUserGroups> UserGroups { get; set; }
            public class ListUserGroupsForPrivateAccessPolicyResponseBodyPolicesUserGroups : TeaModel {
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public List<ListUserGroupsForPrivateAccessPolicyResponseBodyPolicesUserGroupsAttributes> Attributes { get; set; }
                public class ListUserGroupsForPrivateAccessPolicyResponseBodyPolicesUserGroupsAttributes : TeaModel {
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
                /// <para>用户组创建时间。</para>
                /// 
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
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
