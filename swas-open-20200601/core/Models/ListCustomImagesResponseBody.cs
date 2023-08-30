// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListCustomImagesResponseBody : TeaModel {
        /// <summary>
        /// The queried custom images.
        /// </summary>
        [NameInMap("CustomImages")]
        [Validation(Required=false)]
        public List<ListCustomImagesResponseBodyCustomImages> CustomImages { get; set; }
        public class ListCustomImagesResponseBodyCustomImages : TeaModel {
            /// <summary>
            /// The time when the snapshot was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The ID of the data disk snapshot.
            /// </summary>
            [NameInMap("DataSnapshotId")]
            [Validation(Required=false)]
            public string DataSnapshotId { get; set; }

            /// <summary>
            /// The name of the data disk snapshot.
            /// </summary>
            [NameInMap("DataSnapshotName")]
            [Validation(Required=false)]
            public string DataSnapshotName { get; set; }

            /// <summary>
            /// The description of the custom image.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the custom image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// Indicates whether the custom image is shared with Elastic Compute Service (ECS).
            /// </summary>
            [NameInMap("InShare")]
            [Validation(Required=false)]
            public bool? InShare { get; set; }

            /// <summary>
            /// The ID of the simple application server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the simple application server.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The name of the custom image.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The region ID of the custom images.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The status of the custom image.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the system disk snapshot.
            /// </summary>
            [NameInMap("SystemSnapshotId")]
            [Validation(Required=false)]
            public string SystemSnapshotId { get; set; }

            /// <summary>
            /// The name of the system disk snapshot.
            /// </summary>
            [NameInMap("SystemSnapshotName")]
            [Validation(Required=false)]
            public string SystemSnapshotName { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
