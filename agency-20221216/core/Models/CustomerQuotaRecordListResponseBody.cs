// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CustomerQuotaRecordListResponseBody : TeaModel {
        /// <summary>
        /// Status code of returning result, 200 means success.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Listed data of returning result
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<CustomerQuotaRecordListResponseBodyData> Data { get; set; }
        public class CustomerQuotaRecordListResponseBodyData : TeaModel {
            /// <summary>
            /// The way to submit the quota adjustment operation. API/ACPN
            /// </summary>
            [NameInMap("OperationSubmitType")]
            [Validation(Required=false)]
            public string OperationSubmitType { get; set; }

            /// <summary>
            /// The time of submit the quota adjustment operation.
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

            /// <summary>
            /// Operation Type Enum</br>
            /// all All types</br>
            /// quota_create Create quota</br>
            /// quota_amount_adjust Adjust the amount of quota</br>
            /// </summary>
            [NameInMap("OperationTypeCode")]
            [Validation(Required=false)]
            public string OperationTypeCode { get; set; }

            /// <summary>
            /// The description of submitted quota adjustment operation.
            /// </summary>
            [NameInMap("OperationTypeDesc")]
            [Validation(Required=false)]
            public string OperationTypeDesc { get; set; }

            /// <summary>
            /// The UID of operator(Partner\\"s UID).
            /// </summary>
            [NameInMap("OperationUid")]
            [Validation(Required=false)]
            public string OperationUid { get; set; }

            /// <summary>
            /// Updated quota amount
            /// </summary>
            [NameInMap("UpdateAfterAmount")]
            [Validation(Required=false)]
            public string UpdateAfterAmount { get; set; }

            /// <summary>
            /// The difference amount between updated quota and original quota.
            /// </summary>
            [NameInMap("UpdateAmount")]
            [Validation(Required=false)]
            public string UpdateAmount { get; set; }

            /// <summary>
            /// Original quota amount
            /// </summary>
            [NameInMap("UpdateBeforeAmount")]
            [Validation(Required=false)]
            public string UpdateBeforeAmount { get; set; }

        }

        /// <summary>
        /// Description of returning data
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// Current page number
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// Record number on each page
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// ID of request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Total volume
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
