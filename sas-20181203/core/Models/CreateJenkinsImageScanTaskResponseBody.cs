// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateJenkinsImageScanTaskResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateJenkinsImageScanTaskResponseBodyData Data { get; set; }
        public class CreateJenkinsImageScanTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The quota for image scan.
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public long? ImageScanCapacity { get; set; }

            /// <summary>
            /// The ID of the image repository.
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// The instance ID of the image repository.
            /// </summary>
            [NameInMap("RepoInstanceId")]
            [Validation(Required=false)]
            public string RepoInstanceId { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RepoRegionId")]
            [Validation(Required=false)]
            public string RepoRegionId { get; set; }

            /// <summary>
            /// The ID of the scan task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The UUID of the image asset.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
