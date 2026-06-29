// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListTenantMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. OK indicates a successful request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paginated query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListTenantMembersResponseBodyPageResult PageResult { get; set; }
        public class ListTenantMembersResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The list of users.</para>
            /// </summary>
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<ListTenantMembersResponseBodyPageResultUserList> UserList { get; set; }
            public class ListTenantMembersResponseBodyPageResultUserList : TeaModel {
                /// <summary>
                /// <para>The account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The DingTalk number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dd123123</para>
                /// </summary>
                [NameInMap("DingNumber")]
                [Validation(Required=false)]
                public string DingNumber { get; set; }

                /// <summary>
                /// <para>The display name of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The display name of the user without status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("DisplayNameWithoutStatus")]
                [Validation(Required=false)]
                public string DisplayNameWithoutStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether the IP address whitelist is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableWhiteIp")]
                [Validation(Required=false)]
                public string EnableWhiteIp { get; set; }

                /// <summary>
                /// <para>The time when the user was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1730000000000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the user was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1730000000000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>132321</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@aliyun.com">123@aliyun.com</a></para>
                /// </summary>
                [NameInMap("Mail")]
                [Validation(Required=false)]
                public string Mail { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13888888888</para>
                /// </summary>
                [NameInMap("MobilePhone")]
                [Validation(Required=false)]
                public string MobilePhone { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The nickname of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>susan</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The real name of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("RealName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                /// <summary>
                /// <para>The list of member roles.</para>
                /// </summary>
                [NameInMap("RoleList")]
                [Validation(Required=false)]
                public List<string> RoleList { get; set; }

                /// <summary>
                /// <para>The user source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>213213232422222</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The user source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The list of user groups to which the user belongs.</para>
                /// </summary>
                [NameInMap("UserGroupList")]
                [Validation(Required=false)]
                public List<ListTenantMembersResponseBodyPageResultUserListUserGroupList> UserGroupList { get; set; }
                public class ListTenantMembersResponseBodyPageResultUserListUserGroupList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the user group is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Active")]
                    [Validation(Required=false)]
                    public bool? Active { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The user group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>121313</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the user group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The IP address whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0.0/0</para>
                /// </summary>
                [NameInMap("WhiteIp")]
                [Validation(Required=false)]
                public string WhiteIp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
