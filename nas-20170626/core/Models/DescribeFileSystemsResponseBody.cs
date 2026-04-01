// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFileSystemsResponseBody : TeaModel {
        [NameInMap("FileSystems")]
        [Validation(Required=false)]
        public DescribeFileSystemsResponseBodyFileSystems FileSystems { get; set; }
        public class DescribeFileSystemsResponseBodyFileSystems : TeaModel {
            [NameInMap("FileSystem")]
            [Validation(Required=false)]
            public List<DescribeFileSystemsResponseBodyFileSystemsFileSystem> FileSystem { get; set; }
            public class DescribeFileSystemsResponseBodyFileSystemsFileSystem : TeaModel {
                [NameInMap("AccessPointCount")]
                [Validation(Required=false)]
                public string AccessPointCount { get; set; }

                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public int? EncryptType { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                [NameInMap("Ldap")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemLdap Ldap { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemLdap : TeaModel {
                    [NameInMap("BindDN")]
                    [Validation(Required=false)]
                    public string BindDN { get; set; }

                    [NameInMap("SearchBase")]
                    [Validation(Required=false)]
                    public string SearchBase { get; set; }

                    [NameInMap("URI")]
                    [Validation(Required=false)]
                    public string URI { get; set; }

                }

                [NameInMap("MeteredArchiveSize")]
                [Validation(Required=false)]
                public long? MeteredArchiveSize { get; set; }

                [NameInMap("MeteredIASize")]
                [Validation(Required=false)]
                public long? MeteredIASize { get; set; }

                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public long? MeteredSize { get; set; }

                [NameInMap("MountTargets")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargets MountTargets { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargets : TeaModel {
                    [NameInMap("MountTarget")]
                    [Validation(Required=false)]
                    public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTarget> MountTarget { get; set; }
                    public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTarget : TeaModel {
                        [NameInMap("AccessGroupName")]
                        [Validation(Required=false)]
                        public string AccessGroupName { get; set; }

                        [NameInMap("ClientMasterNodes")]
                        [Validation(Required=false)]
                        public DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetClientMasterNodes ClientMasterNodes { get; set; }
                        public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetClientMasterNodes : TeaModel {
                            [NameInMap("ClientMasterNode")]
                            [Validation(Required=false)]
                            public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetClientMasterNodesClientMasterNode> ClientMasterNode { get; set; }
                            public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetClientMasterNodesClientMasterNode : TeaModel {
                                [NameInMap("DefaultPasswd")]
                                [Validation(Required=false)]
                                public string DefaultPasswd { get; set; }

                                [NameInMap("EcsId")]
                                [Validation(Required=false)]
                                public string EcsId { get; set; }

                                [NameInMap("EcsIp")]
                                [Validation(Required=false)]
                                public string EcsIp { get; set; }

                            }

                        }

                        [NameInMap("DualStackMountTargetDomain")]
                        [Validation(Required=false)]
                        public string DualStackMountTargetDomain { get; set; }

                        [NameInMap("MountTargetDomain")]
                        [Validation(Required=false)]
                        public string MountTargetDomain { get; set; }

                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetTags Tags { get; set; }
                        public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetTags : TeaModel {
                            [NameInMap("Tag")]
                            [Validation(Required=false)]
                            public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetTagsTag> Tag { get; set; }
                            public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetTagsTag : TeaModel {
                                [NameInMap("Key")]
                                [Validation(Required=false)]
                                public string Key { get; set; }

                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        [NameInMap("VswId")]
                        [Validation(Required=false)]
                        public string VswId { get; set; }

                    }

                }

                [NameInMap("Options")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemOptions Options { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemOptions : TeaModel {
                    [NameInMap("EnableABE")]
                    [Validation(Required=false)]
                    public bool? EnableABE { get; set; }

                    [NameInMap("EnableOplock")]
                    [Validation(Required=false)]
                    public bool? EnableOplock { get; set; }

                }

                [NameInMap("Packages")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemPackages Packages { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemPackages : TeaModel {
                    [NameInMap("Package")]
                    [Validation(Required=false)]
                    public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemPackagesPackage> Package { get; set; }
                    public class DescribeFileSystemsResponseBodyFileSystemsFileSystemPackagesPackage : TeaModel {
                        [NameInMap("ExpiredTime")]
                        [Validation(Required=false)]
                        public string ExpiredTime { get; set; }

                        [NameInMap("PackageId")]
                        [Validation(Required=false)]
                        public string PackageId { get; set; }

                        [NameInMap("PackageType")]
                        [Validation(Required=false)]
                        public string PackageType { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public long? Size { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                [NameInMap("QuorumVswId")]
                [Validation(Required=false)]
                public string QuorumVswId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LRS</para>
                /// </summary>
                [NameInMap("RedundancyType")]
                [Validation(Required=false)]
                public string RedundancyType { get; set; }

                [NameInMap("RedundancyVSwitchIds")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemRedundancyVSwitchIds RedundancyVSwitchIds { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemRedundancyVSwitchIds : TeaModel {
                    [NameInMap("RedundancyVSwitchId")]
                    [Validation(Required=false)]
                    public List<string> RedundancyVSwitchId { get; set; }

                }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                [NameInMap("SupportedFeatures")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemSupportedFeatures SupportedFeatures { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemSupportedFeatures : TeaModel {
                    [NameInMap("SupportedFeature")]
                    [Validation(Required=false)]
                    public List<string> SupportedFeature { get; set; }

                }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemTags Tags { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemTagsTag> Tag { get; set; }
                    public class DescribeFileSystemsResponseBodyFileSystemsFileSystemTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VscTarget")]
                [Validation(Required=false)]
                public string VscTarget { get; set; }

                [NameInMap("VswIds")]
                [Validation(Required=false)]
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemVswIds VswIds { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemVswIds : TeaModel {
                    [NameInMap("VswId")]
                    [Validation(Required=false)]
                    public List<string> VswId { get; set; }

                }

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
