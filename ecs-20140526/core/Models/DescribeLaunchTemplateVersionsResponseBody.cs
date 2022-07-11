// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplateVersionsResponseBody : TeaModel {
        [NameInMap("LaunchTemplateVersionSets")]
        [Validation(Required=false)]
        public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSets LaunchTemplateVersionSets { get; set; }
        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSets : TeaModel {
            [NameInMap("LaunchTemplateVersionSet")]
            [Validation(Required=false)]
            public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSet> LaunchTemplateVersionSet { get; set; }
            public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSet : TeaModel {
                public string CreateTime { get; set; }
                public string CreatedBy { get; set; }
                public bool? DefaultVersion { get; set; }
                public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateData LaunchTemplateData { get; set; }
                public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateData : TeaModel {
                    [NameInMap("SystemDisk")]
                    [Validation(Required=true)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataSystemDisk SystemDisk { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataSystemDisk : TeaModel {
                        [NameInMap("AutoSnapshotPolicyId")]
                        [Validation(Required=false)]
                        public string AutoSnapshotPolicyId { get; set; }
                        [NameInMap("BurstingEnabled")]
                        [Validation(Required=false)]
                        public bool? BurstingEnabled { get; set; }
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }
                        [NameInMap("DeleteWithInstance")]
                        [Validation(Required=false)]
                        public bool? DeleteWithInstance { get; set; }
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }
                        [NameInMap("DiskName")]
                        [Validation(Required=false)]
                        public string DiskName { get; set; }
                        [NameInMap("Iops")]
                        [Validation(Required=false)]
                        public int? Iops { get; set; }
                        [NameInMap("PerformanceLevel")]
                        [Validation(Required=false)]
                        public string PerformanceLevel { get; set; }
                        [NameInMap("ProvisionedIops")]
                        [Validation(Required=false)]
                        public long? ProvisionedIops { get; set; }
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }
                    };

                    [NameInMap("AutoReleaseTime")]
                    [Validation(Required=false)]
                    public string AutoReleaseTime { get; set; }

                    [NameInMap("DataDisks")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataDataDisks DataDisks { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataDataDisks : TeaModel {
                        [NameInMap("DataDisk")]
                        [Validation(Required=false)]
                        public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataDataDisksDataDisk> DataDisk { get; set; }
                        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataDataDisksDataDisk : TeaModel {
                            public string AutoSnapshotPolicyId { get; set; }
                            public bool? BurstingEnabled { get; set; }
                            public string Category { get; set; }
                            public bool? DeleteWithInstance { get; set; }
                            public string Description { get; set; }
                            public string Device { get; set; }
                            public string DiskName { get; set; }
                            public string Encrypted { get; set; }
                            public string PerformanceLevel { get; set; }
                            public long? ProvisionedIops { get; set; }
                            public int? Size { get; set; }
                            public string SnapshotId { get; set; }
                        }
                    };

                    [NameInMap("DeploymentSetId")]
                    [Validation(Required=false)]
                    public string DeploymentSetId { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("EnableVmOsConfig")]
                    [Validation(Required=false)]
                    public bool? EnableVmOsConfig { get; set; }

                    [NameInMap("HostName")]
                    [Validation(Required=false)]
                    public string HostName { get; set; }

                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }

                    [NameInMap("ImageOwnerAlias")]
                    [Validation(Required=false)]
                    public string ImageOwnerAlias { get; set; }

                    [NameInMap("InstanceChargeType")]
                    [Validation(Required=false)]
                    public string InstanceChargeType { get; set; }

                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                    [NameInMap("InternetMaxBandwidthIn")]
                    [Validation(Required=false)]
                    public int? InternetMaxBandwidthIn { get; set; }

                    [NameInMap("InternetMaxBandwidthOut")]
                    [Validation(Required=false)]
                    public int? InternetMaxBandwidthOut { get; set; }

                    [NameInMap("IoOptimized")]
                    [Validation(Required=false)]
                    public string IoOptimized { get; set; }

                    [NameInMap("Ipv6AddressCount")]
                    [Validation(Required=false)]
                    public int? Ipv6AddressCount { get; set; }

                    [NameInMap("KeyPairName")]
                    [Validation(Required=false)]
                    public string KeyPairName { get; set; }

                    [NameInMap("NetworkInterfaces")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfaces NetworkInterfaces { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfaces : TeaModel {
                        [NameInMap("NetworkInterface")]
                        [Validation(Required=false)]
                        public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterface> NetworkInterface { get; set; }
                        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterface : TeaModel {
                            public string Description { get; set; }
                            public string InstanceType { get; set; }
                            public string NetworkInterfaceName { get; set; }
                            public string NetworkInterfaceTrafficMode { get; set; }
                            public string PrimaryIpAddress { get; set; }
                            public string SecurityGroupId { get; set; }
                            public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterfaceSecurityGroupIds SecurityGroupIds { get; set; }
                            public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterfaceSecurityGroupIds : TeaModel {
                                [NameInMap("SecurityGroupId")]
                                [Validation(Required=false)]
                                public List<string> SecurityGroupId { get; set; }

                            }
                            public string VSwitchId { get; set; }
                        }
                    };

                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    [NameInMap("PasswordInherit")]
                    [Validation(Required=false)]
                    public bool? PasswordInherit { get; set; }

                    [NameInMap("Period")]
                    [Validation(Required=false)]
                    public int? Period { get; set; }

                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public string PrivateIpAddress { get; set; }

                    [NameInMap("RamRoleName")]
                    [Validation(Required=false)]
                    public string RamRoleName { get; set; }

                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                    [NameInMap("SecurityEnhancementStrategy")]
                    [Validation(Required=false)]
                    public string SecurityEnhancementStrategy { get; set; }

                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    [NameInMap("SecurityGroupIds")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataSecurityGroupIds SecurityGroupIds { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataSecurityGroupIds : TeaModel {
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public List<string> SecurityGroupId { get; set; }
                    };

                    [NameInMap("SpotDuration")]
                    [Validation(Required=false)]
                    public int? SpotDuration { get; set; }

                    [NameInMap("SpotPriceLimit")]
                    [Validation(Required=false)]
                    public float? SpotPriceLimit { get; set; }

                    [NameInMap("SpotStrategy")]
                    [Validation(Required=false)]
                    public string SpotStrategy { get; set; }

                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataTags Tags { get; set; }
                    public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataTags : TeaModel {
                        [NameInMap("InstanceTag")]
                        [Validation(Required=false)]
                        public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataTagsInstanceTag> InstanceTag { get; set; }
                        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataTagsInstanceTag : TeaModel {
                            public string Key { get; set; }
                            public string Value { get; set; }
                        }
                    };

                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }
                public string LaunchTemplateId { get; set; }
                public string LaunchTemplateName { get; set; }
                public string ModifiedTime { get; set; }
                public string VersionDescription { get; set; }
                public long? VersionNumber { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
