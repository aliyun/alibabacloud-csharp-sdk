// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListOfficeSiteUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token for the next query. An empty value indicates that no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>269BDB16-2CD8-4865-84BD-11C40BC21DB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of AD account usernames. If the enterprise AD contains only the Administrator and Guest users and no other users, an empty Users array is returned.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListOfficeSiteUsersResponseBodyUsers> Users { get; set; }
        public class ListOfficeSiteUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The number of assigned cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AssignedDesktopNumber")]
            [Validation(Required=false)]
            public int? AssignedDesktopNumber { get; set; }

            /// <summary>
            /// <para>The display name of the AD account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aduser</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The new display name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("DisplayNameNew")]
            [Validation(Required=false)]
            public string DisplayNameNew { get; set; }

            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:user@example.com">user@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The username of the AD account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aduser</para>
            /// </summary>
            [NameInMap("EndUser")]
            [Validation(Required=false)]
            public string EndUser { get; set; }

            /// <summary>
            /// <para>The mobile phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130********</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The user principal name (UPN).</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
            /// </summary>
            [NameInMap("UserPrincipalName")]
            [Validation(Required=false)]
            public string UserPrincipalName { get; set; }

        }

    }

}
