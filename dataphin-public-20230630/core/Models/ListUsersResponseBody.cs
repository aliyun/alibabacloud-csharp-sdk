// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The request error code. OK indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code of the backend response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paged query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListUsersResponseBodyPageResult PageResult { get; set; }
        public class ListUsersResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The user list.</para>
            /// </summary>
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyPageResultUserList> UserList { get; set; }
            public class ListUsersResponseBodyPageResultUserList : TeaModel {
                /// <summary>
                /// <para>The logon name of the original account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-account</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>Indicates whether the user is deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }

                /// <summary>
                /// <para>The department list.</para>
                /// </summary>
                [NameInMap("DeptList")]
                [Validation(Required=false)]
                public List<ListUsersResponseBodyPageResultUserListDeptList> DeptList { get; set; }
                public class ListUsersResponseBodyPageResultUserListDeptList : TeaModel {
                    /// <summary>
                    /// <para>The sub-department list.</para>
                    /// </summary>
                    [NameInMap("Children")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> Children { get; set; }

                    /// <summary>
                    /// <para>The full path of the department.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sample Company/R&amp;D Department</para>
                    /// </summary>
                    [NameInMap("FullName")]
                    [Validation(Required=false)]
                    public string FullName { get; set; }

                    /// <summary>
                    /// <para>The department ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dept-001</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The department name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>R&amp;D Department</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The parent department ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dept-root</para>
                    /// </summary>
                    [NameInMap("ParentId")]
                    [Validation(Required=false)]
                    public string ParentId { get; set; }

                    /// <summary>
                    /// <para>The parent department list.</para>
                    /// </summary>
                    [NameInMap("Parents")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> Parents { get; set; }

                }

                /// <summary>
                /// <para>The DingTalk number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-ding-number</para>
                /// </summary>
                [NameInMap("DingNumber")]
                [Validation(Required=false)]
                public string DingNumber { get; set; }

                /// <summary>
                /// <para>The display name of the original account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample User</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The display name of the original account without the status suffix.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample User</para>
                /// </summary>
                [NameInMap("DisplayNameWithoutStatus")]
                [Validation(Required=false)]
                public string DisplayNameWithoutStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether the IP whitelist is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableWhiteIp")]
                [Validation(Required=false)]
                public bool? EnableWhiteIp { get; set; }

                /// <summary>
                /// <para>The Lark bot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-feishu-robot</para>
                /// </summary>
                [NameInMap("FeiShuRobot")]
                [Validation(Required=false)]
                public string FeiShuRobot { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-02T00:00:00Z</para>
                /// </summary>
                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:user@example.com">user@example.com</a></para>
                /// </summary>
                [NameInMap("Mail")]
                [Validation(Required=false)]
                public string Mail { get; set; }

                /// <summary>
                /// <para>The mobile phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13800000000</para>
                /// </summary>
                [NameInMap("MobilePhone")]
                [Validation(Required=false)]
                public string MobilePhone { get; set; }

                /// <summary>
                /// <para>The user name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-user</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The nickname of the original account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample Nickname</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The user ID of the tenant owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30001011</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <para>The real name of the original account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("RealName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                /// <summary>
                /// <para>The original account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The original account type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The WeCom bot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-wechat-robot</para>
                /// </summary>
                [NameInMap("WeChatRobot")]
                [Validation(Required=false)]
                public string WeChatRobot { get; set; }

                /// <summary>
                /// <para>The IP address whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.2.1</para>
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
        /// <para>72F479F0-EE9F-5511-85C1-3AF3B7668E25</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
