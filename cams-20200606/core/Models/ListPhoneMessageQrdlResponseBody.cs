// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListPhoneMessageQrdlResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>If OK is returned, the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListPhoneMessageQrdlResponseBodyData> Data { get; set; }
        public class ListPhoneMessageQrdlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The URL of the deep link.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://wa.msg/">https://wa.msg/</a></para>
            /// </summary>
            [NameInMap("DeepLinkUrl")]
            [Validation(Required=false)]
            public string DeepLinkUrl { get; set; }

            /// <summary>
            /// <para>The format of the generated image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PNG</para>
            /// </summary>
            [NameInMap("GenerateQrImage")]
            [Validation(Required=false)]
            public string GenerateQrImage { get; set; }

            /// <summary>
            /// <para>The phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8613800</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The message content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello</para>
            /// </summary>
            [NameInMap("PrefilledMessage")]
            [Validation(Required=false)]
            public string PrefilledMessage { get; set; }

            /// <summary>
            /// <para>The URL of the QR code.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://img.png">https://img.png</a></para>
            /// </summary>
            [NameInMap("QrImageUrl")]
            [Validation(Required=false)]
            public string QrImageUrl { get; set; }

            /// <summary>
            /// <para>The mode of the quick-response (QR) code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IUIED999</para>
            /// </summary>
            [NameInMap("QrdlCode")]
            [Validation(Required=false)]
            public string QrdlCode { get; set; }

        }

        /// <summary>
        /// <para>Error description information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
