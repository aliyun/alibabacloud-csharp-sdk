// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("DedicatedHostAttribute")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesDedicatedHostAttribute DedicatedHostAttribute { get; set; }
            public class DescribeInstancesResponseBodyInstancesDedicatedHostAttribute : TeaModel {
                [NameInMap("DedicatedHostName")]
                [Validation(Required=false)]
                public string DedicatedHostName { get; set; }
                [NameInMap("DedicatedHostClusterId")]
                [Validation(Required=false)]
                public string DedicatedHostClusterId { get; set; }
                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }
            };

            [NameInMap("OperationLocks")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesOperationLocks> OperationLocks { get; set; }
            public class DescribeInstancesResponseBodyInstancesOperationLocks : TeaModel {
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                [NameInMap("LockMsg")]
                [Validation(Required=false)]
                public string LockMsg { get; set; }

            }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesTags> Tags { get; set; }
            public class DescribeInstancesResponseBodyInstancesTags : TeaModel {
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

            }

            [NameInMap("MetadataOptions")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesMetadataOptions MetadataOptions { get; set; }
            public class DescribeInstancesResponseBodyInstancesMetadataOptions : TeaModel {
                [NameInMap("HttpPutResponseHopLimit")]
                [Validation(Required=false)]
                public int? HttpPutResponseHopLimit { get; set; }
                [NameInMap("HttpEndpoint")]
                [Validation(Required=false)]
                public string HttpEndpoint { get; set; }
                [NameInMap("HttpTokens")]
                [Validation(Required=false)]
                public string HttpTokens { get; set; }
            };

            [NameInMap("SaleCycle")]
            [Validation(Required=false)]
            public string SaleCycle { get; set; }

            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public List<string> PublicIpAddress { get; set; }

            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            [NameInMap("DeviceAvailable")]
            [Validation(Required=false)]
            public bool? DeviceAvailable { get; set; }

            [NameInMap("EipAddress")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesEipAddress EipAddress { get; set; }
            public class DescribeInstancesResponseBodyInstancesEipAddress : TeaModel {
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }
                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }
                [NameInMap("IsSupportUnassociate")]
                [Validation(Required=false)]
                public bool? IsSupportUnassociate { get; set; }
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }
            };

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceNetworkType")]
            [Validation(Required=false)]
            public string InstanceNetworkType { get; set; }

            [NameInMap("SpotDuration")]
            [Validation(Required=false)]
            public int? SpotDuration { get; set; }

            [NameInMap("OSNameEn")]
            [Validation(Required=false)]
            public string OSNameEn { get; set; }

            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

            [NameInMap("OSName")]
            [Validation(Required=false)]
            public string OSName { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("DeploymentSetGroupNo")]
            [Validation(Required=false)]
            public int? DeploymentSetGroupNo { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("DedicatedInstanceAttribute")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesDedicatedInstanceAttribute DedicatedInstanceAttribute { get; set; }
            public class DescribeInstancesResponseBodyInstancesDedicatedInstanceAttribute : TeaModel {
                [NameInMap("Affinity")]
                [Validation(Required=false)]
                public string Affinity { get; set; }
                [NameInMap("Tenancy")]
                [Validation(Required=false)]
                public string Tenancy { get; set; }
            };

            [NameInMap("GPUSpec")]
            [Validation(Required=false)]
            public string GPUSpec { get; set; }

            [NameInMap("AutoReleaseTime")]
            [Validation(Required=false)]
            public string AutoReleaseTime { get; set; }

            [NameInMap("InnerIpAddress")]
            [Validation(Required=false)]
            public List<string> InnerIpAddress { get; set; }

            [NameInMap("StoppedMode")]
            [Validation(Required=false)]
            public string StoppedMode { get; set; }

            [NameInMap("GPUAmount")]
            [Validation(Required=false)]
            public int? GPUAmount { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("Recyclable")]
            [Validation(Required=false)]
            public bool? Recyclable { get; set; }

            [NameInMap("CreditSpecification")]
            [Validation(Required=false)]
            public string CreditSpecification { get; set; }

            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("DeploymentSetId")]
            [Validation(Required=false)]
            public string DeploymentSetId { get; set; }

            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            [NameInMap("CpuOptions")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesCpuOptions CpuOptions { get; set; }
            public class DescribeInstancesResponseBodyInstancesCpuOptions : TeaModel {
                [NameInMap("Numa")]
                [Validation(Required=false)]
                public string Numa { get; set; }
                [NameInMap("CoreCount")]
                [Validation(Required=false)]
                public int? CoreCount { get; set; }
                [NameInMap("ThreadsPerCore")]
                [Validation(Required=false)]
                public int? ThreadsPerCore { get; set; }
            };

            [NameInMap("LocalStorageCapacity")]
            [Validation(Required=false)]
            public long? LocalStorageCapacity { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("HpcClusterId")]
            [Validation(Required=false)]
            public string HpcClusterId { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            [NameInMap("VlanId")]
            [Validation(Required=false)]
            public string VlanId { get; set; }

            [NameInMap("VpcAttributes")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesVpcAttributes VpcAttributes { get; set; }
            public class DescribeInstancesResponseBodyInstancesVpcAttributes : TeaModel {
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
                [NameInMap("NatIpAddress")]
                [Validation(Required=false)]
                public string NatIpAddress { get; set; }
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public List<string> PrivateIpAddress { get; set; }
            };

            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            [NameInMap("EcsCapacityReservationAttr")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesEcsCapacityReservationAttr EcsCapacityReservationAttr { get; set; }
            public class DescribeInstancesResponseBodyInstancesEcsCapacityReservationAttr : TeaModel {
                [NameInMap("CapacityReservationPreference")]
                [Validation(Required=false)]
                public string CapacityReservationPreference { get; set; }
                [NameInMap("CapacityReservationId")]
                [Validation(Required=false)]
                public string CapacityReservationId { get; set; }
            };

            [NameInMap("InternetMaxBandwidthIn")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthIn { get; set; }

            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }

            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public bool? IoOptimized { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            [NameInMap("RdmaIpAddress")]
            [Validation(Required=false)]
            public List<string> RdmaIpAddress { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("LocalStorageAmount")]
            [Validation(Required=false)]
            public int? LocalStorageAmount { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            [NameInMap("NetworkInterfaces")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesNetworkInterfaces> NetworkInterfaces { get; set; }
            public class DescribeInstancesResponseBodyInstancesNetworkInterfaces : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("MacAddress")]
                [Validation(Required=false)]
                public string MacAddress { get; set; }

                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                [NameInMap("Ipv6Sets")]
                [Validation(Required=false)]
                public List<DescribeInstancesResponseBodyInstancesNetworkInterfacesIpv6Sets> Ipv6Sets { get; set; }
                public class DescribeInstancesResponseBodyInstancesNetworkInterfacesIpv6Sets : TeaModel {
                    [NameInMap("Ipv6Address")]
                    [Validation(Required=false)]
                    public string Ipv6Address { get; set; }

                }

                [NameInMap("PrimaryIpAddress")]
                [Validation(Required=false)]
                public string PrimaryIpAddress { get; set; }

                [NameInMap("PrivateIpSets")]
                [Validation(Required=false)]
                public List<DescribeInstancesResponseBodyInstancesNetworkInterfacesPrivateIpSets> PrivateIpSets { get; set; }
                public class DescribeInstancesResponseBodyInstancesNetworkInterfacesPrivateIpSets : TeaModel {
                    [NameInMap("Primary")]
                    [Validation(Required=false)]
                    public bool? Primary { get; set; }

                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public string PrivateIpAddress { get; set; }

                }

            }

        }

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

    }

}
