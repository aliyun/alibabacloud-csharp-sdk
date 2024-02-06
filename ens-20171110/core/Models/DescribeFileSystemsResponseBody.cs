// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeFileSystemsResponseBody : TeaModel {
        /// <summary>
        /// The information about the file systems.
        /// </summary>
        [NameInMap("FileSystems")]
        [Validation(Required=false)]
        public List<DescribeFileSystemsResponseBodyFileSystems> FileSystems { get; set; }
        public class DescribeFileSystemsResponseBodyFileSystems : TeaModel {
            /// <summary>
            /// The capacity of the file system. Unit: MiB.
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// The time when the file system was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

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
            /// The name of the file system.
            /// </summary>
            [NameInMap("FileSystemName")]
            [Validation(Required=false)]
            public string FileSystemName { get; set; }

            /// <summary>
            /// The storage usage of the file system. The value of this parameter is the maximum storage usage of the file system over the last hour. Unit: bytes.
            /// </summary>
            [NameInMap("MeteredSize")]
            [Validation(Required=false)]
            public long? MeteredSize { get; set; }

            /// <summary>
            /// The information about mount targets.
            /// </summary>
            [NameInMap("MountTargets")]
            [Validation(Required=false)]
            public List<DescribeFileSystemsResponseBodyFileSystemsMountTargets> MountTargets { get; set; }
            public class DescribeFileSystemsResponseBodyFileSystemsMountTargets : TeaModel {
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
                /// The status of the mount target. Valid values:
                /// 
                /// *   active: The mount target is available.
                /// *   inactive: The mount target is unavailable.
                /// *   pending: The task is running.
                /// *   deleting: The mount target is being deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The billing method. PostPaid is returned. PostPaid indicates the pay-as-you-go billing method.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The protocol type of the file system. Valid values:
            /// 
            /// *   NFS: Network File System (NFS)
            /// *   SMB: Server Message Block (SMB)
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The status of the file system. Valid values:
            /// 
            /// *   pending: The file system is being created or modified.
            /// *   running: The file system is available. Before you create a mount target for the file system, make sure that the file system is in the running state.
            /// *   stopped: The file system is unavailable.
            /// *   extending: The file system is being scaled out.
            /// *   stopping: The file system is being disabled.
            /// *   deleting: The file system is being deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The storage type. Valid values:
            /// 
            /// *   capacity: Capacity NAS file systems
            /// *   performance: Performance NAS file systems
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
