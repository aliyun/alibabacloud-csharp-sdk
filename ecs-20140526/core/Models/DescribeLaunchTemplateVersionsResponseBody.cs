// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplateVersionsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("LaunchTemplateVersionSets")]
        [Validation(Required=false)]
        public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSets> LaunchTemplateVersionSets { get; set; }
        public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSets : TeaModel {
            [NameInMap("LaunchTemplateName")]
            [Validation(Required=false)]
            public string LaunchTemplateName { get; set; }

            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public bool? DefaultVersion { get; set; }

            [NameInMap("VersionNumber")]
            [Validation(Required=false)]
            public long? VersionNumber { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("LaunchTemplateData")]
            [Validation(Required=false)]
            public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateData LaunchTemplateData { get; set; }
            public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateData : TeaModel {
                [NameInMap("SystemDisk")]
                [Validation(Required=true)]
                public DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateDataSystemDisk SystemDisk { get; set; }
                public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateDataSystemDisk : TeaModel {
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                    [NameInMap("DiskName")]
                    [Validation(Required=false)]
                    public string DiskName { get; set; }

                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Iops")]
                    [Validation(Required=false)]
                    public int? Iops { get; set; }

                }
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateDataTags> Tags { get; set; }
                public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateDataTags : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }
                [NameInMap("DataDisks")]
                [Validation(Required=false)]
                public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateDataDataDisks> DataDisks { get; set; }
                public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateDataDataDisks : TeaModel {
                    public string Description { get; set; }
                    public string SnapshotId { get; set; }
                    public string Device { get; set; }
                    public int? Size { get; set; }
                    public string DiskName { get; set; }
                    public string Category { get; set; }
                    public bool? DeleteWithInstance { get; set; }
                    public string Encrypted { get; set; }
                }
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }
                [NameInMap("EnableVmOsConfig")]
                [Validation(Required=false)]
                public bool? EnableVmOsConfig { get; set; }
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }
                [NameInMap("SpotDuration")]
                [Validation(Required=false)]
                public int? SpotDuration { get; set; }
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }
                [NameInMap("SecurityEnhancementStrategy")]
                [Validation(Required=false)]
                public string SecurityEnhancementStrategy { get; set; }
                [NameInMap("PasswordInherit")]
                [Validation(Required=false)]
                public bool? PasswordInherit { get; set; }
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }
                [NameInMap("AutoReleaseTime")]
                [Validation(Required=false)]
                public string AutoReleaseTime { get; set; }
                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }
                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }
                [NameInMap("InternetMaxBandwidthIn")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthIn { get; set; }
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }
                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }
                [NameInMap("IoOptimized")]
                [Validation(Required=false)]
                public string IoOptimized { get; set; }
                [NameInMap("RamRoleName")]
                [Validation(Required=false)]
                public string RamRoleName { get; set; }
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }
                [NameInMap("NetworkInterfaces")]
                [Validation(Required=false)]
                public List<DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateDataNetworkInterfaces> NetworkInterfaces { get; set; }
                public class DescribeLaunchTemplateVersionsResponseBodyLaunchTemplateVersionSetsLaunchTemplateDataNetworkInterfaces : TeaModel {
                    public string NetworkInterfaceName { get; set; }
                    public string VSwitchId { get; set; }
                    public string Description { get; set; }
                    public string SecurityGroupId { get; set; }
                    public string PrimaryIpAddress { get; set; }
                }
            };

            [NameInMap("LaunchTemplateId")]
            [Validation(Required=false)]
            public string LaunchTemplateId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            [NameInMap("VersionDescription")]
            [Validation(Required=false)]
            public string VersionDescription { get; set; }

        }

    }

}
