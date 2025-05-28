// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The pagination result of the user list is returned. The detailed information list of organization members is stored in the response parameter Data.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserListResponseBodyResult Result { get; set; }
        public class QueryUserListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Returns the list of requested users.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryUserListResponseBodyResultData> Data { get; set; }
            public class QueryUserListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1355********</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The name of the Alibaba Cloud account that corresponds to the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test user</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>Indicates whether the organization administrator. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AdminUser")]
                [Validation(Required=false)]
                public bool? AdminUser { get; set; }

                /// <summary>
                /// <para>Indicate whether the RAM user is a permission administrator. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AuthAdminUser")]
                [Validation(Required=false)]
                public bool? AuthAdminUser { get; set; }

                /// <summary>
                /// <para>User status: </para>
                /// <list type="bullet">
                /// <item><description>Active - false </description></item>
                /// <item><description>Inactive - true</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }

                /// <summary>
                /// <para>Join Date</para>
                /// 
                /// <b>Example:</b>
                /// <para>1718691704000</para>
                /// </summary>
                [NameInMap("JoinedDate")]
                [Validation(Required=false)]
                public long? JoinedDate { get; set; }

                /// <summary>
                /// <para>Last login time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1718761320681</para>
                /// </summary>
                [NameInMap("LastLoginTime")]
                [Validation(Required=false)]
                public long? LastLoginTime { get; set; }

                /// <summary>
                /// <para>The nickname of the organization member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test user</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>List of organization role IDs bound to the user.</para>
                /// </summary>
                [NameInMap("RoleIdList")]
                [Validation(Required=false)]
                public List<long?> RoleIdList { get; set; }

                /// <summary>
                /// <para>The UserID in the Quick BI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fe67f61a35a94b7da1a34ba174a7****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The role type of the organization member. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1 : developer</description></item>
                /// <item><description>2 : visitors</description></item>
                /// <item><description>3 : Analyst</description></item>
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
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of rows per page set when the interface is requested.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of rows in the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>The total number of pages returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
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
