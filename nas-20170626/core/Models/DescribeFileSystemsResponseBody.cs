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
                public string Status { get; set; }
                public long? MeteredIASize { get; set; }
                public long? Capacity { get; set; }
                public string CreateTime { get; set; }
                public string ChargeType { get; set; }
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
                public string StorageType { get; set; }
                public long? MeteredSize { get; set; }
                public string Description { get; set; }
                public long? Bandwidth { get; set; }
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemSupportedFeatures SupportedFeatures { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemSupportedFeatures : TeaModel {
                    [NameInMap("SupportedFeature")]
                    [Validation(Required=false)]
                    public List<string> SupportedFeature { get; set; }

                }
                public string Version { get; set; }
                public string ProtocolType { get; set; }
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargets MountTargets { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargets : TeaModel {
                    [NameInMap("MountTarget")]
                    [Validation(Required=false)]
                    public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTarget> MountTarget { get; set; }
                    public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTarget : TeaModel {
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("ClientMasterNodes")]
                        [Validation(Required=false)]
                        public DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetClientMasterNodes ClientMasterNodes { get; set; }
                        public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetClientMasterNodes : TeaModel {
                            [NameInMap("ClientMasterNode")]
                            [Validation(Required=false)]
                            public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetClientMasterNodesClientMasterNode> ClientMasterNode { get; set; }
                            public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetClientMasterNodesClientMasterNode : TeaModel {
                                public string EcsId { get; set; }
                                public string DefaultPasswd { get; set; }
                                public string EcsIp { get; set; }
                            }
                        };

                        [NameInMap("MountTargetDomain")]
                        [Validation(Required=false)]
                        public string MountTargetDomain { get; set; }

                        [NameInMap("AccessGroupName")]
                        [Validation(Required=false)]
                        public string AccessGroupName { get; set; }

                        [NameInMap("DualStackMountTargetDomain")]
                        [Validation(Required=false)]
                        public string DualStackMountTargetDomain { get; set; }

                        [NameInMap("VswId")]
                        [Validation(Required=false)]
                        public string VswId { get; set; }

                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetTags Tags { get; set; }
                        public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetTags : TeaModel {
                            [NameInMap("Tag")]
                            [Validation(Required=false)]
                            public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetTagsTag> Tag { get; set; }
                            public class DescribeFileSystemsResponseBodyFileSystemsFileSystemMountTargetsMountTargetTagsTag : TeaModel {
                                public string Key { get; set; }
                                public string Value { get; set; }
                            }
                        };

                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                    }

                }
                public string KMSKeyId { get; set; }
                public string RegionId { get; set; }
                public string FileSystemType { get; set; }
                public string FileSystemId { get; set; }
                public int? EncryptType { get; set; }
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
                public string ExpiredTime { get; set; }
                public string ZoneId { get; set; }
                public DescribeFileSystemsResponseBodyFileSystemsFileSystemPackages Packages { get; set; }
                public class DescribeFileSystemsResponseBodyFileSystemsFileSystemPackages : TeaModel {
                    [NameInMap("Package")]
                    [Validation(Required=false)]
                    public List<DescribeFileSystemsResponseBodyFileSystemsFileSystemPackagesPackage> Package { get; set; }
                    public class DescribeFileSystemsResponseBodyFileSystemsFileSystemPackagesPackage : TeaModel {
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("ExpiredTime")]
                        [Validation(Required=false)]
                        public string ExpiredTime { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public long? Size { get; set; }

                        [NameInMap("PackageId")]
                        [Validation(Required=false)]
                        public string PackageId { get; set; }

                        [NameInMap("PackageType")]
                        [Validation(Required=false)]
                        public string PackageType { get; set; }

                    }

                }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
