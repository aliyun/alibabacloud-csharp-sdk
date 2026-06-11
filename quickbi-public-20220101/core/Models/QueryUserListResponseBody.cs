// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The paginated list of users. The <c>Data</c> parameter contains the details of each organization member.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserListResponseBodyResult Result { get; set; }
        public class QueryUserListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The list of users.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryUserListResponseBodyResultData> Data { get; set; }
            public class QueryUserListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud account ID. For users not added through RAM, this ID is available only after they log in.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1355********</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>Indicates whether the user is an organization administrator. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Yes</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: No</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>This parameter is deprecated. Use the <c>RoleIdList</c> parameter instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AdminUser")]
                [Validation(Required=false)]
                public bool? AdminUser { get; set; }

                /// <summary>
                /// <para>Indicates whether the user is a permission administrator. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Yes</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: No</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>This parameter is deprecated. Use the <c>RoleIdList</c> parameter instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AuthAdminUser")]
                [Validation(Required=false)]
                public bool? AuthAdminUser { get; set; }

                [NameInMap("CopilotModules")]
                [Validation(Required=false)]
                public List<string> CopilotModules { get; set; }

                /// <summary>
                /// <para>Indicates whether the user is inactive.</para>
                /// <list type="bullet">
                /// <item><description><para><c>false</c>: Active</para>
                /// </description></item>
                /// <item><description><para><c>true</c>: Inactive</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }

                /// <summary>
                /// <para>The Unix timestamp (in milliseconds) that indicates when the user joined the organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1718691704000</para>
                /// </summary>
                [NameInMap("JoinedDate")]
                [Validation(Required=false)]
                public long? JoinedDate { get; set; }

                /// <summary>
                /// <para>The Unix timestamp (in milliseconds) of the user\&quot;s last login.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1718761320681</para>
                /// </summary>
                [NameInMap("LastLoginTime")]
                [Validation(Required=false)]
                public long? LastLoginTime { get; set; }

                /// <summary>
                /// <para>The nickname of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The IDs of the organization roles assigned to the user.</para>
                /// </summary>
                [NameInMap("RoleIdList")]
                [Validation(Required=false)]
                public List<long?> RoleIdList { get; set; }

                /// <summary>
                /// <para>The user ID in Quick BI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fe67f61a35a94b7da1a34ba174a7****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The user type of the organization member. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>1</c>: developer</para>
                /// </description></item>
                /// <item><description><para><c>2</c>: viewer</para>
                /// </description></item>
                /// <item><description><para><c>3</c>: analyst</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of matching users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
