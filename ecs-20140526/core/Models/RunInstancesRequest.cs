// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RunInstancesRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public RunInstancesRequestSystemDisk SystemDisk { get; set; }
        public class RunInstancesRequestSystemDisk : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }
        };

        [NameInMap("HibernationOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestHibernationOptions HibernationOptions { get; set; }
        public class RunInstancesRequestHibernationOptions : TeaModel {
            [NameInMap("Configured")]
            [Validation(Required=false)]
            public bool? Configured { get; set; }
        };

        [NameInMap("CpuOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestCpuOptions CpuOptions { get; set; }
        public class RunInstancesRequestCpuOptions : TeaModel {
            [NameInMap("Core")]
            [Validation(Required=false)]
            public int? Core { get; set; }
            [NameInMap("ThreadsPerCore")]
            [Validation(Required=false)]
            public int? ThreadsPerCore { get; set; }
            [NameInMap("Numa")]
            [Validation(Required=false)]
            public string Numa { get; set; }
        };

        [NameInMap("SecurityOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestSecurityOptions SecurityOptions { get; set; }
        public class RunInstancesRequestSecurityOptions : TeaModel {
            [NameInMap("TrustedSystemMode")]
            [Validation(Required=false)]
            public string TrustedSystemMode { get; set; }
            [NameInMap("ConfidentialComputingMode")]
            [Validation(Required=false)]
            public string ConfidentialComputingMode { get; set; }
        };

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class RunInstancesRequestPrivatePoolOptions : TeaModel {
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("SchedulerOptions")]
        [Validation(Required=false)]
        public RunInstancesRequestSchedulerOptions SchedulerOptions { get; set; }
        public class RunInstancesRequestSchedulerOptions : TeaModel {
            [NameInMap("DedicatedHostClusterId")]
            [Validation(Required=false)]
            public string DedicatedHostClusterId { get; set; }
        };

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        [NameInMap("MinAmount")]
        [Validation(Required=false)]
        public int? MinAmount { get; set; }

        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public string AutoReleaseTime { get; set; }

        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        [NameInMap("SpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInterruptionBehavior { get; set; }

        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("HpcClusterId")]
        [Validation(Required=false)]
        public string HpcClusterId { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public long? LaunchTemplateVersion { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        [NameInMap("DeploymentSetGroupNo")]
        [Validation(Required=false)]
        public int? DeploymentSetGroupNo { get; set; }

        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        [NameInMap("NetworkInterfaceQueueNumber")]
        [Validation(Required=false)]
        public int? NetworkInterfaceQueueNumber { get; set; }

        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public string Affinity { get; set; }

        [NameInMap("Tenancy")]
        [Validation(Required=false)]
        public string Tenancy { get; set; }

        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        [NameInMap("HttpEndpoint")]
        [Validation(Required=false)]
        public string HttpEndpoint { get; set; }

        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        [NameInMap("HttpPutResponseHopLimit")]
        [Validation(Required=false)]
        public int? HttpPutResponseHopLimit { get; set; }

        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        [NameInMap("HostNames")]
        [Validation(Required=false)]
        public List<string> HostNames { get; set; }

        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<RunInstancesRequestDataDisk> DataDisk { get; set; }
        public class RunInstancesRequestDataDisk : TeaModel {
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("EncryptAlgorithm")]
            [Validation(Required=false)]
            public string EncryptAlgorithm { get; set; }

            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

        }

        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<RunInstancesRequestArn> Arn { get; set; }
        public class RunInstancesRequestArn : TeaModel {
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            [NameInMap("Rolearn")]
            [Validation(Required=false)]
            public string Rolearn { get; set; }

            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public long? AssumeRoleFor { get; set; }

        }

        [NameInMap("NetworkInterface")]
        [Validation(Required=false)]
        public List<RunInstancesRequestNetworkInterface> NetworkInterface { get; set; }
        public class RunInstancesRequestNetworkInterface : TeaModel {
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("NetworkInterfaceName")]
            [Validation(Required=false)]
            public string NetworkInterfaceName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("PrimaryIpAddress")]
            [Validation(Required=false)]
            public string PrimaryIpAddress { get; set; }

            [NameInMap("QueueNumber")]
            [Validation(Required=false)]
            public int? QueueNumber { get; set; }

            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

        }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RunInstancesRequestTag> Tag { get; set; }
        public class RunInstancesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

    }

}
