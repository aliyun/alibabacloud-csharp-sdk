// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCpfsFileSystemsResponseBody : TeaModel {
        /// <summary>
        /// The list of file systems.
        /// </summary>
        [NameInMap("FileSystemList")]
        [Validation(Required=false)]
        public ListCpfsFileSystemsResponseBodyFileSystemList FileSystemList { get; set; }
        public class ListCpfsFileSystemsResponseBodyFileSystemList : TeaModel {
            [NameInMap("FileSystems")]
            [Validation(Required=false)]
            public List<ListCpfsFileSystemsResponseBodyFileSystemListFileSystems> FileSystems { get; set; }
            public class ListCpfsFileSystemsResponseBodyFileSystemListFileSystems : TeaModel {
                /// <summary>
                /// The capacity of the file system. Unit: GiB.
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public string Capacity { get; set; }

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
                /// The ID of the file system.
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// The mount targets.
                /// </summary>
                [NameInMap("MountTargetList")]
                [Validation(Required=false)]
                public ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetList MountTargetList { get; set; }
                public class ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetList : TeaModel {
                    [NameInMap("MountTargets")]
                    [Validation(Required=false)]
                    public List<ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets> MountTargets { get; set; }
                    public class ListCpfsFileSystemsResponseBodyFileSystemListFileSystemsMountTargetListMountTargets : TeaModel {
                        /// <summary>
                        /// The domain where the mount target resides.
                        /// </summary>
                        [NameInMap("MountTargetDomain")]
                        [Validation(Required=false)]
                        public string MountTargetDomain { get; set; }

                        /// <summary>
                        /// The network type.
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// The status of the mount target. Valid values:
                        /// 
                        /// *   Active: The mount target is available.
                        /// *   Inactive: The mount target is unavailable.
                        /// *   Pending: The mount target is being mounted.
                        /// *   Deleting: The mount target is being deleted.
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// The ID of the virtual private cloud (VPC).
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// The vSwitch ID of the instance.
                        /// </summary>
                        [NameInMap("VswId")]
                        [Validation(Required=false)]
                        public string VswId { get; set; }

                    }

                }

                /// <summary>
                /// The protocol type that is applied to the mounted file system. Valid values:
                /// 
                /// *   NFS
                /// *   SMB
                /// </summary>
                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
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
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
