// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSourceMapInfoResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the SourceMap file.
        /// </summary>
        [NameInMap("SourceMapList")]
        [Validation(Required=false)]
        public List<GetSourceMapInfoResponseBodySourceMapList> SourceMapList { get; set; }
        public class GetSourceMapInfoResponseBodySourceMapList : TeaModel {
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
            /// The size of the file. Unit: KB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// The timestamp that indicates when the file was uploaded.
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

            /// <summary>
            /// The version of the file.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
