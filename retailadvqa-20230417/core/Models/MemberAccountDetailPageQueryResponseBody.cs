// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailadvqa20230417.Models
{
    public class MemberAccountDetailPageQueryResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<MemberAccountDetailPageQueryResponseBodyData> Data { get; set; }
        public class MemberAccountDetailPageQueryResponseBodyData : TeaModel {
            [NameInMap("AccountBalance")]
            [Validation(Required=false)]
            public string AccountBalance { get; set; }

            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public int? AccountType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ActivityType")]
            [Validation(Required=false)]
            public string ActivityType { get; set; }

            [NameInMap("ChannelCode")]
            [Validation(Required=false)]
            public string ChannelCode { get; set; }

            [NameInMap("DetailValue")]
            [Validation(Required=false)]
            public string DetailValue { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("OpenMerchantId")]
            [Validation(Required=false)]
            public string OpenMerchantId { get; set; }

            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            [NameInMap("OuterMemberId")]
            [Validation(Required=false)]
            public string OuterMemberId { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
