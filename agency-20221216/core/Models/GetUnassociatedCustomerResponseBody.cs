// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetUnassociatedCustomerResponseBody : TeaModel {
        /// <summary>
        /// Error Code, Candidate Value：
        /// * 200: OK
        /// * 1109: System error
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// List of Invitation Information
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
                /// The name of Customer who are to be invited.
                /// </summary>
                [NameInMap("AccountNickname")]
                [Validation(Required=false)]
                public string AccountNickname { get; set; }

                /// <summary>
                /// The Email of Customer who are to be invited.
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// The time of email been sent out.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// Invitation ID
                /// </summary>
                [NameInMap("InviteId")]
                [Validation(Required=false)]
                public long? InviteId { get; set; }

                /// <summary>
                /// Invitation Status:
                /// * 0 No visit on registration URL
                /// * 1 Successful Registration
                /// * 2 Unsuccessful Registration
                /// * 3 Registration URL have been visited, but no submitted sheet/ticket.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// Message information
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Pagination Information
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetUnassociatedCustomerResponseBodyPageInfo PageInfo { get; set; }
        public class GetUnassociatedCustomerResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// Pagination, current page.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// Pagination, record number on each page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// Pagination, page volume in total.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// Request ID, Alibaba Cloud will track errors with this.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
