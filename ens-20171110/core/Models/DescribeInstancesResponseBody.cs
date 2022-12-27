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

                        /// <summary>
                        /// UUID。
                        /// </summary>
                        [NameInMap("uuid")]
                        [Validation(Required=false)]
                        public string Uuid { get; set; }

                    }

                }

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

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// Schema of Response
                /// </summary>
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

                [NameInMap("SpecName")]
                [Validation(Required=false)]
                public string SpecName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// Schema of Response
                /// </summary>
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

                    /// <summary>
                    /// UUID。
                    /// </summary>
                    [NameInMap("uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                }

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
