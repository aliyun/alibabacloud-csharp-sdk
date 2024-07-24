// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumUploadFilesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The queried files.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetRumUploadFilesResponseBodyData> Data { get; set; }
        public class GetRumUploadFilesResponseBodyData : TeaModel {
            /// <summary>
            /// The file name.
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// The time when the file was last modified. The value is a timestamp.
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public object LastModifiedTime { get; set; }

            /// <summary>
            /// The size of the file. Unit: bytes.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// The file ID.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The version number of the file.
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
