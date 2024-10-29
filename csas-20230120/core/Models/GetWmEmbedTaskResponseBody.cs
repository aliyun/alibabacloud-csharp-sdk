// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetWmEmbedTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWmEmbedTaskResponseBodyData Data { get; set; }
        public class GetWmEmbedTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.com/embed-****.pdf">https://example.com/embed-****.pdf</a></para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>171859****</para>
            /// </summary>
            [NameInMap("FileUrlExp")]
            [Validation(Required=false)]
            public string FileUrlExp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>embed-****.pdf</para>
            /// </summary>
            [NameInMap("Filename")]
            [Validation(Required=false)]
            public string Filename { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d41d8cd98f00b204e9800998ecf8****</para>
            /// </summary>
            [NameInMap("OutFileHashMd5")]
            [Validation(Required=false)]
            public string OutFileHashMd5 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123**</para>
            /// </summary>
            [NameInMap("OutFileSize")]
            [Validation(Required=false)]
            public long? OutFileSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job:5GfrJYsoaffmCE7Z5bZtjUxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D6707286-A50E-57B1-B2CF-EFAC59E850D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
