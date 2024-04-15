// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RebuildDesktopsResponseBody : TeaModel {
        /// <summary>
        /// The recreation results.
        /// </summary>
        [NameInMap("RebuildResults")]
        [Validation(Required=false)]
        public List<RebuildDesktopsResponseBodyRebuildResults> RebuildResults { get; set; }
        public class RebuildDesktopsResponseBodyRebuildResults : TeaModel {
            /// <summary>
            /// The recreation result code. If the request was successful, `success` is returned. If the request failed, an error message is returned.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The IDs of the cloud computers.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The error message. This parameter is invalid if the value of `Code` is `success`.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
