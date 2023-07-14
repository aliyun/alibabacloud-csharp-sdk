// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UploadResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("UploadResult")]
        [Validation(Required=false)]
        public UploadResponseBodyUploadResult UploadResult { get; set; }
        public class UploadResponseBodyUploadResult : TeaModel {
            /// <summary>
            /// The ID of the SourceMap file.
            /// </summary>
            [NameInMap("Fid")]
            [Validation(Required=false)]
            public string Fid { get; set; }

            /// <summary>
            /// The name of the SourceMap file.
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// The time when the file was uploaded.
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

        }

    }

}
