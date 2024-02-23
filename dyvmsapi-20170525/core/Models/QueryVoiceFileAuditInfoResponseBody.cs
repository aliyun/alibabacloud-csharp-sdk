// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVoiceFileAuditInfoResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// The value OK indicates that the request was successful. For more information about other response codes, see [API error codes](~~112502~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryVoiceFileAuditInfoResponseBodyData> Data { get; set; }
        public class QueryVoiceFileAuditInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The review state of the voice file. Valid values:
            /// 
            /// *   **AUDIT_STATE_INIT**: The voice file was under review.
            /// *   **AUDIT_STATE_PASS**: The voice file was approved.
            /// *   **AUDIT_STATE_NOT_PASS**: The voice file was rejected.
            /// *   **AUDIT_STATE_UPLOADING**: The voice file was approved and is being uploaded.
            /// *   **AUDIT_STATE_REDOING**: The voice file was being reprocessed.
            /// *   **AUDIT_SATE_CANCEL**: The review of the voice file was canceled.
            /// *   **AUDIT_PAUSE**: The review of the voice file was suspended.
            /// *   **AUDIT_ORDER_FINISHED**: The voice file was approved by the ticket system and was waiting for the review of the Internet service provider (ISP).
            /// </summary>
            [NameInMap("AuditState")]
            [Validation(Required=false)]
            public string AuditState { get; set; }

            /// <summary>
            /// The reason why the voice file was rejected.
            /// </summary>
            [NameInMap("RejectInfo")]
            [Validation(Required=false)]
            public string RejectInfo { get; set; }

            /// <summary>
            /// The code of the voice file.
            /// </summary>
            [NameInMap("VoiceCode")]
            [Validation(Required=false)]
            public string VoiceCode { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
