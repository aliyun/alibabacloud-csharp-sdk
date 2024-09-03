// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListPhoneMessageQrdlResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListPhoneMessageQrdlResponseBodyData> Data { get; set; }
        public class ListPhoneMessageQrdlResponseBodyData : TeaModel {
            /// <summary>
            /// The URL of the deep link.
            /// </summary>
            [NameInMap("DeepLinkUrl")]
            [Validation(Required=false)]
            public string DeepLinkUrl { get; set; }

            /// <summary>
            /// The format of the generated image.
            /// </summary>
            [NameInMap("GenerateQrImage")]
            [Validation(Required=false)]
            public string GenerateQrImage { get; set; }

            /// <summary>
            /// The phone number.
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// The message content.
            /// </summary>
            [NameInMap("PrefilledMessage")]
            [Validation(Required=false)]
            public string PrefilledMessage { get; set; }

            /// <summary>
            /// The URL of the QR code.
            /// </summary>
            [NameInMap("QrImageUrl")]
            [Validation(Required=false)]
            public string QrImageUrl { get; set; }

            /// <summary>
            /// The mode of the quick-response (QR) code.
            /// </summary>
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
