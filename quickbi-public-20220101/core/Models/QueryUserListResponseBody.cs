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
        /// <para>The paginated result of the user list. The detailed information of organization members is stored in the Data response parameter.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserListResponseBodyResult Result { get; set; }
        public class QueryUserListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The list of users returned by the request.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryUserListResponseBodyResultData> Data { get; set; }
            public class QueryUserListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud account ID. For users who are not added through RAM self-service reading, the Alibaba Cloud account ID can be obtained only after they log on.</para>
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
                /// <para>Indicates whether the organization administrator role is bound. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Yes.</description></item>
                /// <item><description>false: No.</description></item>
                /// </list>
                /// <para><notice>This parameter is deprecated. Use the RoleIdList parameter instead.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AdminUser")]
                [Validation(Required=false)]
                public bool? AdminUser { get; set; }

                /// <summary>
                /// <para>Indicates whether the permission management administrator role is attached. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Yes.</description></item>
                /// <item><description>false: No.</description></item>
                /// </list>
                /// <para><notice>This parameter is expired and no longer recommended. Use the RoleIdList parameter instead.</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AuthAdminUser")]
                [Validation(Required=false)]
                public bool? AuthAdminUser { get; set; }

                /// <summary>
                /// <para>The intelligent module quota of the user.</para>
                /// <list type="bullet">
                /// <item><description>qreport: Q report</description></item>
                /// <item><description>qExploreNum: Q explore edition</description></item>
                /// <item><description>smartQAskNum: Q data query</description></item>
                /// <item><description>smartQDevNum: Q builder</description></item>
                /// </list>
                /// </summary>
                [NameInMap("CopilotModules")]
                [Validation(Required=false)]
                public List<string> CopilotModules { get; set; }

                /// <summary>
                /// <para>The user status. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>false: activated</description></item>
                /// <item><description>true: deactivated</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }

                /// <summary>
                /// <para>The date when the member joined the organization. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1718691704000</para>
                /// </summary>
                [NameInMap("JoinedDate")]
                [Validation(Required=false)]
                public long? JoinedDate { get; set; }

                /// <summary>
                /// <para>The last logon time. This value is a UNIX timestamp in milliseconds.</para>
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
                /// <para>test</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The list of organization role IDs bound to the user.</para>
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
                /// <item><description>1: developer</description></item>
                /// <item><description>2: visitor</description></item>
                /// <item><description>3: analyst</description></item>
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
            /// <para>The number of rows per page specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of rows.</para>
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
