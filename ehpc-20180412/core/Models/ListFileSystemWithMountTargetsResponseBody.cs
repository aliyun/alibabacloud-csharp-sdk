// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListFileSystemWithMountTargetsResponseBody : TeaModel {
        /// <summary>
        /// The list of file systems.
        /// </summary>
        [NameInMap("FileSystemList")]
        [Validation(Required=false)]
        public ListFileSystemWithMountTargetsResponseBodyFileSystemList FileSystemList { get; set; }
        public class ListFileSystemWithMountTargetsResponseBodyFileSystemList : TeaModel {
            [NameInMap("FileSystems")]
            [Validation(Required=false)]
            public List<ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystems> FileSystems { get; set; }
            public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystems : TeaModel {
                /// <summary>
                /// The bandwidth of the file system. Unit: MB/s.
                /// </summary>
                [NameInMap("BandWidth")]
                [Validation(Required=false)]
                public int? BandWidth { get; set; }

                /// <summary>
                /// The capacity of the file system. Unit: GiB.
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public int? Capacity { get; set; }

                /// <summary>
                /// The time when the file system was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The description of the file system.
                /// </summary>
                [NameInMap("Destription")]
                [Validation(Required=false)]
                public string Destription { get; set; }

                /// <summary>
                /// Indicates whether the file system is encrypted. Valid values:
                /// 
                /// *   0: The file system is not encrypted.
                /// *   1: The file system is encrypted.
                /// </summary>
                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public int? EncryptType { get; set; }

                /// <summary>
                /// The ID of the file system.
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// The type of the file system. Valid values:
                /// 
                /// *   standard: General-purpose NAS file system
                /// *   extreme: Extreme NAS file system
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// The used capacity of the file system. Unit: bytes.
                /// </summary>
                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public int? MeteredSize { get; set; }

                /// <summary>
                /// The list of mount targets.
                /// </summary>
                [NameInMap("MountTargetList")]
                [Validation(Required=false)]
                public ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsMountTargetList MountTargetList { get; set; }
                public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsMountTargetList : TeaModel {
                    [NameInMap("MountTargets")]
                    [Validation(Required=false)]
                    public List<ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets> MountTargets { get; set; }
                    public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets : TeaModel {
                        /// <summary>
                        /// The name of the permission group that applied to the mount target.
                        /// </summary>
                        [NameInMap("AccessGroup")]
                        [Validation(Required=false)]
                        public string AccessGroup { get; set; }

                        /// <summary>
                        /// The domain name of the mount target.
                        /// </summary>
                        [NameInMap("MountTargetDomain")]
                        [Validation(Required=false)]
                        public string MountTargetDomain { get; set; }

                        /// <summary>
                        /// The network type of the mount target. Valid values:
                        /// 
                        /// *   Vpc: virtual private cloud (VPC)
                        /// *   Classic: the classic network
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// The status of the mount target. Valid values:
                        /// 
                        /// *   Active: The mount target is available.
                        /// *   Inactive: The mount target is inactive.
                        /// *   Pending: The mount target is being created or modified.
                        /// *   Deleting: The mount target is being deleted.
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// The ID of the VPC.
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// The ID of the vSwitch.
                        /// </summary>
                        [NameInMap("VswId")]
                        [Validation(Required=false)]
                        public string VswId { get; set; }

                    }

                }

                /// <summary>
                /// The list of storage plans.
                /// </summary>
                [NameInMap("PackageList")]
                [Validation(Required=false)]
                public ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsPackageList PackageList { get; set; }
                public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsPackageList : TeaModel {
                    [NameInMap("Packages")]
                    [Validation(Required=false)]
                    public List<ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsPackageListPackages> Packages { get; set; }
                    public class ListFileSystemWithMountTargetsResponseBodyFileSystemListFileSystemsPackageListPackages : TeaModel {
                        /// <summary>
                        /// The ID of the storage plan.
                        /// </summary>
                        [NameInMap("PackageId")]
                        [Validation(Required=false)]
                        public string PackageId { get; set; }

                    }

                }

                /// <summary>
                /// The protocol type of the file system. Valid values:
                /// 
                /// - NFS
                /// - SMB
                /// </summary>
                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The status of the file system. Valid values:
                /// 
                /// - Pending: The file system is being created or modified.
                /// - Running: The file system is available.
                /// - Stopped: The file system is stopped.
                /// - Extending: The file system is being scaled out.
                /// - Stopping: The file system is being stopped.
                /// - Deleting: The file system is being deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The storage type of the file system. 
                /// 
                /// - If FileSystemType is set to standard, the StorageType parameter has the following valid values: Capacity and Performance.
                /// - If FileSystemType is set to extreme, the StorageType parameter has the following valid values: standard and advance.
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
