// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class PreviewDocumentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public PreviewDocumentResponseBodyData Data { get; set; }
        public class PreviewDocumentResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("previewType")]
            [Validation(Required=false)]
            public string PreviewType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("uploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://agi.alicdn.com/user/d0o/d3c1f50d-a6c2-49b3-b0c8-3e613c3f20ee_16872_3236784461.png">https://agi.alicdn.com/user/d0o/d3c1f50d-a6c2-49b3-b0c8-3e613c3f20ee_16872_3236784461.png</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ff551395-1c8a-4f30-8ffd-ef7e87c70b4c</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
