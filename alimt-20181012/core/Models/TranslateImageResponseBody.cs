// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateImageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public TranslateImageResponseBodyData Data { get; set; }
        public class TranslateImageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.com/example.jpg">https://example.com/example.jpg</a></para>
            /// </summary>
            [NameInMap("FinalImageUrl")]
            [Validation(Required=false)]
            public string FinalImageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.com/example.jpg">https://example.com/example.jpg</a></para>
            /// </summary>
            [NameInMap("InPaintingUrl")]
            [Validation(Required=false)]
            public string InPaintingUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Editor Template Json String</para>
            /// </summary>
            [NameInMap("TemplateJson")]
            [Validation(Required=false)]
            public string TemplateJson { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Error Message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D774D33D-F1CB-5A2C-A787-E0A2179239CE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
