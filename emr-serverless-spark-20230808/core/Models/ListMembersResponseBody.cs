// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>一次获取的最大记录数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<ListMembersResponseBodyMembers> Members { get; set; }
        public class ListMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// <para>针对此用户允许的操作列表。</para>
            /// </summary>
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<ListMembersResponseBodyMembersActions> Actions { get; set; }
            public class ListMembersResponseBodyMembersActions : TeaModel {
                /// <summary>
                /// <para>行为 arn。</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:emr::w-1234****abcd:action/add_MEMBER</para>
                /// </summary>
                [NameInMap("actionArn")]
                [Validation(Required=false)]
                public string ActionArn { get; set; }

                /// <summary>
                /// <para>权限名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>add</para>
                /// </summary>
                [NameInMap("actionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// <para>action 依赖列表。</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;view&quot;]</para>
                /// </summary>
                [NameInMap("dependencies")]
                [Validation(Required=false)]
                public List<string> Dependencies { get; set; }

                /// <summary>
                /// <para>action 描述。</para>
                /// 
                /// <b>Example:</b>
                /// <para>add members</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>权限展示名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>add members</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1753412502000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>用户展示名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>jia***test</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>用户 arn。</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:emr::w-1234*<em><b>abcd:member/202265</b></em>**276</para>
            /// </summary>
            [NameInMap("memberArn")]
            [Validation(Required=false)]
            public string MemberArn { get; set; }

            /// <summary>
            /// <para>用户角色列表。</para>
            /// </summary>
            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<ListMembersResponseBodyMembersRoles> Roles { get; set; }
            public class ListMembersResponseBodyMembersRoles : TeaModel {
                /// <summary>
                /// <para>权限列表。</para>
                /// </summary>
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<ListMembersResponseBodyMembersRolesActions> Actions { get; set; }
                public class ListMembersResponseBodyMembersRolesActions : TeaModel {
                    /// <summary>
                    /// <para>行为 arn。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:emr::w-1234****abcd:action/add_MEMBER</para>
                    /// </summary>
                    [NameInMap("actionArn")]
                    [Validation(Required=false)]
                    public string ActionArn { get; set; }

                    /// <summary>
                    /// <para>权限名称。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>add</para>
                    /// </summary>
                    [NameInMap("actionName")]
                    [Validation(Required=false)]
                    public string ActionName { get; set; }

                    /// <summary>
                    /// <para>action 依赖列表。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;view&quot;]</para>
                    /// </summary>
                    [NameInMap("dependencies")]
                    [Validation(Required=false)]
                    public List<string> Dependencies { get; set; }

                    /// <summary>
                    /// <para>action 描述。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>add members</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>权限展示名称。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>add members</para>
                    /// </summary>
                    [NameInMap("displayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                }

                /// <summary>
                /// <para>创建时间。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1753412502000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>描述。</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataScience</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>角色 arn。</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:emr::w-1234****abcd:role/DataScience</para>
                /// </summary>
                [NameInMap("roleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// <para>角色名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataScience</para>
                /// </summary>
                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

            /// <summary>
            /// <para>用户名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>jia<em><b>test@195</b></em>**7311.onaliyun.com</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>用户类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>MEMBER</para>
            /// </summary>
            [NameInMap("userType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("visible")]
            [Validation(Required=false)]
            public bool? Visible { get; set; }

        }

        /// <summary>
        /// <para>下一页TOKEN。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>记录总数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
