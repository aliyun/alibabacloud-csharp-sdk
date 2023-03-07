// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryFinancialAccountInfoResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFinancialAccountInfoResponseBodyData Data { get; set; }
        public class QueryFinancialAccountInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the financial account. A value of MASTER indicates that the account is a management account. A value of MEMBER indicates that the account is a member.
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// Indicates whether the account is a financial account. A value of true indicates that the account is a financial account. A value of false indicates that the account is not a financial account.
            /// </summary>
            [NameInMap("IsFinancialAccount")]
            [Validation(Required=false)]
            public bool? IsFinancialAccount { get; set; }

            /// <summary>
            /// The ID of the group to which the member belongs.
            /// </summary>
            [NameInMap("MemberGroupId")]
            [Validation(Required=false)]
            public long? MemberGroupId { get; set; }

            /// <summary>
            /// The name of the group to which the member belongs.
            /// </summary>
            [NameInMap("MemberGroupName")]
            [Validation(Required=false)]
            public string MemberGroupName { get; set; }

            /// <summary>
            /// The display name of the member.
            /// </summary>
            [NameInMap("MemberNickName")]
            [Validation(Required=false)]
            public string MemberNickName { get; set; }

            /// <summary>
            /// The username of the account.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
