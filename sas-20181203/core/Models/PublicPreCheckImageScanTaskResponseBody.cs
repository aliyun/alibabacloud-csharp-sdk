// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicPreCheckImageScanTaskResponseBody : TeaModel {
        /// <summary>
        /// The data returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PublicPreCheckImageScanTaskResponseBodyData Data { get; set; }
        public class PublicPreCheckImageScanTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The number of images to scan in the task.
            /// </summary>
            [NameInMap("NeedAuthCount")]
            [Validation(Required=false)]
            public int? NeedAuthCount { get; set; }

            /// <summary>
            /// The quota for container image scan to be consumed by the task.
            /// </summary>
            [NameInMap("ScanImageCount")]
            [Validation(Required=false)]
            public int? ScanImageCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
