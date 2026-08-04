// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetWmEmbedTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the watermark embedding job.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWmEmbedTaskResponseBodyData Data { get; set; }
        public class GetWmEmbedTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The temporary URL of the file embedded with watermark information.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/embed-****.pdf">https://example.com/embed-****.pdf</a></para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <para>Expiration time of FileUrl, formatted as a Unix timestamp with second-level precision.</para>
            /// 
            /// <b>Example:</b>
            /// <para>171859****</para>
            /// </summary>
            [NameInMap("FileUrlExp")]
            [Validation(Required=false)]
            public string FileUrlExp { get; set; }

            /// <summary>
            /// <para>The filename of the file embedded with watermark information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>embed-****.pdf</para>
            /// </summary>
            [NameInMap("Filename")]
            [Validation(Required=false)]
            public string Filename { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the file with embedded watermark information, used for troubleshooting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d41d8cd98f00b204e9800998ecf8****</para>
            /// </summary>
            [NameInMap("OutFileHashMd5")]
            [Validation(Required=false)]
            public string OutFileHashMd5 { get; set; }

            /// <summary>
            /// <para>The size in bytes of the file embedded with watermark information. This is used for troubleshooting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123**</para>
            /// </summary>
            [NameInMap("OutFileSize")]
            [Validation(Required=false)]
            public long? OutFileSize { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job:5GfrJYsoaffmCE7Z5bZtjUxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Task Status. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>Running</b>: The job is running.  </description></item>
            /// <item><description><b>Success</b>: The job succeeded.  </description></item>
            /// <item><description><b>Failed</b>: The job failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6707286-A50E-57B1-B2CF-EFAC59E850D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
