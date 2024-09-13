// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// The returned service code. 0 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned instance information. It is an array that consists of InstanceAttributesType data.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeInstancesResponseBodyInstancesInstance : TeaModel {
                /// <summary>
                /// The automatic release time of the instance.
                /// </summary>
                [NameInMap("AutoReleaseTime")]
                [Validation(Required=false)]
                public string AutoReleaseTime { get; set; }

                /// <summary>
                /// The number of vCPUs.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                /// <summary>
                /// The time when the instance was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// Details of the data disk.
                /// </summary>
                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceDataDisk DataDisk { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceDataDisk : TeaModel {
                    [NameInMap("DataDisk")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceDataDiskDataDisk> DataDisk { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceDataDiskDataDisk : TeaModel {
                        /// <summary>
                        /// The category of the cloud disk or local disk. Valid values:
                        /// 
                        /// *   **file**: local disk.
                        /// *   **pangu**: ultra disk.
                        /// *   **local_hdd**: local HDD.
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// The ID of the disk.
                        /// </summary>
                        [NameInMap("DiskId")]
                        [Validation(Required=false)]
                        public string DiskId { get; set; }

                        /// <summary>
                        /// The name of the disk.
                        /// </summary>
                        [NameInMap("DiskName")]
                        [Validation(Required=false)]
                        public string DiskName { get; set; }

                        /// <summary>
                        /// The size of the disk. Unit: GiB.
                        /// </summary>
                        [NameInMap("DiskSize")]
                        [Validation(Required=false)]
                        public int? DiskSize { get; set; }

                        [NameInMap("EncryptKeyId")]
                        [Validation(Required=false)]
                        public string EncryptKeyId { get; set; }

                        [NameInMap("Encrypted")]
                        [Validation(Required=false)]
                        public bool? Encrypted { get; set; }

                        /// <summary>
                        /// The size of the disk. Unit: MiB.
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                        /// <summary>
                        /// The extended field of the disk category. Valid values:
                        /// 
                        /// *   **file**: local disk.
                        /// *   **pangu**: ultra disk.
                        /// *   **local_hdd**: local HDD.
                        /// </summary>
                        [NameInMap("device_type")]
                        [Validation(Required=false)]
                        public string DeviceType { get; set; }

                        /// <summary>
                        /// The type of the cloud disk or local disk. Valid values:
                        /// 
                        /// **system**: system disk. **data**: data disk.
                        /// </summary>
                        [NameInMap("disk_type")]
                        [Validation(Required=false)]
                        public string DiskType { get; set; }

                        /// <summary>
                        /// The name of the disk.
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The size of the disk. Unit: MiB.
                        /// </summary>
                        [NameInMap("storage")]
                        [Validation(Required=false)]
                        public int? Storage { get; set; }

                        /// <summary>
                        /// The UUID of the disk.
                        /// </summary>
                        [NameInMap("uuid")]
                        [Validation(Required=false)]
                        public string Uuid { get; set; }

                    }

                }

                /// <summary>
                /// The total size of the disk. Unit: MiB.
                /// </summary>
                [NameInMap("Disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// The expiration time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The hostname of the instance.
                /// 
                /// *   The hostname cannot start or end with a period (.) or hyphen (-). It cannot contain consecutive periods (.) or hyphens (-).
                /// *   For a Windows instance, the hostname must be 2 to 15 characters in length and can contain letters, digits, and hyphens (-). The hostname cannot contain periods (.) or contain only digits.
                /// *   For an instance that runs another operating system such as Linux, the hostname must be 2 to 64 characters in length. You can use periods (.) to separate the hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// The ID of the image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The private IP addresses of the instances.
                /// </summary>
                [NameInMap("InnerIpAddress")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceInnerIpAddress InnerIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceInnerIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The category of the instance. Valid values:
                /// 
                /// *   EnsInstance: ENS instances that you purchase.
                /// *   EnsService: ENS instances that belong to edge services.
                /// *   BuildMachine: ENS instances that are configured with image builders.
                /// *   EnsPostPaidInstance: pay-as-you-go ENS instances that you purchase.
                /// </summary>
                [NameInMap("InstanceResourceType")]
                [Validation(Required=false)]
                public string InstanceResourceType { get; set; }

                /// <summary>
                /// The instance family. Valid values:
                /// 
                /// *   x86_vm: x86-based computing instance.
                /// *   x86_pm: x86-based physical machine.
                /// *   x86_bmi: x86-based bare metal instance.
                /// *   x86_bm: bare metal instance with the SmartNIC.
                /// *   pc_bmi: heterogeneous bare metal instance.
                /// *   pc_vm: heterogeneous virtual machine.
                /// *   arm_bmi: Arm-based computing instance.
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// The maximum outbound bandwidth. Unit: Mbit/s.
                /// </summary>
                [NameInMap("InternetMaxBandwidthIn")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthIn { get; set; }

                /// <summary>
                /// The minimum inbound bandwidth. Unit: Mbit/s.
                /// </summary>
                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

                /// <summary>
                /// The memory size. Unit: MB.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// Details of the network.
                /// </summary>
                [NameInMap("NetworkAttributes")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceNetworkAttributes NetworkAttributes { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceNetworkAttributes : TeaModel {
                    /// <summary>
                    /// The ID of the network.
                    /// </summary>
                    [NameInMap("NetworkId")]
                    [Validation(Required=false)]
                    public string NetworkId { get; set; }

                    /// <summary>
                    /// Details of the private IP addresses.
                    /// </summary>
                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public DescribeInstancesResponseBodyInstancesInstanceNetworkAttributesPrivateIpAddress PrivateIpAddress { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceNetworkAttributesPrivateIpAddress : TeaModel {
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public List<string> IpAddress { get; set; }

                    }

                    /// <summary>
                    /// The vSwitch ID.
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// The name of the image.
                /// </summary>
                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                /// <summary>
                /// Details of the private IP addresses.
                /// </summary>
                [NameInMap("PrivateIpAddresses")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstancePrivateIpAddresses PrivateIpAddresses { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstancePrivateIpAddresses : TeaModel {
                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstancePrivateIpAddressesPrivateIpAddress> PrivateIpAddress { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstancePrivateIpAddressesPrivateIpAddress : TeaModel {
                        /// <summary>
                        /// The gateway.
                        /// </summary>
                        [NameInMap("GateWay")]
                        [Validation(Required=false)]
                        public string GateWay { get; set; }

                        /// <summary>
                        /// The IP address.
                        /// </summary>
                        [NameInMap("Ip")]
                        [Validation(Required=false)]
                        public string Ip { get; set; }

                        /// <summary>
                        /// The ISP.
                        /// </summary>
                        [NameInMap("Isp")]
                        [Validation(Required=false)]
                        public string Isp { get; set; }

                    }

                }

                /// <summary>
                /// The public IP addresses of the instances.
                /// </summary>
                [NameInMap("PublicIpAddress")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstancePublicIpAddress PublicIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstancePublicIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }

                /// <summary>
                /// Details of the public IP addresses.
                /// </summary>
                [NameInMap("PublicIpAddresses")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstancePublicIpAddresses PublicIpAddresses { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstancePublicIpAddresses : TeaModel {
                    [NameInMap("PublicIpAddress")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstancePublicIpAddressesPublicIpAddress> PublicIpAddress { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstancePublicIpAddressesPublicIpAddress : TeaModel {
                        /// <summary>
                        /// The gateway.
                        /// </summary>
                        [NameInMap("GateWay")]
                        [Validation(Required=false)]
                        public string GateWay { get; set; }

                        /// <summary>
                        /// The IP address.
                        /// </summary>
                        [NameInMap("Ip")]
                        [Validation(Required=false)]
                        public string Ip { get; set; }

                        /// <summary>
                        /// The Internet service provider (ISP).
                        /// </summary>
                        [NameInMap("Isp")]
                        [Validation(Required=false)]
                        public string Isp { get; set; }

                    }

                }

                /// <summary>
                /// The IDs of the security groups.
                /// </summary>
                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceSecurityGroupIds SecurityGroupIds { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceSecurityGroupIds : TeaModel {
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupId { get; set; }

                }

                /// <summary>
                /// The instance type.
                /// </summary>
                [NameInMap("SpecName")]
                [Validation(Required=false)]
                public string SpecName { get; set; }

                /// <summary>
                /// The bidding policy of the preemptible instance.
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// The status of the instance. Valid values:
                /// 
                /// *   Running
                /// *   Expired
                /// *   Stopped
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// Details of the system disk.
                /// </summary>
                [NameInMap("SystemDisk")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceSystemDisk SystemDisk { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceSystemDisk : TeaModel {
                    /// <summary>
                    /// The category of the cloud disk or local disk. Valid values:
                    /// 
                    /// *   **file**: local disk.
                    /// *   **pangu**: ultra disk.
                    /// *   **local_hdd**: local HDD.
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// The ID of the disk.
                    /// </summary>
                    [NameInMap("DiskId")]
                    [Validation(Required=false)]
                    public string DiskId { get; set; }

                    /// <summary>
                    /// The name of the disk.
                    /// </summary>
                    [NameInMap("DiskName")]
                    [Validation(Required=false)]
                    public string DiskName { get; set; }

                    /// <summary>
                    /// The size of the disk. Unit: MiB.
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                    /// <summary>
                    /// The extended field of the disk category. Valid values:
                    /// 
                    /// *   **file**: local disk.
                    /// *   **pangu**: ultra disk.
                    /// *   **local_hdd**: local HDD.
                    /// </summary>
                    [NameInMap("device_type")]
                    [Validation(Required=false)]
                    public string DeviceType { get; set; }

                    /// <summary>
                    /// The type of the cloud disk or local disk. Valid values:
                    /// 
                    /// *   **system**: system disk.
                    /// *   **data**: data disk.
                    /// </summary>
                    [NameInMap("disk_type")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    /// <summary>
                    /// The name of the disk.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The size of the disk. Unit: MiB.
                    /// </summary>
                    [NameInMap("storage")]
                    [Validation(Required=false)]
                    public int? Storage { get; set; }

                    /// <summary>
                    /// The UUID of the disk.
                    /// </summary>
                    [NameInMap("uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                }

                /// <summary>
                /// The tags of the instance.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceTags Tags { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceTags : TeaModel {
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceTagsTags> Tags { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceTagsTags : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
