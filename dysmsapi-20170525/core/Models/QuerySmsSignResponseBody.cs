// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsSignResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   If OK is returned, the request is successful.
        /// *   Other values indicate that the request fails. For more information, see [Error codes](https://help.aliyun.com/document_detail/101346.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The date and time when the signature was created.
        /// </summary>
        [NameInMap("CreateDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The remarks of the review. Valid values:
        /// 
        /// *   If the signature is in the **Approved** or **Pending Approval** state, No Remarks is returned.
        /// *   If the signature is in the **Not Approved** state, the reason why the signature is rejected is returned.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The signature.
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// The status of the signature. Valid values:
        /// 
        /// *   **0**: The signature is pending approval.
        /// *   **1**: The signature is approved.
        /// *   **2**: The signature is rejected. The Reason parameter indicates the reason why the signature is rejected.
        /// *   **10**: The signature is cancelled.
        /// </summary>
        [NameInMap("SignStatus")]
        [Validation(Required=false)]
        public int? SignStatus { get; set; }

    }

}
