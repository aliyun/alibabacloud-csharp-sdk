// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of workspace members.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<ListMembersResponseBodyMembers> Members { get; set; }
        public class ListMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// <para>Account name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testAccount</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>Account type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: Alibaba Cloud account</para>
            /// </description></item>
            /// <item><description><para>5: RAM user</para>
            /// </description></item>
            /// <item><description><para>6: RAM role</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>Display name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myDisplayName</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Time when the member was added, in UTC. Format: ISO 8601.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-21T17:12:35.232Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>Member ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14588*****51688039</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// <para>Username of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("MemberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            /// <summary>
            /// <para>Roles assigned to the member.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// <para>Alibaba Cloud account ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>215139******88039</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of members that match the filter criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
