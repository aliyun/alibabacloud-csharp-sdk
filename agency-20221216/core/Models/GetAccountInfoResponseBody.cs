// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetAccountInfoResponseBody : TeaModel {
        /// <summary>
        /// List of Account Information
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
                /// The name of Sub Account:
                /// 1.	Use the official name of Company, if Sub Account is an enterprise.
                /// 2.	Use the official name of Partner, if Sub Account is a T2 reseller.
                /// </summary>
                [NameInMap("AccountNickname")]
                [Validation(Required=false)]
                public string AccountNickname { get; set; }

                /// <summary>
                /// Alibaba Cloud Login name of Distribution Customer.
                /// </summary>
                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public string AliyunId { get; set; }

                /// <summary>
                /// The time that Distribution Customer successfully associated with Distributor.
                /// </summary>
                [NameInMap("AssociationSuccessTime")]
                [Validation(Required=false)]
                public string AssociationSuccessTime { get; set; }

                /// <summary>
                /// Account CID of Distribution Customer.
                /// </summary>
                [NameInMap("Cid")]
                [Validation(Required=false)]
                public long? Cid { get; set; }

                /// <summary>
                /// The E-mail of Distribution Customer.
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// Valid mobile number of Distribution Customer.
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// Description of Distribution Customer.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// Account Type:
                /// - 1 Agency\"s End User
                /// - 2 Reseller\"s End User
                /// - 3 Enterprise
                /// - 4 T2 Agency Partner
                /// - 5 T2 Reseller Partner
                /// - 6 T2 Agency+Reseller Partner
                /// </summary>
                [NameInMap("SubAccountType")]
                [Validation(Required=false)]
                public int? SubAccountType { get; set; }

                /// <summary>
                /// Account UID of Distribution Customer.
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

            }

        }

        /// <summary>
        /// Result Code - Error Code. Value Range:
        /// - 200 OK
        /// - 1109 System Error
        /// - 3029: Invalid UID
        /// - 3062: UID and UserType are both empty.
        /// - 3063: UserType value out of range.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Pagination Information
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetAccountInfoResponseBodyPageInfo PageInfo { get; set; }
        public class GetAccountInfoResponseBodyPageInfo : TeaModel {
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
        /// Request ID, the unique request identifier generated by Alibaba Cloud.
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
