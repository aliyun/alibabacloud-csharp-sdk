// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetUnassociatedCustomerResponseBody : TeaModel {
        /// <summary>
        /// <para>Error Code, Candidate Value：</para>
        /// <list type="bullet">
        /// <item><description>200: OK</description></item>
        /// <item><description>1109: System error</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>List of Invitation Information</para>
        /// </summary>
        [NameInMap("InviteInfoList")]
        [Validation(Required=false)]
        public GetUnassociatedCustomerResponseBodyInviteInfoList InviteInfoList { get; set; }
        public class GetUnassociatedCustomerResponseBodyInviteInfoList : TeaModel {
            [NameInMap("InviteInfo")]
            [Validation(Required=false)]
            public List<GetUnassociatedCustomerResponseBodyInviteInfoListInviteInfo> InviteInfo { get; set; }
            public class GetUnassociatedCustomerResponseBodyInviteInfoListInviteInfo : TeaModel {
                /// <summary>
                /// <para>The name of Customer who are to be invited.</para>
                /// 
                /// <b>Example:</b>
                /// <para>My Client</para>
                /// </summary>
                [NameInMap("AccountNickname")]
                [Validation(Required=false)]
                public string AccountNickname { get; set; }

                /// <summary>
                /// <para>The Email of Customer who are to be invited.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:12345@qq.com">12345@qq.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The time of email been sent out.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-10</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Invitation ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>190</para>
                /// </summary>
                [NameInMap("InviteId")]
                [Validation(Required=false)]
                public long? InviteId { get; set; }

                /// <summary>
                /// <para>Invitation Status:</para>
                /// <list type="bullet">
                /// <item><description>0 No visit on registration URL</description></item>
                /// <item><description>1 Successful Registration</description></item>
                /// <item><description>2 Unsuccessful Registration</description></item>
                /// <item><description>3 Registration URL have been visited, but no submitted sheet/ticket.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <para>Message information</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Pagination Information</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetUnassociatedCustomerResponseBodyPageInfo PageInfo { get; set; }
        public class GetUnassociatedCustomerResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>Pagination, current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>Pagination, record number on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Pagination, page volume in total.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>Request ID, Alibaba Cloud will track errors with this.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23309219-4A34-589D-A3E0-9B2A3BFFD24F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
