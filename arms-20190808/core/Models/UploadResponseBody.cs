// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UploadResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5EC8221-08F2-4C95-9AF1-49FD998C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("UploadResult")]
        [Validation(Required=false)]
        public UploadResponseBodyUploadResult UploadResult { get; set; }
        public class UploadResponseBodyUploadResult : TeaModel {
            /// <summary>
            /// <para>The ID of the SourceMap file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Fid")]
            [Validation(Required=false)]
            public string Fid { get; set; }

            /// <summary>
            /// <para>The name of the SourceMap file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.js.map</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The time when the file was uploaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650272251</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

        }

    }

}
