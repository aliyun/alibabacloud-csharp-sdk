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
        public DescribeInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeInstancesResponseBodyInstancesInstance : TeaModel {
                public string CreationTime { get; set; }
                public string SerialNumber { get; set; }
                public DescribeInstancesResponseBodyInstancesInstanceDedicatedHostAttribute DedicatedHostAttribute { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceDedicatedHostAttribute : TeaModel {
                    [NameInMap("DedicatedHostName")]
                    [Validation(Required=false)]
                    public string DedicatedHostName { get; set; }

                    [NameInMap("DedicatedHostClusterId")]
                    [Validation(Required=false)]
                    public string DedicatedHostClusterId { get; set; }

                    [NameInMap("DedicatedHostId")]
                    [Validation(Required=false)]
                    public string DedicatedHostId { get; set; }

                }
                public DescribeInstancesResponseBodyInstancesInstanceOperationLocks OperationLocks { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceOperationLocks : TeaModel {
                    [NameInMap("LockReason")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceOperationLocksLockReason> LockReason { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceOperationLocksLockReason : TeaModel {
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                        [NameInMap("LockMsg")]
                        [Validation(Required=false)]
                        public string LockMsg { get; set; }

                    }

                }
                public DescribeInstancesResponseBodyInstancesInstanceTags Tags { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceTagsTag> Tag { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceTagsTag : TeaModel {
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                    }

                }
                public DescribeInstancesResponseBodyInstancesInstanceMetadataOptions MetadataOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceMetadataOptions : TeaModel {
                    [NameInMap("HttpPutResponseHopLimit")]
                    [Validation(Required=false)]
                    public int? HttpPutResponseHopLimit { get; set; }

                    [NameInMap("HttpEndpoint")]
                    [Validation(Required=false)]
                    public string HttpEndpoint { get; set; }

                    [NameInMap("HttpTokens")]
                    [Validation(Required=false)]
                    public string HttpTokens { get; set; }

                }
                public string SaleCycle { get; set; }
                public DescribeInstancesResponseBodyInstancesInstancePublicIpAddress PublicIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstancePublicIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }
                public string SpotStrategy { get; set; }
                public bool? DeviceAvailable { get; set; }
                public DescribeInstancesResponseBodyInstancesInstanceEipAddress EipAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceEipAddress : TeaModel {
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

                }
                public string InstanceName { get; set; }
                public string InstanceNetworkType { get; set; }
                public int? SpotDuration { get; set; }
                public string OSNameEn { get; set; }
                public float? SpotPriceLimit { get; set; }
                public string OSName { get; set; }
                public string ImageId { get; set; }
                public int? DeploymentSetGroupNo { get; set; }
                public string ClusterId { get; set; }
                public DescribeInstancesResponseBodyInstancesInstanceDedicatedInstanceAttribute DedicatedInstanceAttribute { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceDedicatedInstanceAttribute : TeaModel {
                    [NameInMap("Affinity")]
                    [Validation(Required=false)]
                    public string Affinity { get; set; }

                    [NameInMap("Tenancy")]
                    [Validation(Required=false)]
                    public string Tenancy { get; set; }

                }
                public string GPUSpec { get; set; }
                public string AutoReleaseTime { get; set; }
                public DescribeInstancesResponseBodyInstancesInstanceInnerIpAddress InnerIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceInnerIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }
                public string StoppedMode { get; set; }
                public int? GPUAmount { get; set; }
                public string HostName { get; set; }
                public string InstanceId { get; set; }
                public string InstanceType { get; set; }
                public string InstanceChargeType { get; set; }
                public string StartTime { get; set; }
                public string InternetChargeType { get; set; }
                public string ZoneId { get; set; }
                public bool? Recyclable { get; set; }
                public string CreditSpecification { get; set; }
                public string OSType { get; set; }
                public string Status { get; set; }
                public string DeploymentSetId { get; set; }
                public string KeyPairName { get; set; }
                public DescribeInstancesResponseBodyInstancesInstanceCpuOptions CpuOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceCpuOptions : TeaModel {
                    [NameInMap("Numa")]
                    [Validation(Required=false)]
                    public string Numa { get; set; }

                    [NameInMap("CoreCount")]
                    [Validation(Required=false)]
                    public int? CoreCount { get; set; }

                    [NameInMap("ThreadsPerCore")]
                    [Validation(Required=false)]
                    public int? ThreadsPerCore { get; set; }

                }
                public long? LocalStorageCapacity { get; set; }
                public string Description { get; set; }
                public string HpcClusterId { get; set; }
                public int? Memory { get; set; }
                public string VlanId { get; set; }
                public DescribeInstancesResponseBodyInstancesInstanceVpcAttributes VpcAttributes { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceVpcAttributes : TeaModel {
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
                    public DescribeInstancesResponseBodyInstancesInstanceVpcAttributesPrivateIpAddress PrivateIpAddress { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceVpcAttributesPrivateIpAddress : TeaModel {
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public List<string> IpAddress { get; set; }
                    };

                }
                public bool? DeletionProtection { get; set; }
                public DescribeInstancesResponseBodyInstancesInstanceEcsCapacityReservationAttr EcsCapacityReservationAttr { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceEcsCapacityReservationAttr : TeaModel {
                    [NameInMap("CapacityReservationPreference")]
                    [Validation(Required=false)]
                    public string CapacityReservationPreference { get; set; }

                    [NameInMap("CapacityReservationId")]
                    [Validation(Required=false)]
                    public string CapacityReservationId { get; set; }

                }
                public int? InternetMaxBandwidthIn { get; set; }
                public int? InternetMaxBandwidthOut { get; set; }
                public DescribeInstancesResponseBodyInstancesInstanceSecurityGroupIds SecurityGroupIds { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceSecurityGroupIds : TeaModel {
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupId { get; set; }

                }
                public string RegionId { get; set; }
                public bool? IoOptimized { get; set; }
                public int? Cpu { get; set; }
                public DescribeInstancesResponseBodyInstancesInstanceRdmaIpAddress RdmaIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceRdmaIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }
                public string ExpiredTime { get; set; }
                public int? LocalStorageAmount { get; set; }
                public string ResourceGroupId { get; set; }
                public string InstanceTypeFamily { get; set; }
                public string ISP { get; set; }
                public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfaces NetworkInterfaces { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfaces : TeaModel {
                    [NameInMap("NetworkInterface")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterface> NetworkInterface { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterface : TeaModel {
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
                        public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6Sets Ipv6Sets { get; set; }
                        public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6Sets : TeaModel {
                            [NameInMap("Ipv6Set")]
                            [Validation(Required=false)]
                            public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6SetsIpv6Set> Ipv6Set { get; set; }
                            public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6SetsIpv6Set : TeaModel {
                                public string Ipv6Address { get; set; }
                            }
                        };

                        [NameInMap("PrimaryIpAddress")]
                        [Validation(Required=false)]
                        public string PrimaryIpAddress { get; set; }

                        [NameInMap("PrivateIpSets")]
                        [Validation(Required=false)]
                        public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacePrivateIpSets PrivateIpSets { get; set; }
                        public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacePrivateIpSets : TeaModel {
                            [NameInMap("PrivateIpSet")]
                            [Validation(Required=false)]
                            public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacePrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
                            public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacePrivateIpSetsPrivateIpSet : TeaModel {
                                public bool? Primary { get; set; }
                                public string PrivateIpAddress { get; set; }
                            }
                        };

                    }

                }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
