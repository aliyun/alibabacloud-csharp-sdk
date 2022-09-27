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
                [NameInMap("AutoReleaseTime")]
                [Validation(Required=false)]
                public string AutoReleaseTime { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("CpuOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceCpuOptions CpuOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceCpuOptions : TeaModel {
                    [NameInMap("CoreCount")]
                    [Validation(Required=false)]
                    public int? CoreCount { get; set; }

                    [NameInMap("Numa")]
                    [Validation(Required=false)]
                    public string Numa { get; set; }

                    [NameInMap("ThreadsPerCore")]
                    [Validation(Required=false)]
                    public int? ThreadsPerCore { get; set; }

                }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("CreditSpecification")]
                [Validation(Required=false)]
                public string CreditSpecification { get; set; }

                [NameInMap("DedicatedHostAttribute")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceDedicatedHostAttribute DedicatedHostAttribute { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceDedicatedHostAttribute : TeaModel {
                    [NameInMap("DedicatedHostClusterId")]
                    [Validation(Required=false)]
                    public string DedicatedHostClusterId { get; set; }

                    [NameInMap("DedicatedHostId")]
                    [Validation(Required=false)]
                    public string DedicatedHostId { get; set; }

                    [NameInMap("DedicatedHostName")]
                    [Validation(Required=false)]
                    public string DedicatedHostName { get; set; }

                }

                [NameInMap("DedicatedInstanceAttribute")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceDedicatedInstanceAttribute DedicatedInstanceAttribute { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceDedicatedInstanceAttribute : TeaModel {
                    [NameInMap("Affinity")]
                    [Validation(Required=false)]
                    public string Affinity { get; set; }

                    [NameInMap("Tenancy")]
                    [Validation(Required=false)]
                    public string Tenancy { get; set; }

                }

                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                [NameInMap("DeploymentSetGroupNo")]
                [Validation(Required=false)]
                public int? DeploymentSetGroupNo { get; set; }

                [NameInMap("DeploymentSetId")]
                [Validation(Required=false)]
                public string DeploymentSetId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DeviceAvailable")]
                [Validation(Required=false)]
                public bool? DeviceAvailable { get; set; }

                [NameInMap("EcsCapacityReservationAttr")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceEcsCapacityReservationAttr EcsCapacityReservationAttr { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceEcsCapacityReservationAttr : TeaModel {
                    [NameInMap("CapacityReservationId")]
                    [Validation(Required=false)]
                    public string CapacityReservationId { get; set; }

                    [NameInMap("CapacityReservationPreference")]
                    [Validation(Required=false)]
                    public string CapacityReservationPreference { get; set; }

                }

                [NameInMap("EipAddress")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceEipAddress EipAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceEipAddress : TeaModel {
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public int? Bandwidth { get; set; }

                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public string IpAddress { get; set; }

                    [NameInMap("IsSupportUnassociate")]
                    [Validation(Required=false)]
                    public bool? IsSupportUnassociate { get; set; }

                }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("GPUAmount")]
                [Validation(Required=false)]
                public int? GPUAmount { get; set; }

                [NameInMap("GPUSpec")]
                [Validation(Required=false)]
                public string GPUSpec { get; set; }

                [NameInMap("HibernationOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceHibernationOptions HibernationOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceHibernationOptions : TeaModel {
                    [NameInMap("Configured")]
                    [Validation(Required=false)]
                    public bool? Configured { get; set; }

                }

                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("HpcClusterId")]
                [Validation(Required=false)]
                public string HpcClusterId { get; set; }

                [NameInMap("ISP")]
                [Validation(Required=false)]
                public string ISP { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ImageOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceImageOptions ImageOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceImageOptions : TeaModel {
                    [NameInMap("LoginAsNonRoot")]
                    [Validation(Required=false)]
                    public bool? LoginAsNonRoot { get; set; }

                }

                [NameInMap("InnerIpAddress")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceInnerIpAddress InnerIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceInnerIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

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
                public bool? IoOptimized { get; set; }

                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

                [NameInMap("LocalStorageAmount")]
                [Validation(Required=false)]
                public int? LocalStorageAmount { get; set; }

                [NameInMap("LocalStorageCapacity")]
                [Validation(Required=false)]
                public long? LocalStorageCapacity { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                [NameInMap("MetadataOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceMetadataOptions MetadataOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceMetadataOptions : TeaModel {
                    [NameInMap("HttpEndpoint")]
                    [Validation(Required=false)]
                    public string HttpEndpoint { get; set; }

                    [NameInMap("HttpPutResponseHopLimit")]
                    [Validation(Required=false)]
                    public int? HttpPutResponseHopLimit { get; set; }

                    [NameInMap("HttpTokens")]
                    [Validation(Required=false)]
                    public string HttpTokens { get; set; }

                }

                [NameInMap("NetworkInterfaces")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfaces NetworkInterfaces { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfaces : TeaModel {
                    [NameInMap("NetworkInterface")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterface> NetworkInterface { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterface : TeaModel {
                        [NameInMap("Ipv6Sets")]
                        [Validation(Required=false)]
                        public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6Sets Ipv6Sets { get; set; }
                        public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6Sets : TeaModel {
                            [NameInMap("Ipv6Set")]
                            [Validation(Required=false)]
                            public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6SetsIpv6Set> Ipv6Set { get; set; }
                            public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6SetsIpv6Set : TeaModel {
                                [NameInMap("Ipv6Address")]
                                [Validation(Required=false)]
                                public string Ipv6Address { get; set; }

                            }

                        }

                        [NameInMap("MacAddress")]
                        [Validation(Required=false)]
                        public string MacAddress { get; set; }

                        [NameInMap("NetworkInterfaceId")]
                        [Validation(Required=false)]
                        public string NetworkInterfaceId { get; set; }

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
                                [NameInMap("Primary")]
                                [Validation(Required=false)]
                                public bool? Primary { get; set; }

                                [NameInMap("PrivateIpAddress")]
                                [Validation(Required=false)]
                                public string PrivateIpAddress { get; set; }

                            }

                        }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                [NameInMap("OSNameEn")]
                [Validation(Required=false)]
                public string OSNameEn { get; set; }

                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceOperationLocks OperationLocks { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceOperationLocks : TeaModel {
                    [NameInMap("LockReason")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceOperationLocksLockReason> LockReason { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceOperationLocksLockReason : TeaModel {
                        [NameInMap("LockMsg")]
                        [Validation(Required=false)]
                        public string LockMsg { get; set; }

                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                [NameInMap("PublicIpAddress")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstancePublicIpAddress PublicIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstancePublicIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }

                [NameInMap("RdmaIpAddress")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceRdmaIpAddress RdmaIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceRdmaIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }

                [NameInMap("Recyclable")]
                [Validation(Required=false)]
                public bool? Recyclable { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SaleCycle")]
                [Validation(Required=false)]
                public string SaleCycle { get; set; }

                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceSecurityGroupIds SecurityGroupIds { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceSecurityGroupIds : TeaModel {
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupId { get; set; }

                }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                [NameInMap("SpotDuration")]
                [Validation(Required=false)]
                public int? SpotDuration { get; set; }

                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StoppedMode")]
                [Validation(Required=false)]
                public string StoppedMode { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceTags Tags { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceTagsTag> Tag { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public string VlanId { get; set; }

                [NameInMap("VpcAttributes")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceVpcAttributes VpcAttributes { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceVpcAttributes : TeaModel {
                    [NameInMap("NatIpAddress")]
                    [Validation(Required=false)]
                    public string NatIpAddress { get; set; }

                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public DescribeInstancesResponseBodyInstancesInstanceVpcAttributesPrivateIpAddress PrivateIpAddress { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceVpcAttributesPrivateIpAddress : TeaModel {
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public List<string> IpAddress { get; set; }

                    }

                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
