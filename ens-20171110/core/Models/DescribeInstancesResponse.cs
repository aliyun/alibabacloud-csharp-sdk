// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstancesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=true)]
        public DescribeInstancesResponseInstances Instances { get; set; }
        public class DescribeInstancesResponseInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=true)]
            public List<DescribeInstancesResponseInstancesInstance> Instance { get; set; }
            public class DescribeInstancesResponseInstancesInstance : TeaModel {
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public string EnsRegionId { get; set; }
                public string Cpu { get; set; }
                public int? Memory { get; set; }
                public int? Disk { get; set; }
                public int? InternetMaxBandwidthIn { get; set; }
                public int? InternetMaxBandwidthOut { get; set; }
                public string CreationTime { get; set; }
                public string Status { get; set; }
                public string HostName { get; set; }
                public string ImageId { get; set; }
                public string ExpiredTime { get; set; }
                public string InstanceResourceType { get; set; }
                public string SpecName { get; set; }
                public string OSName { get; set; }
                public DescribeInstancesResponseInstancesInstanceDataDisk DataDisk { get; set; }
                public class DescribeInstancesResponseInstancesInstanceDataDisk : TeaModel {
                    [NameInMap("DataDisk")]
                    [Validation(Required=true)]
                    public List<DescribeInstancesResponseInstancesInstanceDataDiskDataDisk> DataDisk { get; set; }
                    public class DescribeInstancesResponseInstancesInstanceDataDiskDataDisk : TeaModel {
                        [NameInMap("device_type")]
                        [Validation(Required=true)]
                        public string DeviceType { get; set; }

                        [NameInMap("storage")]
                        [Validation(Required=true)]
                        public int? Storage { get; set; }

                        [NameInMap("uuid")]
                        [Validation(Required=true)]
                        public string Uuid { get; set; }

                        [NameInMap("disk_type")]
                        [Validation(Required=true)]
                        public string DiskType { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=true)]
                        public string Name { get; set; }

                        [NameInMap("Category")]
                        [Validation(Required=true)]
                        public string Category { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=true)]
                        public int? Size { get; set; }

                        [NameInMap("DiskId")]
                        [Validation(Required=true)]
                        public string DiskId { get; set; }

                        [NameInMap("DiskName")]
                        [Validation(Required=true)]
                        public string DiskName { get; set; }

                    }

                }
                public DescribeInstancesResponseInstancesInstancePublicIpAddresses PublicIpAddresses { get; set; }
                public class DescribeInstancesResponseInstancesInstancePublicIpAddresses : TeaModel {
                    [NameInMap("PublicIpAddress")]
                    [Validation(Required=true)]
                    public List<DescribeInstancesResponseInstancesInstancePublicIpAddressesPublicIpAddress> PublicIpAddress { get; set; }
                    public class DescribeInstancesResponseInstancesInstancePublicIpAddressesPublicIpAddress : TeaModel {
                        [NameInMap("Ip")]
                        [Validation(Required=true)]
                        public string Ip { get; set; }

                        [NameInMap("GateWay")]
                        [Validation(Required=true)]
                        public string GateWay { get; set; }

                        [NameInMap("Isp")]
                        [Validation(Required=true)]
                        public string Isp { get; set; }

                    }

                }
                public DescribeInstancesResponseInstancesInstancePrivateIpAddresses PrivateIpAddresses { get; set; }
                public class DescribeInstancesResponseInstancesInstancePrivateIpAddresses : TeaModel {
                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=true)]
                    public List<DescribeInstancesResponseInstancesInstancePrivateIpAddressesPrivateIpAddress> PrivateIpAddress { get; set; }
                    public class DescribeInstancesResponseInstancesInstancePrivateIpAddressesPrivateIpAddress : TeaModel {
                        [NameInMap("Ip")]
                        [Validation(Required=true)]
                        public string Ip { get; set; }

                        [NameInMap("GateWay")]
                        [Validation(Required=true)]
                        public string GateWay { get; set; }

                        [NameInMap("Isp")]
                        [Validation(Required=true)]
                        public string Isp { get; set; }

                    }

                }
                public DescribeInstancesResponseInstancesInstanceSystemDisk SystemDisk { get; set; }
                public class DescribeInstancesResponseInstancesInstanceSystemDisk : TeaModel {
                    [NameInMap("device_type")]
                    [Validation(Required=true)]
                    public string DeviceType { get; set; }

                    [NameInMap("storage")]
                    [Validation(Required=true)]
                    public int? Storage { get; set; }

                    [NameInMap("uuid")]
                    [Validation(Required=true)]
                    public string Uuid { get; set; }

                    [NameInMap("disk_type")]
                    [Validation(Required=true)]
                    public string DiskType { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("Category")]
                    [Validation(Required=true)]
                    public string Category { get; set; }

                    [NameInMap("Size")]
                    [Validation(Required=true)]
                    public int? Size { get; set; }

                    [NameInMap("DiskId")]
                    [Validation(Required=true)]
                    public string DiskId { get; set; }

                    [NameInMap("DiskName")]
                    [Validation(Required=true)]
                    public string DiskName { get; set; }

                }
                public DescribeInstancesResponseInstancesInstanceSecurityGroupIds SecurityGroupIds { get; set; }
                public class DescribeInstancesResponseInstancesInstanceSecurityGroupIds : TeaModel {
                    /// <summary>
                    /// SecurityGroupId
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=true)]
                    public List<string> SecurityGroupId { get; set; }

                }
                public DescribeInstancesResponseInstancesInstanceInnerIpAddress InnerIpAddress { get; set; }
                public class DescribeInstancesResponseInstancesInstanceInnerIpAddress : TeaModel {
                    /// <summary>
                    /// IpAddress
                    /// </summary>
                    [NameInMap("IpAddress")]
                    [Validation(Required=true)]
                    public List<string> IpAddress { get; set; }

                }
                public DescribeInstancesResponseInstancesInstancePublicIpAddress PublicIpAddress { get; set; }
                public class DescribeInstancesResponseInstancesInstancePublicIpAddress : TeaModel {
                    /// <summary>
                    /// IpAddress
                    /// </summary>
                    [NameInMap("IpAddress")]
                    [Validation(Required=true)]
                    public List<string> IpAddress { get; set; }

                }
            }
        };

    }

}
