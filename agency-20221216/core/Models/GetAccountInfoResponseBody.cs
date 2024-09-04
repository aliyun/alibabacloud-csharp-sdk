// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetAccountInfoResponseBody : TeaModel {
        /// <summary>
        /// Account Type:
        /// - 1 Agency\\"s End User
        /// - 2 Reseller\\"s End User
        /// - 3 Enterprise
        /// - 4 T2 Agency Partner
        /// - 5 T2 Reseller Partner
        /// - 6 T2 Agency+Reseller Partner
        /// </summary>
        [NameInMap("AccountInfoList")]
        [Validation(Required=false)]
        public GetAccountInfoResponseBodyAccountInfoList AccountInfoList { get; set; }
        public class GetAccountInfoResponseBodyAccountInfoList : TeaModel {
            [NameInMap("AccountInfo")]
            [Validation(Required=false)]
            public List<GetAccountInfoResponseBodyAccountInfoListAccountInfo> AccountInfo { get; set; }
            public class GetAccountInfoResponseBodyAccountInfoListAccountInfo : TeaModel {
                /// <summary>
                /// The E-mail of Distribution Customer.
                /// </summary>
                [NameInMap("AccountNickname")]
                [Validation(Required=false)]
                public string AccountNickname { get; set; }

                /// <summary>
                /// Account CID of Distribution Customer.
                /// </summary>
                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public string AliyunId { get; set; }

                /// <summary>
                /// XXX Technology LTD.
                /// </summary>
                [NameInMap("AssociationSuccessTime")]
                [Validation(Required=false)]
                public string AssociationSuccessTime { get; set; }

                /// <summary>
                /// customer\\"s CID
                /// </summary>
                [NameInMap("Cid")]
                [Validation(Required=false)]
                public long? Cid { get; set; }

                /// <summary>
                /// customer manager
                /// </summary>
                [NameInMap("CustomerBd")]
                [Validation(Required=false)]
                public string CustomerBd { get; set; }

                /// <summary>
                /// The account have Shutdown-delay Privilege, After Shutdown-delay Credit is ran out, Alibaba Cloud will take over resources and keep the instance for 15 days. In addition, the instance will be released if Sub Account failed to pay the bill within these 15 days.
                /// </summary>
                [NameInMap("DelayAmount")]
                [Validation(Required=false)]
                public string DelayAmount { get; set; }

                /// <summary>
                /// Partner\\"s Shutdown Policy Management for Sub Account.
                /// 1: delayStop. The account have Shutdown-delay Privilege, After Shutdown-delay Credit is ran out, Alibaba Cloud will take over resources and keep the instance for 15 days. In addition, the instance will be released if Sub Account failed to pay the bill within these 15 days.
                /// 2: noStop. Partner will manually manage Shutdown Status for Sub Account. Meanwhile, System would not manage the resource\\"s life-circle of Sub Account.
                /// 3: immediatelyStop. Once valid quota of Sub Account falls below 0 and be identified as defaulting account, it will trigger the instance shutdown immediately.
                /// </summary>
                [NameInMap("DelayStatus")]
                [Validation(Required=false)]
                public string DelayStatus { get; set; }

                /// <summary>
                /// Sub Account
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// Account UID of Distribution Customer.
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// Purchase Forbidden：Ban the new purchase action
                /// normal：Normal--End Use can issue Cloud Resource order immediately.
                /// </summary>
                [NameInMap("NewBuyStatus")]
                [Validation(Required=false)]
                public string NewBuyStatus { get; set; }

                /// <summary>
                /// Valid mobile number of Distribution Customer.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The name of Sub Account:
                /// 1.	Use the official name of Company, if Sub Account is an enterprise.
                /// 2.	Use the official name of Partner, if Sub Account is a T2 reseller.
                /// </summary>
                [NameInMap("SubAccountType")]
                [Validation(Required=false)]
                public int? SubAccountType { get; set; }

                /// <summary>
                /// Request ID, the unique request identifier generated by Alibaba Cloud.
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

            }

        }

        /// <summary>
        /// Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// message
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Pagination, page volume in total.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetAccountInfoResponseBodyPageInfo PageInfo { get; set; }
        public class GetAccountInfoResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// Account Information
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// Pagination, current page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// List of Account Information
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// Request id, a unique identifier generated by Alibaba cloud for the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Pagination, record number on each page.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
