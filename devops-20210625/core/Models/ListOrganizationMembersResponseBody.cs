// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListOrganizationMembersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error info</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<ListOrganizationMembersResponseBodyMembers> Members { get; set; }
        public class ListOrganizationMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123456677888</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1631845101798</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public long? Birthday { get; set; }

            [NameInMap("deptLists")]
            [Validation(Required=false)]
            public List<string> DeptLists { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>(敏感字段，暂不返回)</para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1631845101798</para>
            /// </summary>
            [NameInMap("hiredDate")]
            [Validation(Required=false)]
            public long? HiredDate { get; set; }

            [NameInMap("identities")]
            [Validation(Required=false)]
            public ListOrganizationMembersResponseBodyMembersIdentities Identities { get; set; }
            public class ListOrganizationMembersResponseBodyMembersIdentities : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1236666</para>
                /// </summary>
                [NameInMap("externUid")]
                [Validation(Required=false)]
                public string ExternUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Dingtalk</para>
                /// </summary>
                [NameInMap("provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>373***</para>
            /// </summary>
            [NameInMap("jobNumber")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1631845101798</para>
            /// </summary>
            [NameInMap("joinTime")]
            [Validation(Required=false)]
            public long? JoinTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1631845101798</para>
            /// </summary>
            [NameInMap("lastVisitTime")]
            [Validation(Required=false)]
            public long? LastVisitTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>(敏感字段，暂不返回)</para>
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("organizationMemberName")]
            [Validation(Required=false)]
            public string OrganizationMemberName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8fc0c9ff039711dd64acd000</para>
            /// </summary>
            [NameInMap("organizationRoleId")]
            [Validation(Required=false)]
            public string OrganizationRoleId { get; set; }

            [NameInMap("organizationRoleName")]
            [Validation(Required=false)]
            public string OrganizationRoleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FC93CE1A-8D7A-13A9-8306-7465DE2E5C0F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
