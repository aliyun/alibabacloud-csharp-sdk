// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFileSystemsResponseBody : TeaModel {
        /// <summary>
        /// The queried file systems.
        /// </summary>
        [NameInMap("FileSystems")]
        [Validation(Required=false)]
        public DescribeFileSystemsResponseBodyFileSystems FileSystems { get; set; }
        public class DescribeFileSystemsResponseBodyFileSystems : TeaModel {
            [NameInMap("FileSystem")]
            [Validation(Required=false)]
            public List<DescribeFileSystemsResponseBodyFileSystemsFileSystem> FileSystem { get; set; }
            public class DescribeFileSystemsResponseBodyFileSystemsFileSystem : TeaModel {
                /// <summary>
                /// Number of access points.
                /// </summary>
                [NameInMap("AccessPointCount")]
                [Validation(Required=false)]
                public string AccessPointCount { get; set; }

                /// <summary>
                /// The bandwidth of the file system.
                /// 
                /// Unit: MB/s. This parameter is unavailable for General-purpose NAS file systems.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// The capacity of the file system.
                /// 
                /// Unit: GiB.
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                /// <summary>
                /// The billing method.
                /// 
                /// Valid values:
                /// - Subscription: The subscription billing method is used.
                /// - PayAsYouGo: The pay-as-you-go billing method is used.
                /// - Package: A storage plan is attached to the file system.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The time when the file system was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The description of the file system.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The encryption type.
                /// 
                /// Valid values:
                /// 
                /// *   0: The data in the file system is not encrypted.
                /// *   1: A NAS-managed key is used to encrypt the data in the file system.
                /// *   2: A KMS-managed key is used to encrypt the data in the file system.
                /// </summary>
                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public int? EncryptType { get; set; }

                /// <summary>
                /// The time when the file system expires.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The ID of the file system.
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// The type of the file system.
                /// 
                /// Valid values:
                /// - standard: General-purpose NAS file system
                /// - extreme: Extreme NAS file system
                /// - cpfs: CPFS file system
                /// > CPFS file systems are available only on the China site (aliyun.com).
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// The ID of the key that is managed by Key Management Service (KMS).
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// The Lightweight Directory Access Protocol (LDAP) configurations.
                /// 
                /// This parameter is available only for CPFS file systems.
                /// </summary>
                [NameInMap("Ldap")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemLdap Ldap { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemLdap : TeaModel {
                    /// <summary>
                    /// An LDAP entry.
                    /// </summary>
                    [NameInMap("BindDN")]
                    [Validation(Required=false)]
                    public string BindDN { get; set; }

                    /// <summary>
                    /// An LDAP search base.
                    /// </summary>
                    [NameInMap("SearchBase")]
                    [Validation(Required=false)]
                    public string SearchBase { get; set; }

                    /// <summary>
                    /// An LDAP URI.
                    /// </summary>
                    [NameInMap("URI")]
                    [Validation(Required=false)]
                    public string URI { get; set; }

                }

                /// <summary>
                /// Archive storage usage.
                /// 
                /// Unit: Byte.
                /// </summary>
                [NameInMap("MeteredArchiveSize")]
                [Validation(Required=false)]
                public long? MeteredArchiveSize { get; set; }

                /// <summary>
                /// The storage usage of the Infrequent Access (IA) storage medium.
                /// 
                /// Unit: bytes.
                /// </summary>
                [NameInMap("MeteredIASize")]
                [Validation(Required=false)]
                public long? MeteredIASize { get; set; }

                /// <summary>
                /// The storage usage of the file system.
                /// 
                /// The value of this parameter is the maximum storage usage of the file system over the last hour. Unit: bytes.
                /// </summary>
                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public long? MeteredSize { get; set; }

                /// <summary>
                /// The information about mount targets.
                /// </summary>
                [NameInMap("MountTargets")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargets MountTargets { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargets : TeaModel {
                    [NameInMap("MountTarget")]
                    [Validation(Required=false)]
                    public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTarget> MountTarget { get; set; }
                    public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTarget : TeaModel {
                        /// <summary>
                        /// The name of the permission group that is attached to the mount target.
                        /// </summary>
                        [NameInMap("AccessGroupName")]
                        [Validation(Required=false)]
                        public string AccessGroupName { get; set; }

                        /// <summary>
                        /// The information about client management nodes.
                        /// 
                        /// This parameter is available only for CPFS file systems.
                        /// </summary>
                        [NameInMap("ClientMasterNodes")]
                        [Validation(Required=false)]
                        public DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetClientMasterNodes ClientMasterNodes { get; set; }
                        public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetClientMasterNodes : TeaModel {
                            [NameInMap("ClientMasterNode")]
                            [Validation(Required=false)]
                            public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetClientMasterNodesClientMasterNode> ClientMasterNode { get; set; }
                            public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetClientMasterNodesClientMasterNode : TeaModel {
                                /// <summary>
                                /// The default logon password of the ECS instance on the client management node.
                                /// </summary>
                                [NameInMap("DefaultPasswd")]
                                [Validation(Required=false)]
                                public string DefaultPasswd { get; set; }

                                /// <summary>
                                /// The ID of the ECS instance on the client management node.
                                /// </summary>
                                [NameInMap("EcsId")]
                                [Validation(Required=false)]
                                public string EcsId { get; set; }

                                /// <summary>
                                /// The IP address of the ECS instance on the client management node.
                                /// </summary>
                                [NameInMap("EcsIp")]
                                [Validation(Required=false)]
                                public string EcsIp { get; set; }

                            }

                        }

                        /// <summary>
                        /// The dual-stack (IPv4 and IPv6) domain name of the mount target.
                        /// > Only Extreme NAS file systems that reside in the Chinese mainland support IPv6.
                        /// </summary>
                        [NameInMap("DualStackMountTargetDomain")]
                        [Validation(Required=false)]
                        public string DualStackMountTargetDomain { get; set; }

                        /// <summary>
                        /// The domain name of the mount target.
                        /// </summary>
                        [NameInMap("MountTargetDomain")]
                        [Validation(Required=false)]
                        public string MountTargetDomain { get; set; }

                        /// <summary>
                        /// The network type. Valid value: vpc.
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// The status of the mount target.
                        /// 
                        /// Valid values:
                        /// 
                        /// *   Active: The mount target is available.
                        /// *   Inactive: The mount target is unavailable.
                        /// *   Pending: The mount target is being processed.
                        /// *   Deleting: The mount target is being deleted.
                        /// *   Hibernating: The mount target is being hibernated.
                        /// *   Hibernated: The mount target is hibernated.
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// The tags that are attached to the mount target.
                        /// </summary>
                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetTags Tags { get; set; }
                        public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetTags : TeaModel {
                            [NameInMap("Tag")]
                            [Validation(Required=false)]
                            public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetTagsTag> Tag { get; set; }
                            public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetTagsTag : TeaModel {
                                /// <summary>
                                /// The tag key.
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// The tag value.
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

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
                /// The options.
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemOptions Options { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemOptions : TeaModel {
                    /// <summary>
                    /// Specifies whether to enable the oplock feature. Valid values:
                    /// 
                    /// *   true: enables the feature.
                    /// *   false: disables the feature.
                    /// 
                    /// >  Only Server Message Block (SMB) file systems support this feature.
                    /// </summary>
                    [NameInMap("EnableOplock")]
                    [Validation(Required=false)]
                    public bool? EnableOplock { get; set; }

                }

                /// <summary>
                /// The information about storage plans.
                /// </summary>
                [NameInMap("Packages")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemPackages Packages { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemPackages : TeaModel {
                    [NameInMap("Package")]
                    [Validation(Required=false)]
                    public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemPackagesPackage> Package { get; set; }
                    public class DescribeFileSystemsResponseBodyFileSystemsFileSystemPackagesPackage : TeaModel {
                        /// <summary>
                        /// The end time of the validity period for the storage plan.
                        /// </summary>
                        [NameInMap("ExpiredTime")]
                        [Validation(Required=false)]
                        public string ExpiredTime { get; set; }

                        /// <summary>
                        /// The ID of the storage plan.
                        /// </summary>
                        [NameInMap("PackageId")]
                        [Validation(Required=false)]
                        public string PackageId { get; set; }

                        /// <summary>
                        /// The type of the storage plan.
                        /// 
                        /// Valid values:
                        /// - ssd: the storage plan for Performance NAS file systems.
                        /// - hybrid: the storage plan for Capacity NAS file systems.
                        /// </summary>
                        [NameInMap("PackageType")]
                        [Validation(Required=false)]
                        public string PackageType { get; set; }

                        /// <summary>
                        /// The capacity of the storage plan. Unit: bytes.
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public long? Size { get; set; }

                        /// <summary>
                        /// The start time of the validity period for the storage plan.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// The protocol type of the file system.
                /// 
                /// Valid values:
                /// 
                /// *   NFS: Network File System (NFS)
                /// *   SMB: Server Message Block (SMB)
                /// *   cpfs: the protocol type supported by the CPFS file system
                /// 
                /// > CPFS file systems are available only on the China site (aliyun.com).
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
                /// The resource group ID.
                /// 
                /// You can log on to the [Resource Management console](https://resourcemanager.console.aliyun.com/resource-groups?) to view resource group IDs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The status of the file system. Valid values:
                /// - Pending: The file system is being created or modified.
                /// - Running: The file system is available. Before you create a mount target for the file system, make sure that the file system is in the Running state.
                /// - Stopped: The file system is unavailable.
                /// - Extending: The file system is being scaled up.
                /// - Stopping: The file system is being stopped.
                /// - Deleting: The file system is being deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The storage type.
                /// 
                /// Valid values:
                /// - Valid values for General-purpose NAS file systems: Capacity,Premium and Performance.
                /// - Valid values for Extreme NAS file systems: standard and advance.
                /// - Valid values for CPFS file systems: advance_100 (100 MB/s/TiB baseline) and advance_200 (200 MB/s/TiB baseline).
                ///  > CPFS file systems are available only on the China site (aliyun.com).
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// The features that are supported by the file system.
                /// </summary>
                [NameInMap("SupportedFeatures")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemSupportedFeatures SupportedFeatures { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemSupportedFeatures : TeaModel {
                    [NameInMap("SupportedFeature")]
                    [Validation(Required=false)]
                    public List<string> SupportedFeature { get; set; }

                }

                /// <summary>
                /// The tags that are attached to the file system.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemTags Tags { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemTagsTag> Tag { get; set; }
                    public class DescribeFileSystemsResponseBodyFileSystemsFileSystemTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The version number of the file system.
                /// 
                /// This parameter is available only for Extreme NAS file systems and CPFS file systems.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// The ID of the zone where the file system resides.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of file systems.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
