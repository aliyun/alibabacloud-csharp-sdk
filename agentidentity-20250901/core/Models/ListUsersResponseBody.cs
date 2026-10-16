// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to query the next page of data. An empty value indicates that no more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFVzZXJzOjoyMA==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of users that meet the conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of users.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListUsersResponseBodyUsers> Users { get; set; }
        public class ListUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The creation time. The time is in the ISO 8601 format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample user</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice Wang</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The update time. The time is in the ISO 8601 format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T06:19:17Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_xxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
