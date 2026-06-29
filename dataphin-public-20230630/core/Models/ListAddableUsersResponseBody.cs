// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAddableUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
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
        /// <para>The paging query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListAddableUsersResponseBodyPageResult PageResult { get; set; }
        public class ListAddableUsersResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The list of users.</para>
            /// </summary>
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<ListAddableUsersResponseBodyPageResultUserList> UserList { get; set; }
            public class ListAddableUsersResponseBodyPageResultUserList : TeaModel {
                /// <summary>
                /// <para>The account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@xx.com">123@xx.com</a></para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The DingTalk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123@dingding</para>
                /// </summary>
                [NameInMap("DingNumber")]
                [Validation(Required=false)]
                public string DingNumber { get; set; }

                /// <summary>
                /// <para>The display name of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The display name of the user without the status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("DisplayNameWithoutStatus")]
                [Validation(Required=false)]
                public string DisplayNameWithoutStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether the IP whitelist is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableWhiteIp")]
                [Validation(Required=false)]
                public string EnableWhiteIp { get; set; }

                /// <summary>
                /// <para>The Lark chatbot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("FeiShuRobot")]
                [Validation(Required=false)]
                public string FeiShuRobot { get; set; }

                /// <summary>
                /// <para>The time when the user was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1717343597000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the user was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1717343597000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123231</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@xx.com">123@xx.com</a></para>
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
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The nickname of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The ID of the parent Alibaba Cloud account to which the user belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>231313</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <para>The real name of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("RealName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                /// <summary>
                /// <para>The source ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:123@xx.com">123@xx.com</a></para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The source type of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The WeCom chatbot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("WeChatRobot")]
                [Validation(Required=false)]
                public string WeChatRobot { get; set; }

                /// <summary>
                /// <para>The IP whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
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
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
