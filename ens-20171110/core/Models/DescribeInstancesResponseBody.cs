// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
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
                public string Cpu { get; set; }
                public string CreationTime { get; set; }
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
                public int? Disk { get; set; }
                public string EnsRegionId { get; set; }
                public string ExpiredTime { get; set; }
                public string HostName { get; set; }
                public string ImageId { get; set; }
                public DescribeInstancesResponseBodyInstancesInstanceInnerIpAddress InnerIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceInnerIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public string InstanceResourceType { get; set; }
                public int? InternetMaxBandwidthIn { get; set; }
                public int? InternetMaxBandwidthOut { get; set; }
                public int? Memory { get; set; }
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
                    };

                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }
                public string OSName { get; set; }
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
                public DescribeInstancesResponseBodyInstancesInstancePublicIpAddress PublicIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstancePublicIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }
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
                public DescribeInstancesResponseBodyInstancesInstanceSecurityGroupIds SecurityGroupIds { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceSecurityGroupIds : TeaModel {
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupId { get; set; }

                }
                public string SpecName { get; set; }
                public string Status { get; set; }
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
