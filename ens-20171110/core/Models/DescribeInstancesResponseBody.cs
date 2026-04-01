// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned service code. 0 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

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

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceDataDisk DataDisk { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceDataDisk : TeaModel {
                    [NameInMap("DataDisk")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceDataDiskDataDisk> DataDisk { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceDataDiskDataDisk : TeaModel {
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        [NameInMap("DiskId")]
                        [Validation(Required=false)]
                        public string DiskId { get; set; }

                        [NameInMap("DiskName")]
                        [Validation(Required=false)]
                        public string DiskName { get; set; }

                        [NameInMap("DiskSize")]
                        [Validation(Required=false)]
                        public int? DiskSize { get; set; }

                        [NameInMap("EncryptKeyId")]
                        [Validation(Required=false)]
                        public string EncryptKeyId { get; set; }

                        [NameInMap("Encrypted")]
                        [Validation(Required=false)]
                        public bool? Encrypted { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                        [NameInMap("device_type")]
                        [Validation(Required=false)]
                        public string DeviceType { get; set; }

                        [NameInMap("disk_type")]
                        [Validation(Required=false)]
                        public string DiskType { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("storage")]
                        [Validation(Required=false)]
                        public int? Storage { get; set; }

                        [NameInMap("uuid")]
                        [Validation(Required=false)]
                        public string Uuid { get; set; }

                    }

                }

                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                [NameInMap("Disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("InnerIpAddress")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceInnerIpAddress InnerIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceInnerIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceResourceType")]
                [Validation(Required=false)]
                public string InstanceResourceType { get; set; }

                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                [NameInMap("InternetMaxBandwidthIn")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthIn { get; set; }

                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                [NameInMap("NetworkAttributes")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceNetworkAttributes NetworkAttributes { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceNetworkAttributes : TeaModel {
                    [NameInMap("NetworkId")]
                    [Validation(Required=false)]
                    public string NetworkId { get; set; }

                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public DescribeInstancesResponseBodyInstancesInstanceNetworkAttributesPrivateIpAddress PrivateIpAddress { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceNetworkAttributesPrivateIpAddress : TeaModel {
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public List<string> IpAddress { get; set; }

                    }

                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                [NameInMap("NetworkInterfaces")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfaces NetworkInterfaces { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfaces : TeaModel {
                    [NameInMap("NetworkInterfaces")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaces> NetworkInterfaces { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaces : TeaModel {
                        [NameInMap("Ipv6Sets")]
                        [Validation(Required=false)]
                        public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesIpv6Sets Ipv6Sets { get; set; }
                        public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesIpv6Sets : TeaModel {
                            [NameInMap("Ipv6Set")]
                            [Validation(Required=false)]
                            public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesIpv6SetsIpv6Set> Ipv6Set { get; set; }
                            public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesIpv6SetsIpv6Set : TeaModel {
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
                        public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesPrivateIpSets PrivateIpSets { get; set; }
                        public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesPrivateIpSets : TeaModel {
                            [NameInMap("PrivateIpSet")]
                            [Validation(Required=false)]
                            public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesPrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
                            public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesPrivateIpSetsPrivateIpSet : TeaModel {
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

                [NameInMap("PrivateIpAddresses")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstancePrivateIpAddresses PrivateIpAddresses { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstancePrivateIpAddresses : TeaModel {
                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstancePrivateIpAddressesPrivateIpAddress> PrivateIpAddress { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstancePrivateIpAddressesPrivateIpAddress : TeaModel {
                        [NameInMap("GateWay")]
                        [Validation(Required=false)]
                        public string GateWay { get; set; }

                        [NameInMap("Ip")]
                        [Validation(Required=false)]
                        public string Ip { get; set; }

                        [NameInMap("Isp")]
                        [Validation(Required=false)]
                        public string Isp { get; set; }

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

                [NameInMap("PublicIpAddresses")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstancePublicIpAddresses PublicIpAddresses { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstancePublicIpAddresses : TeaModel {
                    [NameInMap("PublicIpAddress")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstancePublicIpAddressesPublicIpAddress> PublicIpAddress { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstancePublicIpAddressesPublicIpAddress : TeaModel {
                        [NameInMap("GateWay")]
                        [Validation(Required=false)]
                        public string GateWay { get; set; }

                        [NameInMap("Ip")]
                        [Validation(Required=false)]
                        public string Ip { get; set; }

                        [NameInMap("Isp")]
                        [Validation(Required=false)]
                        public string Isp { get; set; }

                    }

                }

                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceSecurityGroupIds SecurityGroupIds { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceSecurityGroupIds : TeaModel {
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupId { get; set; }

                }

                [NameInMap("ServiceStatus")]
                [Validation(Required=false)]
                public string ServiceStatus { get; set; }

                [NameInMap("SpecName")]
                [Validation(Required=false)]
                public string SpecName { get; set; }

                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SystemDisk")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceSystemDisk SystemDisk { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceSystemDisk : TeaModel {
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("DiskId")]
                    [Validation(Required=false)]
                    public string DiskId { get; set; }

                    [NameInMap("DiskName")]
                    [Validation(Required=false)]
                    public string DiskName { get; set; }

                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                    [NameInMap("device_type")]
                    [Validation(Required=false)]
                    public string DeviceType { get; set; }

                    [NameInMap("disk_type")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("storage")]
                    [Validation(Required=false)]
                    public int? Storage { get; set; }

                    [NameInMap("uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceTags Tags { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceTags : TeaModel {
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceTagsTags> Tags { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceTagsTags : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

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
        /// <para>60</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
