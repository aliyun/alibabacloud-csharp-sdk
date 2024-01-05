// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateOssSubDirectoryResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateOssSubDirectoryResponseBodyData Data { get; set; }
        public class CreateOssSubDirectoryResponseBodyData : TeaModel {
            /// <summary>
            /// The cyclic redundancy check (CRC) value on the client.
            /// </summary>
            [NameInMap("ClientCRC")]
            [Validation(Required=false)]
            public long? ClientCRC { get; set; }

            /// <summary>
            /// The tag of the OSS path.
            /// </summary>
            [NameInMap("ETag")]
            [Validation(Required=false)]
            public string ETag { get; set; }

            /// <summary>
            /// The request ID.
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// The CRC-64 value on the OSS bucket.
            /// </summary>
            [NameInMap("ServerCRC")]
            [Validation(Required=false)]
            public long? ServerCRC { get; set; }

        }

        /// <summary>
        /// The response code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned message.
        /// 
        /// *   If the request was successful, a **success** message is returned.
        /// *   If the request failed, an error message is returned.
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
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
