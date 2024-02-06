// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeMountTargetsResponseBody : TeaModel {
        /// <summary>
        /// The information about mount targets.
        /// </summary>
        [NameInMap("MountTargets")]
        [Validation(Required=false)]
        public List<DescribeMountTargetsResponseBodyMountTargets> MountTargets { get; set; }
        public class DescribeMountTargetsResponseBodyMountTargets : TeaModel {
            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// The ID of the file system.
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// The path of the mount target.
            /// </summary>
            [NameInMap("MountTargetDomain")]
            [Validation(Required=false)]
            public string MountTargetDomain { get; set; }

            /// <summary>
            /// The name of the mount target.
            /// </summary>
            [NameInMap("MountTargetName")]
            [Validation(Required=false)]
            public string MountTargetName { get; set; }

            /// <summary>
            /// The ID of the network.
            /// </summary>
            [NameInMap("NetWorkId")]
            [Validation(Required=false)]
            public string NetWorkId { get; set; }

            /// <summary>
            /// The state of the mount target. Valid values:
            /// 
            /// *   active: The mount target is available.
            /// *   inactive: The mount target is unavailable.
            /// *   pending: A task is being queued for the mount target.
            /// *   deleting: The mount target is being deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of mount targets.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
