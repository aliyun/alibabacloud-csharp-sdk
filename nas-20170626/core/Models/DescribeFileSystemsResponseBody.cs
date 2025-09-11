// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFileSystemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The file system list.</para>
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
                /// <para>Number of access points.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AccessPointCount")]
                [Validation(Required=false)]
                public string AccessPointCount { get; set; }

                /// <summary>
                /// <para>The ID of the automatic snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-extreme-233e6****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>The bandwidth of the file system.</para>
                /// <para>Unit: MB/s. This parameter is unavailable for General-purpose NAS file systems.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// <para>The capacity of the file system.</para>
                /// <para>Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                /// <summary>
                /// <para>The billing method.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Subscription</description></item>
                /// <item><description>PayAsYouGo</description></item>
                /// <item><description>Package: storage plan</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayAsYouGo</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The time when the file system was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-05T16:00:00Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the data in the file system is encrypted.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The data in the file system is not encrypted.</description></item>
                /// <item><description>1: A NAS-managed key is used to encrypt the data in the file system.</description></item>
                /// <item><description>2: A KMS-managed key is used to encrypt the data in the file system.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public int? EncryptType { get; set; }

                /// <summary>
                /// <para>The time when the file system expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-05T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The ID of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>109c04****</para>
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// <para>The file system type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard: General-purpose NAS file system.</description></item>
                /// <item><description>extreme: Extreme NAS file system.</description></item>
                /// <item><description>cpfs: CPFS file system.</description></item>
                /// </list>
                /// <remarks>
                /// <para> CPFS file systems are available only on the China site (aliyun.com).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// <para>The ID of the key that is managed by Key Management Service (KMS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The Lightweight Directory Access Protocol (LDAP) configurations.</para>
                /// <para>This parameter is available only for CPFS file systems.</para>
                /// </summary>
                [NameInMap("Ldap")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemLdap Ldap { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemLdap : TeaModel {
                    /// <summary>
                    /// <para>An LDAP entry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn=alibaba,dc=com</para>
                    /// </summary>
                    [NameInMap("BindDN")]
                    [Validation(Required=false)]
                    public string BindDN { get; set; }

                    /// <summary>
                    /// <para>An LDAP search base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dc=example</para>
                    /// </summary>
                    [NameInMap("SearchBase")]
                    [Validation(Required=false)]
                    public string SearchBase { get; set; }

                    /// <summary>
                    /// <para>An LDAP URI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ldap://ldap.example.example</para>
                    /// </summary>
                    [NameInMap("URI")]
                    [Validation(Required=false)]
                    public string URI { get; set; }

                }

                /// <summary>
                /// <para>Archive storage usage.</para>
                /// <para>Unit: Byte.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611661312</para>
                /// </summary>
                [NameInMap("MeteredArchiveSize")]
                [Validation(Required=false)]
                public long? MeteredArchiveSize { get; set; }

                /// <summary>
                /// <para>The storage usage of the Infrequent Access (IA) storage medium.</para>
                /// <para>Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>362832</para>
                /// </summary>
                [NameInMap("MeteredIASize")]
                [Validation(Required=false)]
                public long? MeteredIASize { get; set; }

                /// <summary>
                /// <para>The storage usage of the file system.</para>
                /// <para>The value of this parameter is the maximum storage usage of the file system over the last hour. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611661312</para>
                /// </summary>
                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public long? MeteredSize { get; set; }

                /// <summary>
                /// <para>The queried mount targets.</para>
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
                        /// <para>The name of the permission group that is attached to the mount target.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-001</para>
                        /// </summary>
                        [NameInMap("AccessGroupName")]
                        [Validation(Required=false)]
                        public string AccessGroupName { get; set; }

                        /// <summary>
                        /// <para>The information about client management nodes.</para>
                        /// <para>This parameter is available only for CPFS file systems.</para>
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
                                /// <para>The default logon password of the ECS instance on the client management node.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>123456</para>
                                /// </summary>
                                [NameInMap("DefaultPasswd")]
                                [Validation(Required=false)]
                                public string DefaultPasswd { get; set; }

                                /// <summary>
                                /// <para>The ID of the ECS instance on the client management node.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>i-hp3i3odi5ory1buo****</para>
                                /// </summary>
                                [NameInMap("EcsId")]
                                [Validation(Required=false)]
                                public string EcsId { get; set; }

                                /// <summary>
                                /// <para>The IP address of the ECS instance on the client management node.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>192.168.1.0</para>
                                /// </summary>
                                [NameInMap("EcsIp")]
                                [Validation(Required=false)]
                                public string EcsIp { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The dual-stack (IPv4 and IPv6) domain name of the mount target.</para>
                        /// <remarks>
                        /// <para>Only Extreme NAS file systems that reside in the Chinese mainland support IPv6.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>174494b666-x****.dualstack.cn-hangzhou.nas.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("DualStackMountTargetDomain")]
                        [Validation(Required=false)]
                        public string DualStackMountTargetDomain { get; set; }

                        /// <summary>
                        /// <para>The domain name of the mount target.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>109c042666-w****.cn-hangzhou.nas.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("MountTargetDomain")]
                        [Validation(Required=false)]
                        public string MountTargetDomain { get; set; }

                        /// <summary>
                        /// <para>The network type. Valid value: vpc.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <para>The status of the mount target.</para>
                        /// <para>Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Active</description></item>
                        /// <item><description>Inactive</description></item>
                        /// <item><description>Pending</description></item>
                        /// <item><description>Deleting</description></item>
                        /// <item><description>Hibernating</description></item>
                        /// <item><description>Hibernated</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Active</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The tags that are attached to the mount target.</para>
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
                                /// <para>The tag key.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>test</para>
                                /// </summary>
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                /// <summary>
                                /// <para>The tag value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>test-value</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The ID of the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-bp1sevsgtqvk5gxbl****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// <para>The ID of the vSwitch.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-bp1omfzsszekkvaxn****</para>
                        /// </summary>
                        [NameInMap("VswId")]
                        [Validation(Required=false)]
                        public string VswId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The options.</para>
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemOptions Options { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemOptions : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable the oplock feature. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: enables the feature.</description></item>
                    /// <item><description>false: disables the feature.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> Only Server Message Block (SMB) file systems support this feature.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EnableOplock")]
                    [Validation(Required=false)]
                    public bool? EnableOplock { get; set; }

                }

                /// <summary>
                /// <para>The information about storage plans.</para>
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
                        /// <para>The end time of the validity period for the storage plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2020-01-05T16:00:00Z</para>
                        /// </summary>
                        [NameInMap("ExpiredTime")]
                        [Validation(Required=false)]
                        public string ExpiredTime { get; set; }

                        /// <summary>
                        /// <para>The ID of the storage plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>naspackage-0be9c4b624-37****</para>
                        /// </summary>
                        [NameInMap("PackageId")]
                        [Validation(Required=false)]
                        public string PackageId { get; set; }

                        /// <summary>
                        /// <para>The type of the storage plan.</para>
                        /// <para>Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>ssd: The storage plan for Performance NAS file systems.</description></item>
                        /// <item><description>hybrid: The storage plan for Capacity NAS file systems.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hybrid</para>
                        /// </summary>
                        [NameInMap("PackageType")]
                        [Validation(Required=false)]
                        public string PackageType { get; set; }

                        /// <summary>
                        /// <para>The capacity of the storage plan. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>107374182400</para>
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public long? Size { get; set; }

                        /// <summary>
                        /// <para>The start time of the validity period for the storage plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-12-05T01:40:56Z</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The protocol type of the file system.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NFS: Network File System.</description></item>
                /// <item><description>SMB: Server Message Block.</description></item>
                /// <item><description>cpfs: The protocol type supported by the CPFS file system.</description></item>
                /// </list>
                /// <remarks>
                /// <para> CPFS file systems are available only on the China site (aliyun.com).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>NFS</para>
                /// </summary>
                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-2ze37k6jh8ums2fw2****</para>
                /// </summary>
                [NameInMap("QuorumVswId")]
                [Validation(Required=false)]
                public string QuorumVswId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmwavnfdf****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The status of the file system. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The file system is being created or modified.</description></item>
                /// <item><description>Running: The file system is available. Before you create a mount target for the file system, make sure that the file system is in the Running state.</description></item>
                /// <item><description>Stopped: The file system is unavailable.</description></item>
                /// <item><description>Extending: The file system is being scaled up.</description></item>
                /// <item><description>Stopping: The file system is being stopped.</description></item>
                /// <item><description>Deleting: The file system is being deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Pending</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Valid values for General-purpose NAS file systems: Capacity,Premium and Performance.</description></item>
                /// <item><description>Valid values for Extreme NAS file systems: standard and advance.</description></item>
                /// <item><description>Valid values for CPFS file systems: advance_100 (100 MB/s/TiB baseline) and advance_200 (200 MB/s/TiB baseline).<remarks>
                /// <para>CPFS file systems are available only on the China site (aliyun.com).</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Performance</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The features that are supported by the file system.</para>
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
                /// <para>The tags that are attached to the file system.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-value</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The version number of the file system.</para>
                /// <para>This parameter is available only for Extreme NAS file systems and CPFS file systems.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.3.4</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1cbv1ljve4j5hlw****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>cpfs-370y1tv921vpuj4****-000001.cn-wulanchabu.cpfs.aliyuncs.com</para>
                /// </summary>
                [NameInMap("VscTarget")]
                [Validation(Required=false)]
                public string VscTarget { get; set; }

                /// <summary>
                /// <para>The information about vSwitch.</para>
                /// </summary>
                [NameInMap("VswIds")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemVswIds VswIds { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemVswIds : TeaModel {
                    [NameInMap("VswId")]
                    [Validation(Required=false)]
                    public List<string> VswId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the zone where the file system resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>035B3A3A-E514-4B41-B906-5D906CFB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of file systems.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
