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

        /// <summary>
        /// <para>The information about the instance is returned in an array of InstanceAttributesType.</para>
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
                /// <para>The automatic release time of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-06-28T14:38:52Z</para>
                /// </summary>
                [NameInMap("AutoReleaseTime")]
                [Validation(Required=false)]
                public string AutoReleaseTime { get; set; }

                /// <summary>
                /// <para>The number of vCPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                /// <summary>
                /// <para>The time when the instance was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-07-26T06:40:43Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>Details of the data disk.</para>
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
                        /// <para>The category of the cloud disk or local disk. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>file</b>: local disk.</description></item>
                        /// <item><description><b>pangu</b>: ultra disk.</description></item>
                        /// <item><description><b>local_hdd</b>: local HDD.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>file</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <para>The ID of the disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>d-5ip4c2dhmas0vjd5u1r****</para>
                        /// </summary>
                        [NameInMap("DiskId")]
                        [Validation(Required=false)]
                        public string DiskId { get; set; }

                        /// <summary>
                        /// <para>The name of the disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DiskName</para>
                        /// </summary>
                        [NameInMap("DiskName")]
                        [Validation(Required=false)]
                        public string DiskName { get; set; }

                        /// <summary>
                        /// <para>The size of the disk. Unit: GiB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("DiskSize")]
                        [Validation(Required=false)]
                        public int? DiskSize { get; set; }

                        /// <summary>
                        /// <para>The KMS key ID used by the cloud drive.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0e478b7a-4262-4802-b8cb-00d3fxxxxx</para>
                        /// </summary>
                        [NameInMap("EncryptKeyId")]
                        [Validation(Required=false)]
                        public string EncryptKeyId { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to encrypt the disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Encrypted")]
                        [Validation(Required=false)]
                        public bool? Encrypted { get; set; }

                        /// <summary>
                        /// <para>The size of the disk. Unit: MiB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>51200</para>
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                        /// <summary>
                        /// <para>The extended field of the disk category. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>file</b>: local disk.</description></item>
                        /// <item><description><b>pangu</b>: ultra disk.</description></item>
                        /// <item><description><b>local_hdd</b>: local HDD.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pangu</para>
                        /// </summary>
                        [NameInMap("device_type")]
                        [Validation(Required=false)]
                        public string DeviceType { get; set; }

                        /// <summary>
                        /// <para>The type of the cloud disk or local disk. Valid values:</para>
                        /// <para><b>system</b>: system disk. <b>data</b>: data disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>system</para>
                        /// </summary>
                        [NameInMap("disk_type")]
                        [Validation(Required=false)]
                        public string DiskType { get; set; }

                        /// <summary>
                        /// <para>The name of the disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The size of the disk. Unit: MiB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20480</para>
                        /// </summary>
                        [NameInMap("storage")]
                        [Validation(Required=false)]
                        public int? Storage { get; set; }

                        /// <summary>
                        /// <para>The UUID of the disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>d-5itef1wtxj961mbff8xe9****</para>
                        /// </summary>
                        [NameInMap("uuid")]
                        [Validation(Required=false)]
                        public string Uuid { get; set; }

                    }

                }

                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// <para>The total size of the disk. Unit: MiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>71680</para>
                /// </summary>
                [NameInMap("Disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-telecom</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <para>The expiration time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2119-07-13T02:38:57Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The hostname of the instance.</para>
                /// <list type="bullet">
                /// <item><description>The hostname cannot start or end with a period (.) or hyphen (-). It cannot contain consecutive periods (.) or hyphens (-).</description></item>
                /// <item><description>For a Windows instance, the hostname must be 2 to 15 characters in length and can contain letters, digits, and hyphens (-). The hostname cannot contain periods (.) or contain only digits.</description></item>
                /// <item><description>For an instance that runs another operating system such as Linux, the hostname must be 2 to 64 characters in length. You can use periods (.) to separate the hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>testHostName</para>
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// <para>The ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The private IP addresses of the instances.</para>
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
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-instanc****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-5itef0f28t17bcdw9deu6meub</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The category of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>EnsInstance: ENS instances that you purchase.</description></item>
                /// <item><description>EnsService: ENS instances that belong to edge services.</description></item>
                /// <item><description>BuildMachine: ENS instances that are configured with image builders.</description></item>
                /// <item><description>EnsPostPaidInstance: pay-as-you-go ENS instances that you purchase.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EnsService</para>
                /// </summary>
                [NameInMap("InstanceResourceType")]
                [Validation(Required=false)]
                public string InstanceResourceType { get; set; }

                /// <summary>
                /// <para>The instance family. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>x86_vm: x86-based computing instance.</description></item>
                /// <item><description>x86_pm: x86-based physical machine.</description></item>
                /// <item><description>x86_bmi: x86-based bare metal instance.</description></item>
                /// <item><description>x86_bm: bare metal instance with the SmartNIC.</description></item>
                /// <item><description>pc_bmi: heterogeneous bare metal instance.</description></item>
                /// <item><description>pc_vm: heterogeneous virtual machine.</description></item>
                /// <item><description>arm_bmi: Arm-based computing instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>x86_vm</para>
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// <para>The maximum outbound bandwidth. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("InternetMaxBandwidthIn")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthIn { get; set; }

                /// <summary>
                /// <para>The minimum inbound bandwidth. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                /// <summary>
                /// <para>The name of the SSH key pair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>terraform-example</para>
                /// </summary>
                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

                /// <summary>
                /// <para>The memory size. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// <para>Details of the network.</para>
                /// </summary>
                [NameInMap("NetworkAttributes")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceNetworkAttributes NetworkAttributes { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceNetworkAttributes : TeaModel {
                    /// <summary>
                    /// <para>The ID of the network.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>n-2zeuphj08tt7q3brd****</para>
                    /// </summary>
                    [NameInMap("NetworkId")]
                    [Validation(Required=false)]
                    public string NetworkId { get; set; }

                    /// <summary>
                    /// <para>Details of the private IP addresses.</para>
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
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-2zeh0r1pabwtg6wcs****</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// <para>The ENI attached to the instance.</para>
                /// </summary>
                [NameInMap("NetworkInterfaces")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfaces NetworkInterfaces { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfaces : TeaModel {
                    [NameInMap("NetworkInterfaces")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaces> NetworkInterfaces { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaces : TeaModel {
                        /// <summary>
                        /// <para>The IPv6 addresses of the ENI. This parameter has a value only when <c>AdditionalAttributes.N</c> is set to <c>NETWORK_PRIMARY_ENI_IP</c>.</para>
                        /// </summary>
                        [NameInMap("Ipv6Sets")]
                        [Validation(Required=false)]
                        public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesIpv6Sets Ipv6Sets { get; set; }
                        public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesIpv6Sets : TeaModel {
                            [NameInMap("Ipv6Set")]
                            [Validation(Required=false)]
                            public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesIpv6SetsIpv6Set> Ipv6Set { get; set; }
                            public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesIpv6SetsIpv6Set : TeaModel {
                                /// <summary>
                                /// <para>IPv6 addresses N of the ENI. You can specify multiple IPv6 addresses. Valid values of N: 1 to 100.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2408:4005:396:3200:****:6609:821e:df7a</para>
                                /// </summary>
                                [NameInMap("Ipv6Address")]
                                [Validation(Required=false)]
                                public string Ipv6Address { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The MAC address of the ENI.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>00:16:3e:4f:5f:ca</para>
                        /// </summary>
                        [NameInMap("MacAddress")]
                        [Validation(Required=false)]
                        public string MacAddress { get; set; }

                        /// <summary>
                        /// <para>The ID of the ENI.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eni-0wlonoy6jo8532gfzuama****</para>
                        /// </summary>
                        [NameInMap("NetworkInterfaceId")]
                        [Validation(Required=false)]
                        public string NetworkInterfaceId { get; set; }

                        /// <summary>
                        /// <para>The primary IP address of the ENI.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("PrimaryIpAddress")]
                        [Validation(Required=false)]
                        public string PrimaryIpAddress { get; set; }

                        /// <summary>
                        /// <para>The private IP addresses of the ENI.</para>
                        /// </summary>
                        [NameInMap("PrivateIpSets")]
                        [Validation(Required=false)]
                        public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesPrivateIpSets PrivateIpSets { get; set; }
                        public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesPrivateIpSets : TeaModel {
                            [NameInMap("PrivateIpSet")]
                            [Validation(Required=false)]
                            public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesPrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
                            public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacesPrivateIpSetsPrivateIpSet : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether the IP address is the primary private IP address. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true</description></item>
                                /// <item><description>false</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("Primary")]
                                [Validation(Required=false)]
                                public bool? Primary { get; set; }

                                /// <summary>
                                /// <para>The private IP address.</para>
                                /// <remarks>
                                /// <para> This parameter is available only if ScheduleAreaLevel is set to Region and cannot be configured if ScheduleAreaLevel is set to other values. Otherwise, an error occurs. If you specify a private IP address, the number of instances must be 1. The private IP address takes effect only when the private IP address and the vSwitch ID are not empty.</para>
                                /// </remarks>
                                /// 
                                /// <b>Example:</b>
                                /// <para>10.75.66.***</para>
                                /// </summary>
                                [NameInMap("PrivateIpAddress")]
                                [Validation(Required=false)]
                                public string PrivateIpAddress { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The type of the disk. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>system: system disk.</description></item>
                        /// <item><description>data: data disk.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Secondary</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos 6.8 x86_64</para>
                /// </summary>
                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                /// <summary>
                /// <para>Details of the private IP addresses.</para>
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
                        /// <para>The gateway.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>119.147.xx.xx</para>
                        /// </summary>
                        [NameInMap("GateWay")]
                        [Validation(Required=false)]
                        public string GateWay { get; set; }

                        /// <summary>
                        /// <para>The IP address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>119.147.xx.xx</para>
                        /// </summary>
                        [NameInMap("Ip")]
                        [Validation(Required=false)]
                        public string Ip { get; set; }

                        /// <summary>
                        /// <para>The ISP.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cmcc</para>
                        /// </summary>
                        [NameInMap("Isp")]
                        [Validation(Required=false)]
                        public string Isp { get; set; }

                    }

                }

                /// <summary>
                /// <para>The public IP addresses of the instances.</para>
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
                /// <para>Details of the public IP addresses.</para>
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
                        /// <para>The gateway.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>119.147.xx.xx</para>
                        /// </summary>
                        [NameInMap("GateWay")]
                        [Validation(Required=false)]
                        public string GateWay { get; set; }

                        /// <summary>
                        /// <para>The IP address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>119.147.xx.xx</para>
                        /// </summary>
                        [NameInMap("Ip")]
                        [Validation(Required=false)]
                        public string Ip { get; set; }

                        /// <summary>
                        /// <para>The Internet service provider (ISP).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>unicom</para>
                        /// </summary>
                        [NameInMap("Isp")]
                        [Validation(Required=false)]
                        public string Isp { get; set; }

                    }

                }

                /// <summary>
                /// <para>The IDs of the security groups.</para>
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
                /// <para>The ID of your Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deleting</para>
                /// </summary>
                [NameInMap("ServiceStatus")]
                [Validation(Required=false)]
                public string ServiceStatus { get; set; }

                /// <summary>
                /// <para>The instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ens.sn1.stiny</para>
                /// </summary>
                [NameInMap("SpecName")]
                [Validation(Required=false)]
                public string SpecName { get; set; }

                /// <summary>
                /// <para>The bidding policy of the preemptible instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// <para>The status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Running</description></item>
                /// <item><description>Expired</description></item>
                /// <item><description>Stopped</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Details of the system disk.</para>
                /// </summary>
                [NameInMap("SystemDisk")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceSystemDisk SystemDisk { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceSystemDisk : TeaModel {
                    /// <summary>
                    /// <para>The category of the cloud disk or local disk. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>file</b>: local disk.</description></item>
                    /// <item><description><b>pangu</b>: ultra disk.</description></item>
                    /// <item><description><b>local_hdd</b>: local HDD.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>file</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The ID of the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>d-5ip4c2dhmas0rn7rt0p9****</para>
                    /// </summary>
                    [NameInMap("DiskId")]
                    [Validation(Required=false)]
                    public string DiskId { get; set; }

                    /// <summary>
                    /// <para>The name of the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DiskName</para>
                    /// </summary>
                    [NameInMap("DiskName")]
                    [Validation(Required=false)]
                    public string DiskName { get; set; }

                    /// <summary>
                    /// <para>The size of the disk. Unit: MiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>51200</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                    /// <summary>
                    /// <para>The extended field of the disk category. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>file</b>: local disk.</description></item>
                    /// <item><description><b>pangu</b>: ultra disk.</description></item>
                    /// <item><description><b>local_hdd</b>: local HDD.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pangu</para>
                    /// </summary>
                    [NameInMap("device_type")]
                    [Validation(Required=false)]
                    public string DeviceType { get; set; }

                    /// <summary>
                    /// <para>The type of the cloud disk or local disk. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>system</b>: system disk.</description></item>
                    /// <item><description><b>data</b>: data disk.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>system</para>
                    /// </summary>
                    [NameInMap("disk_type")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    /// <summary>
                    /// <para>The name of the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DiskName</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The size of the disk. Unit: MiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20480</para>
                    /// </summary>
                    [NameInMap("storage")]
                    [Validation(Required=false)]
                    public int? Storage { get; set; }

                    /// <summary>
                    /// <para>The UUID of the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>d-5ip4c2dhmas0rn7rt0p96****</para>
                    /// </summary>
                    [NameInMap("uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                }

                /// <summary>
                /// <para>The tags of the instance.</para>
                /// <remarks>
                /// <para> This operation does not return tag information. You can call this operation in combination with the tag-related operations.</para>
                /// </remarks>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key1</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>value1</para>
                        /// </summary>
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
