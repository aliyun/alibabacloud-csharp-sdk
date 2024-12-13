// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the queried entries are truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <remarks>
        /// <para> This parameter is returned only when the <c>IsTruncated</c> parameter is <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>734D9AAC-9A8E-5DF6-A633-ADE70FF2A9B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

        /// <summary>
        /// <para>The users.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListUsersResponseBodyUsers> Users { get; set; }
        public class ListUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The time when the user was created. The value is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-30T09:20:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a user.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliceLee</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The email address of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:AliceLee@example.onmicrosoft.com">AliceLee@example.onmicrosoft.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The identifier information about the user synchronized from an external IdP.</para>
            /// </summary>
            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public ListUsersResponseBodyUsersExternalId ExternalId { get; set; }
            public class ListUsersResponseBodyUsersExternalId : TeaModel {
                /// <summary>
                /// <para>The identifier of the user that is synchronized from an external IdP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c73******a5fdd5</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The method for external identity synchronization. Only System for Cross-domain Identity Management (SCIM) synchronization is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SCIM</para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

            }

            /// <summary>
            /// <para>The first name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("FirstName")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            /// <summary>
            /// <para>The last name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Lee</para>
            /// </summary>
            [NameInMap("LastName")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            /// <summary>
            /// <para>The type of the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manual: The user is manually created.</description></item>
            /// <item><description>Synchronized: The user is synchronized from an external IdP.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Synchronized</para>
            /// </summary>
            [NameInMap("ProvisionType")]
            [Validation(Required=false)]
            public string ProvisionType { get; set; }

            /// <summary>
            /// <para>The status of the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: The logon of the user is enabled.</description></item>
            /// <item><description>Disabled: The logon of the user is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the information about the user was modified. The value is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-30T09:20:08Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u-00bikzkuzbb58luh****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:AliceLee@example.onmicrosoft.com">AliceLee@example.onmicrosoft.com</a></para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
