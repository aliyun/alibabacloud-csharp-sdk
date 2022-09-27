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
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreatedBy")]
                [Validation(Required=false)]
                public string CreatedBy { get; set; }

                [NameInMap("DefaultVersion")]
                [Validation(Required=false)]
                public bool? DefaultVersion { get; set; }

                [NameInMap("LaunchTemplateData")]
                [Validation(Required=false)]
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

                    }

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

                            [NameInMap("Device")]
                            [Validation(Required=false)]
                            public string Device { get; set; }

                            [NameInMap("DiskName")]
                            [Validation(Required=false)]
                            public string DiskName { get; set; }

                            [NameInMap("Encrypted")]
                            [Validation(Required=false)]
                            public string Encrypted { get; set; }

                            [NameInMap("PerformanceLevel")]
                            [Validation(Required=false)]
                            public string PerformanceLevel { get; set; }

                            [NameInMap("ProvisionedIops")]
                            [Validation(Required=false)]
                            public long? ProvisionedIops { get; set; }

                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public int? Size { get; set; }

                            [NameInMap("SnapshotId")]
                            [Validation(Required=false)]
                            public string SnapshotId { get; set; }

                        }

                    }

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
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            [NameInMap("InstanceType")]
                            [Validation(Required=false)]
                            public string InstanceType { get; set; }

                            [NameInMap("NetworkInterfaceName")]
                            [Validation(Required=false)]
                            public string NetworkInterfaceName { get; set; }

                            [NameInMap("NetworkInterfaceTrafficMode")]
                            [Validation(Required=false)]
                            public string NetworkInterfaceTrafficMode { get; set; }

                            [NameInMap("PrimaryIpAddress")]
                            [Validation(Required=false)]
                            public string PrimaryIpAddress { get; set; }

                            [NameInMap("SecurityGroupId")]
                            [Validation(Required=false)]
                            public string SecurityGroupId { get; set; }

                            [NameInMap("SecurityGroupIds")]
                            [Validation(Required=false)]
                            public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterfaceSecurityGroupIds SecurityGroupIds { get; set; }
                            public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateVersionSetLaunchTemplateDataNetworkInterfacesNetworkInterfaceSecurityGroupIds : TeaModel {
                                [NameInMap("SecurityGroupId")]
                                [Validation(Required=false)]
                                public List<string> SecurityGroupId { get; set; }

                            }

                            [NameInMap("VSwitchId")]
                            [Validation(Required=false)]
                            public string VSwitchId { get; set; }

                        }

                    }

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

                    }

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
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

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

                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                [NameInMap("LaunchTemplateName")]
                [Validation(Required=false)]
                public string LaunchTemplateName { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("VersionDescription")]
                [Validation(Required=false)]
                public string VersionDescription { get; set; }

                [NameInMap("VersionNumber")]
                [Validation(Required=false)]
                public long? VersionNumber { get; set; }

            }

        }

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
