// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class GetLaunchTemplateDataResponseBody : TeaModel {
        [NameInMap("LaunchTemplateData")]
        [Validation(Required=false)]
        public GetLaunchTemplateDataResponseBodyLaunchTemplateData LaunchTemplateData { get; set; }
        public class GetLaunchTemplateDataResponseBodyLaunchTemplateData : TeaModel {
            [NameInMap("SystemDisk")]
            [Validation(Required=true)]
            public GetLaunchTemplateDataResponseBodyLaunchTemplateDataSystemDisk SystemDisk { get; set; }
            public class GetLaunchTemplateDataResponseBodyLaunchTemplateDataSystemDisk : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                [NameInMap("Iops")]
                [Validation(Required=false)]
                public int? Iops { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            [NameInMap("AutoReleaseTime")]
            [Validation(Required=false)]
            public string AutoReleaseTime { get; set; }

            [NameInMap("DataDisks")]
            [Validation(Required=false)]
            public GetLaunchTemplateDataResponseBodyLaunchTemplateDataDataDisks DataDisks { get; set; }
            public class GetLaunchTemplateDataResponseBodyLaunchTemplateDataDataDisks : TeaModel {
                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public List<GetLaunchTemplateDataResponseBodyLaunchTemplateDataDataDisksDataDisk> DataDisk { get; set; }
                public class GetLaunchTemplateDataResponseBodyLaunchTemplateDataDataDisksDataDisk : TeaModel {
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

                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                    [NameInMap("SnapshotId")]
                    [Validation(Required=false)]
                    public string SnapshotId { get; set; }

                }

            }

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

            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            [NameInMap("NetworkInterfaces")]
            [Validation(Required=false)]
            public GetLaunchTemplateDataResponseBodyLaunchTemplateDataNetworkInterfaces NetworkInterfaces { get; set; }
            public class GetLaunchTemplateDataResponseBodyLaunchTemplateDataNetworkInterfaces : TeaModel {
                [NameInMap("NetworkInterface")]
                [Validation(Required=false)]
                public List<GetLaunchTemplateDataResponseBodyLaunchTemplateDataNetworkInterfacesNetworkInterface> NetworkInterface { get; set; }
                public class GetLaunchTemplateDataResponseBodyLaunchTemplateDataNetworkInterfacesNetworkInterface : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("NetworkInterfaceName")]
                    [Validation(Required=false)]
                    public string NetworkInterfaceName { get; set; }

                    [NameInMap("PrimaryIpAddress")]
                    [Validation(Required=false)]
                    public string PrimaryIpAddress { get; set; }

                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

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

            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("SecurityEnhancementStrategy")]
            [Validation(Required=false)]
            public bool? SecurityEnhancementStrategy { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

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
            public GetLaunchTemplateDataResponseBodyLaunchTemplateDataTags Tags { get; set; }
            public class GetLaunchTemplateDataResponseBodyLaunchTemplateDataTags : TeaModel {
                [NameInMap("InstanceTag")]
                [Validation(Required=false)]
                public List<GetLaunchTemplateDataResponseBodyLaunchTemplateDataTagsInstanceTag> InstanceTag { get; set; }
                public class GetLaunchTemplateDataResponseBodyLaunchTemplateDataTagsInstanceTag : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
