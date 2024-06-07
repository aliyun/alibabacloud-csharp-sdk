// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySubscriptionDetailResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   Other status codes indicate that the request failed. For more information, see [Error codes](https://help.aliyun.com/document_detail/109196.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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

        /// <summary>
        /// The information returned after the QuerySubscriptionDetail operation was called.
        /// </summary>
        [NameInMap("SecretBindDetailDTO")]
        [Validation(Required=false)]
        public QuerySubscriptionDetailResponseBodySecretBindDetailDTO SecretBindDetailDTO { get; set; }
        public class QuerySubscriptionDetailResponseBodySecretBindDetailDTO : TeaModel {
            /// <summary>
            /// The ID of the ASR model.
            /// </summary>
            [NameInMap("ASRModelId")]
            [Validation(Required=false)]
            public string ASRModelId { get; set; }

            /// <summary>
            /// Indicates whether automatic speech recognition (ASR) is enabled. Valid values:
            /// 
            /// *   **false**: ASR is disabled.
            /// *   **true**: ASR is enabled.
            /// </summary>
            [NameInMap("ASRStatus")]
            [Validation(Required=false)]
            public bool? ASRStatus { get; set; }

            /// <summary>
            /// The status of one-way call restrictions. No value is returned for this parameter if one-way call restrictions are not set. Valid values:
            /// 
            /// *   **CONTROL_AX_DISABLE**: Phone number A cannot be used to call phone number X.
            /// *   **CONTROL_BX_DISABLE**: Phone number B cannot be used to call phone number X.
            /// </summary>
            [NameInMap("CallRestrict")]
            [Validation(Required=false)]
            public string CallRestrict { get; set; }

            /// <summary>
            /// The expiration time of the binding.
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// The extension in the AXG extension binding.
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// The creation time of the binding.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The ID of number group G in the binding.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// Indicates whether all calls made by the bound phone numbers are recorded. Valid values:
            /// 
            /// *   **false**
            /// *   **true**
            /// </summary>
            [NameInMap("NeedRecord")]
            [Validation(Required=false)]
            public bool? NeedRecord { get; set; }

            /// <summary>
            /// Phone number A in the binding.
            /// </summary>
            [NameInMap("PhoneNoA")]
            [Validation(Required=false)]
            public string PhoneNoA { get; set; }

            /// <summary>
            /// Phone number B in the binding.
            /// </summary>
            [NameInMap("PhoneNoB")]
            [Validation(Required=false)]
            public string PhoneNoB { get; set; }

            /// <summary>
            /// The private number in the binding, that is, phone number X.
            /// </summary>
            [NameInMap("PhoneNoX")]
            [Validation(Required=false)]
            public string PhoneNoX { get; set; }

            /// <summary>
            /// The binding status. Valid values:
            /// 
            /// *   **0**: The binding expired.
            /// *   **1**: The binding is in effect.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// The binding ID.
            /// </summary>
            [NameInMap("SubsId")]
            [Validation(Required=false)]
            public string SubsId { get; set; }

        }

    }

}
