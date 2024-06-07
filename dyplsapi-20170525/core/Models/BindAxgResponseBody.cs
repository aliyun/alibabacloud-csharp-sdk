// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxgResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   Other values indicate that the request failed. For more information, see [Error codes](https://help.aliyun.com/document_detail/109196.html).
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
        /// The information returned after the phone numbers were bound.
        /// </summary>
        [NameInMap("SecretBindDTO")]
        [Validation(Required=false)]
        public BindAxgResponseBodySecretBindDTO SecretBindDTO { get; set; }
        public class BindAxgResponseBodySecretBindDTO : TeaModel {
            /// <summary>
            /// The extension of the phone number.
            /// 
            /// >  The BindAxg operation does not involve an extension. Ignore this parameter.
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// The private number, that is, phone number X.
            /// </summary>
            [NameInMap("SecretNo")]
            [Validation(Required=false)]
            public string SecretNo { get; set; }

            /// <summary>
            /// The binding ID.
            /// </summary>
            [NameInMap("SubsId")]
            [Validation(Required=false)]
            public string SubsId { get; set; }

        }

    }

}
