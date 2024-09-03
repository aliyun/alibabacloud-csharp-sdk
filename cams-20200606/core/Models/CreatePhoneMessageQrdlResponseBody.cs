// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreatePhoneMessageQrdlResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreatePhoneMessageQrdlResponseBodyData Data { get; set; }
        public class CreatePhoneMessageQrdlResponseBodyData : TeaModel {
            [NameInMap("DeepLinkUrl")]
            [Validation(Required=false)]
            public string DeepLinkUrl { get; set; }

            [NameInMap("GenerateQrImage")]
            [Validation(Required=false)]
            public string GenerateQrImage { get; set; }

            /// <summary>
            /// The phone number.
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("PrefilledMessage")]
            [Validation(Required=false)]
            public string PrefilledMessage { get; set; }

            [NameInMap("QrImageUrl")]
            [Validation(Required=false)]
            public string QrImageUrl { get; set; }

            [NameInMap("QrdlCode")]
            [Validation(Required=false)]
            public string QrdlCode { get; set; }

        }

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
