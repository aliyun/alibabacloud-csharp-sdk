// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeNASFileSystemsResponseBody : TeaModel {
        /// <summary>
        /// Details about the NAS file systems.
        /// </summary>
        [NameInMap("FileSystems")]
        [Validation(Required=false)]
        public List<DescribeNASFileSystemsResponseBodyFileSystems> FileSystems { get; set; }
        public class DescribeNASFileSystemsResponseBodyFileSystems : TeaModel {
            /// <summary>
            /// The total capacity of the NAS file system. Unit: GiB.
            /// 
            /// *   The Capacity type has 10 PiB of storage, which is equal to 10,485,760 GiB.
            /// *   The Performance type has 1 PiB of storage, which is equal to 1,048,576 GiB.
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// The time when the NAS file system was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the NAS file system.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The desktop groups that are associated with the NAS file systems that support the UPM feature.
            /// </summary>
            [NameInMap("DesktopGroups")]
            [Validation(Required=false)]
            public List<DescribeNASFileSystemsResponseBodyFileSystemsDesktopGroups> DesktopGroups { get; set; }
            public class DescribeNASFileSystemsResponseBodyFileSystemsDesktopGroups : TeaModel {
                /// <summary>
                /// The ID of the desktop group.
                /// </summary>
                [NameInMap("DesktopGroupId")]
                [Validation(Required=false)]
                public string DesktopGroupId { get; set; }

                /// <summary>
                /// The name of the desktop group.
                /// </summary>
                [NameInMap("DesktopGroupName")]
                [Validation(Required=false)]
                public string DesktopGroupName { get; set; }

            }

            /// <summary>
            /// Indicates whether disk encryption is enabled.
            /// </summary>
            [NameInMap("EncryptionEnabled")]
            [Validation(Required=false)]
            public bool? EncryptionEnabled { get; set; }

            /// <summary>
            /// The ID of the NAS file system.
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// The name of the NAS file system.
            /// </summary>
            [NameInMap("FileSystemName")]
            [Validation(Required=false)]
            public string FileSystemName { get; set; }

            /// <summary>
            /// The status of the NAS file system. The possible values include:
            /// 
            /// *   Pending: The NAS file system is being created.
            /// *   Running: The NAS file system is running.
            /// *   Stopped: The NAS file system is stopped.
            /// *   Deleting: The NAS file system is being deleted.
            /// *   Deleted: The NAS file system is deleted.
            /// *   Invalid: The NAS file system is invalid.
            /// </summary>
            [NameInMap("FileSystemStatus")]
            [Validation(Required=false)]
            public string FileSystemStatus { get; set; }

            /// <summary>
            /// The type of the NAS file system. Valid value: Universal NAS. This value indicates that the NAS file system is a General-purpose one.
            /// </summary>
            [NameInMap("FileSystemType")]
            [Validation(Required=false)]
            public string FileSystemType { get; set; }

            /// <summary>
            /// The used storage of the NAS file system. Unit: byte.
            /// </summary>
            [NameInMap("MeteredSize")]
            [Validation(Required=false)]
            public long? MeteredSize { get; set; }

            /// <summary>
            /// The domain name of the mount target.
            /// </summary>
            [NameInMap("MountTargetDomain")]
            [Validation(Required=false)]
            public string MountTargetDomain { get; set; }

            /// <summary>
            /// The status of the mount target. The possible values include:
            /// 
            /// *   Pending: The mount target is being created.
            /// *   Active: The mount target is enabled.
            /// *   Inactive: The mount target is disabled.
            /// *   Deleting: The mount target is being deleted.
            /// *   Invalid: The mount target is invalid.
            /// </summary>
            [NameInMap("MountTargetStatus")]
            [Validation(Required=false)]
            public string MountTargetStatus { get; set; }

            /// <summary>
            /// The ID of the workspace.
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// The name of the workspace.
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// Indicates whether the User Profile Management (UPM) feature is supported.
            /// </summary>
            [NameInMap("ProfileCompatible")]
            [Validation(Required=false)]
            public bool? ProfileCompatible { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The storage type of the NAS file system. Valid values:
            /// 
            /// *   Capacity
            /// *   Performance
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// Indicates whether the Server Message Block (SMB) access control list (ACL) feature was enabled.
            /// </summary>
            [NameInMap("SupportAcl")]
            [Validation(Required=false)]
            public bool? SupportAcl { get; set; }

            /// <summary>
            /// The ID of the zone where the NAS file system resides.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The token that determines the start point of the next query. This parameter is empty if no additional results exist.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
