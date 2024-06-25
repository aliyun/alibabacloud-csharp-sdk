// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsSignListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   Other values indicate that the request failed. For more information, see [Error codes](https://help.aliyun.com/document_detail/101346.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The number of signatures per page. Valid values: **1 to 50**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried message signatures.
        /// </summary>
        [NameInMap("SmsSignList")]
        [Validation(Required=false)]
        public List<QuerySmsSignListResponseBodySmsSignList> SmsSignList { get; set; }
        public class QuerySmsSignListResponseBodySmsSignList : TeaModel {
            /// <summary>
            /// The approval status of the signature. Valid values:
            /// 
            /// *   **AUDIT_STATE_INIT**: The signature is pending approval.
            /// *   **AUDIT_STATE_PASS**: The signature is approved.
            /// *   **AUDIT_STATE_NOT_PASS**: The signature is rejected. You can view the reason in the Reason response parameter.
            /// *   **AUDIT_STATE_CANCEL**: The approval is canceled.
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// The type of the signature scenario. The return value ends with "type". Valid values:
            /// 
            /// *   Verification code type
            /// *   General-purpose type
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// The time when the signature was created. Format: yyyy-MM-dd HH:mm:ss.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// The ticket ID.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// The approval remarks.
            /// 
            /// *   If the value of AuditStatus is **AUDIT_STATE_PASS** or **AUDIT_STATE_INIT**, the value of Reason is No Approval Remarks.
            /// *   If the value of AuditStatus is **AUDIT_STATE_NOT_PASS**, the reason why the signature is rejected is returned.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public QuerySmsSignListResponseBodySmsSignListReason Reason { get; set; }
            public class QuerySmsSignListResponseBodySmsSignListReason : TeaModel {
                /// <summary>
                /// The time when the signature was rejected. Format: yyyy-MM-dd HH:mm:ss.
                /// </summary>
                [NameInMap("RejectDate")]
                [Validation(Required=false)]
                public string RejectDate { get; set; }

                /// <summary>
                /// The reason why the signature was rejected.
                /// </summary>
                [NameInMap("RejectInfo")]
                [Validation(Required=false)]
                public string RejectInfo { get; set; }

                /// <summary>
                /// The remarks about the rejection.
                /// </summary>
                [NameInMap("RejectSubInfo")]
                [Validation(Required=false)]
                public string RejectSubInfo { get; set; }

            }

            /// <summary>
            /// The name of the signature.
            /// </summary>
            [NameInMap("SignName")]
            [Validation(Required=false)]
            public string SignName { get; set; }

        }

        /// <summary>
        /// The total number of signatures.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
