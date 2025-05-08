// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetImageTranslateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetImageTranslateResponseBodyData Data { get; set; }
        public class GetImageTranslateResponseBodyData : TeaModel {
            [NameInMap("Orc")]
            [Validation(Required=false)]
            public string Orc { get; set; }

            [NameInMap("PictureEditor")]
            [Validation(Required=false)]
            public string PictureEditor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://ae01.alicdn.com/kf/xxxxx.jpeg">https://ae01.alicdn.com/kf/xxxxx.jpeg</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A41F6E25-8520-4AF0-90EF-AF7E32840108</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
