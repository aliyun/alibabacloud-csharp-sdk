// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The list of members.</para>
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<ListMembersResponseBodyMembers> Members { get; set; }
        public class ListMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// <para>The list of operations allowed for this user.</para>
            /// </summary>
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<ListMembersResponseBodyMembersActions> Actions { get; set; }
            public class ListMembersResponseBodyMembersActions : TeaModel {
                /// <summary>
                /// <para>The ARN of the action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:emr::w-1234****abcd:action/add_MEMBER</para>
                /// </summary>
                [NameInMap("actionArn")]
                [Validation(Required=false)]
                public string ActionArn { get; set; }

                /// <summary>
                /// <para>The name of the permission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>add</para>
                /// </summary>
                [NameInMap("actionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// <para>The list of action dependencies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;view&quot;]</para>
                /// </summary>
                [NameInMap("dependencies")]
                [Validation(Required=false)]
                public List<string> Dependencies { get; set; }

                /// <summary>
                /// <para>The description of the action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>add members</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the permission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>add members</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// <para>The time when the member was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1753412502000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The display name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jia***test</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:emr::w-1234*<em><b>abcd:member/202265</b></em>**276</para>
            /// </summary>
            [NameInMap("memberArn")]
            [Validation(Required=false)]
            public string MemberArn { get; set; }

            /// <summary>
            /// <para>The list of roles in the workspace.</para>
            /// </summary>
            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<ListMembersResponseBodyMembersRoles> Roles { get; set; }
            public class ListMembersResponseBodyMembersRoles : TeaModel {
                /// <summary>
                /// <para>The list of permissions.</para>
                /// </summary>
                [NameInMap("actions")]
                [Validation(Required=false)]
                public List<ListMembersResponseBodyMembersRolesActions> Actions { get; set; }
                public class ListMembersResponseBodyMembersRolesActions : TeaModel {
                    /// <summary>
                    /// <para>The ARN of the action.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:emr::w-1234****abcd:action/add_MEMBER</para>
                    /// </summary>
                    [NameInMap("actionArn")]
                    [Validation(Required=false)]
                    public string ActionArn { get; set; }

                    /// <summary>
                    /// <para>The name of the permission.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>add</para>
                    /// </summary>
                    [NameInMap("actionName")]
                    [Validation(Required=false)]
                    public string ActionName { get; set; }

                    /// <summary>
                    /// <para>The list of action dependencies.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;view&quot;]</para>
                    /// </summary>
                    [NameInMap("dependencies")]
                    [Validation(Required=false)]
                    public List<string> Dependencies { get; set; }

                    /// <summary>
                    /// <para>The description of the action.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>add members</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The display name of the permission.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>add members</para>
                    /// </summary>
                    [NameInMap("displayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                }

                /// <summary>
                /// <para>The time when the role was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1753412502000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataScience</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ARN of the role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:emr::w-1234****abcd:role/DataScience</para>
                /// </summary>
                [NameInMap("roleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                /// <summary>
                /// <para>The name of the role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataScience</para>
                /// </summary>
                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jia<em><b>test@195</b></em>**7311.onaliyun.com</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The type of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MEMBER</para>
            /// </summary>
            [NameInMap("userType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

            /// <summary>
            /// <para>Indicates whether the member is visible.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("visible")]
            [Validation(Required=false)]
            public bool? Visible { get; set; }

        }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
