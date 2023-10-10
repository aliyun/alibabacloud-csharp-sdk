// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// For more information about how to define a resource group, see ResGroupEntity.
        /// </summary>
        [NameInMap("ResourceGroupList")]
        [Validation(Required=false)]
        public ListResourceGroupResponseBodyResourceGroupList ResourceGroupList { get; set; }
        public class ListResourceGroupResponseBodyResourceGroupList : TeaModel {
            [NameInMap("ResGroupEntity")]
            [Validation(Required=false)]
            public List<ListResourceGroupResponseBodyResourceGroupListResGroupEntity> ResGroupEntity { get; set; }
            public class ListResourceGroupResponseBodyResourceGroupListResGroupEntity : TeaModel {
                /// <summary>
                /// The UID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("AdminUserId")]
                [Validation(Required=false)]
                public string AdminUserId { get; set; }

                /// <summary>
                /// The time when the resource group was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The description of the resource group.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The name of the resource group.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the region where the resource group belongs.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The Server Load Balancer (SLB) instances.
                /// </summary>
                [NameInMap("SlbList")]
                [Validation(Required=false)]
                public ListResourceGroupResponseBodyResourceGroupListResGroupEntitySlbList SlbList { get; set; }
                public class ListResourceGroupResponseBodyResourceGroupListResGroupEntitySlbList : TeaModel {
                    [NameInMap("SlbEntity")]
                    [Validation(Required=false)]
                    public List<ListResourceGroupResponseBodyResourceGroupListResGroupEntitySlbListSlbEntity> SlbEntity { get; set; }
                    public class ListResourceGroupResponseBodyResourceGroupListResGroupEntitySlbListSlbEntity : TeaModel {
                        /// <summary>
                        /// The IP address of the SLB instance.
                        /// </summary>
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// The type of the IP address of the SLB instance. Valid values:
                        /// 
                        /// *   Internet: Users can connect to the SLB instance over the Internet.
                        /// *   Intranet: Users can connect to the SLB instance over the internal network.
                        /// </summary>
                        [NameInMap("AddressType")]
                        [Validation(Required=false)]
                        public string AddressType { get; set; }

                        /// <summary>
                        /// Indicates whether the SLB instance has expired. Valid values:
                        /// 
                        /// *   true: The SLB instance has expired.
                        /// *   false: The SLB instance has not expired.
                        /// </summary>
                        [NameInMap("Expired")]
                        [Validation(Required=false)]
                        public bool? Expired { get; set; }

                        /// <summary>
                        /// The ID of the group to which the SLB instance belongs.
                        /// </summary>
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public int? GroupId { get; set; }

                        /// <summary>
                        /// The network type of the SLB instance. Valid values:
                        /// 
                        /// *   Classic network
                        /// *   VPC
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// The ID of the region.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The unique ID of the SLB instance.
                        /// </summary>
                        [NameInMap("SlbId")]
                        [Validation(Required=false)]
                        public string SlbId { get; set; }

                        /// <summary>
                        /// The name of the SLB instance.
                        /// </summary>
                        [NameInMap("SlbName")]
                        [Validation(Required=false)]
                        public string SlbName { get; set; }

                        /// <summary>
                        /// The status of the SLB instance.
                        /// </summary>
                        [NameInMap("SlbStatus")]
                        [Validation(Required=false)]
                        public string SlbStatus { get; set; }

                        /// <summary>
                        /// The UID of the Alibaba Cloud account.
                        /// </summary>
                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                        /// <summary>
                        /// The ID of the VPC.
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// The ID of the vSwitch.
                        /// </summary>
                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                    }

                }

                /// <summary>
                /// The time when the resource group was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// The Elastic Compute Service (ECS) instances.
                /// </summary>
                [NameInMap("ecsList")]
                [Validation(Required=false)]
                public ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsList EcsList { get; set; }
                public class ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsList : TeaModel {
                    [NameInMap("EcsEntity")]
                    [Validation(Required=false)]
                    public List<ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntity> EcsEntity { get; set; }
                    public class ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntity : TeaModel {
                        /// <summary>
                        /// The total number of CPU cores.
                        /// </summary>
                        [NameInMap("Cpu")]
                        [Validation(Required=false)]
                        public int? Cpu { get; set; }

                        /// <summary>
                        /// The description of the ECS instance.
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// The elastic compute unit (ECU) that corresponds to the ECS instance.
                        /// </summary>
                        [NameInMap("EcuEntity")]
                        [Validation(Required=false)]
                        public ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntityEcuEntity EcuEntity { get; set; }
                        public class ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntityEcuEntity : TeaModel {
                            /// <summary>
                            /// The number of available CPUs.
                            /// </summary>
                            [NameInMap("AvailableCpu")]
                            [Validation(Required=false)]
                            public int? AvailableCpu { get; set; }

                            /// <summary>
                            /// The size of the available memory.
                            /// </summary>
                            [NameInMap("AvailableMem")]
                            [Validation(Required=false)]
                            public int? AvailableMem { get; set; }

                            /// <summary>
                            /// The total number of CPU cores.
                            /// </summary>
                            [NameInMap("Cpu")]
                            [Validation(Required=false)]
                            public int? Cpu { get; set; }

                            /// <summary>
                            /// The time when the ECU was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                            /// </summary>
                            [NameInMap("CreateTime")]
                            [Validation(Required=false)]
                            public long? CreateTime { get; set; }

                            /// <summary>
                            /// Indicates whether Docker is installed. Valid values:
                            /// 
                            /// *   true: Docker is installed.
                            /// *   false: Docker is not installed.
                            /// </summary>
                            [NameInMap("DockerEnv")]
                            [Validation(Required=false)]
                            public bool? DockerEnv { get; set; }

                            /// <summary>
                            /// The unique ID of the elastic compute unit (ECU). You can run the `dmidecode` command on the ECS instance to query the ECU ID.
                            /// </summary>
                            [NameInMap("EcuId")]
                            [Validation(Required=false)]
                            public string EcuId { get; set; }

                            /// <summary>
                            /// The time when the last heartbeat detection was performed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                            /// </summary>
                            [NameInMap("HeartbeatTime")]
                            [Validation(Required=false)]
                            public long? HeartbeatTime { get; set; }

                            /// <summary>
                            /// The ID of the instance.
                            /// </summary>
                            [NameInMap("InstanceId")]
                            [Validation(Required=false)]
                            public string InstanceId { get; set; }

                            /// <summary>
                            /// The private IP address of the ECU.
                            /// </summary>
                            [NameInMap("IpAddr")]
                            [Validation(Required=false)]
                            public string IpAddr { get; set; }

                            /// <summary>
                            /// The total size of memory. Unit: MB.
                            /// </summary>
                            [NameInMap("Mem")]
                            [Validation(Required=false)]
                            public int? Mem { get; set; }

                            /// <summary>
                            /// The name of the ECU.
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// Indicates whether the ECU is online. Valid values:
                            /// 
                            /// *   true: The ECU is online.
                            /// *   false: The ECU is offline.
                            /// </summary>
                            [NameInMap("Online")]
                            [Validation(Required=false)]
                            public bool? Online { get; set; }

                            /// <summary>
                            /// The ID of the region.
                            /// </summary>
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }

                            /// <summary>
                            /// The time when the ECU was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                            /// </summary>
                            [NameInMap("UpdateTime")]
                            [Validation(Required=false)]
                            public long? UpdateTime { get; set; }

                            /// <summary>
                            /// The ID of the user associated with the ECU.
                            /// </summary>
                            [NameInMap("UserId")]
                            [Validation(Required=false)]
                            public string UserId { get; set; }

                            /// <summary>
                            /// The ID of the VPC.
                            /// </summary>
                            [NameInMap("VpcId")]
                            [Validation(Required=false)]
                            public string VpcId { get; set; }

                            /// <summary>
                            /// The ID of the zone.
                            /// </summary>
                            [NameInMap("ZoneId")]
                            [Validation(Required=false)]
                            public string ZoneId { get; set; }

                        }

                        /// <summary>
                        /// The elastic IP address (EIP).
                        /// </summary>
                        [NameInMap("Eip")]
                        [Validation(Required=false)]
                        public string Eip { get; set; }

                        /// <summary>
                        /// Indicates whether the ECS instance has expired. Valid values:
                        /// 
                        /// *   true: The ECS instance has expired.
                        /// *   false: The ECS instance has not expired.
                        /// </summary>
                        [NameInMap("Expired")]
                        [Validation(Required=false)]
                        public bool? Expired { get; set; }

                        /// <summary>
                        /// The ID of the resource group in Enterprise Distributed Application Service (EDAS).
                        /// </summary>
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public string GroupId { get; set; }

                        /// <summary>
                        /// The name of the host.
                        /// </summary>
                        [NameInMap("HostName")]
                        [Validation(Required=false)]
                        public string HostName { get; set; }

                        /// <summary>
                        /// The private IP address.
                        /// </summary>
                        [NameInMap("InnerIp")]
                        [Validation(Required=false)]
                        public string InnerIp { get; set; }

                        /// <summary>
                        /// The ID of the ECS instance.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// The name of the ECS instance.
                        /// </summary>
                        [NameInMap("InstanceName")]
                        [Validation(Required=false)]
                        public string InstanceName { get; set; }

                        /// <summary>
                        /// The total size of memory. Unit: MB.
                        /// </summary>
                        [NameInMap("Mem")]
                        [Validation(Required=false)]
                        public int? Mem { get; set; }

                        /// <summary>
                        /// The private IP address of the ECS instance.
                        /// </summary>
                        [NameInMap("PrivateIp")]
                        [Validation(Required=false)]
                        public string PrivateIp { get; set; }

                        /// <summary>
                        /// The public IP address.
                        /// </summary>
                        [NameInMap("PublicIp")]
                        [Validation(Required=false)]
                        public string PublicIp { get; set; }

                        /// <summary>
                        /// The ID of the region.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The serial number of the ECS instance.
                        /// </summary>
                        [NameInMap("SerialNum")]
                        [Validation(Required=false)]
                        public string SerialNum { get; set; }

                        /// <summary>
                        /// The ID of the security group.
                        /// </summary>
                        [NameInMap("SgId")]
                        [Validation(Required=false)]
                        public string SgId { get; set; }

                        /// <summary>
                        /// The status of the ECS instance. Valid values:
                        /// 
                        /// *   Pending: The ECS instance is being created.
                        /// *   Running: The ECS instance is running.
                        /// *   Starting: The ECS instance is being started.
                        /// *   Stopping: The ECS instance is being stopped.
                        /// *   Stopped: The ECS instance is stopped.
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// The ID of the user account.
                        /// </summary>
                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                        /// <summary>
                        /// The VPCs.
                        /// </summary>
                        [NameInMap("VpcEntity")]
                        [Validation(Required=false)]
                        public ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntityVpcEntity VpcEntity { get; set; }
                        public class ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntityVpcEntity : TeaModel {
                            /// <summary>
                            /// The IPv4 CIDR block of the vSwitch.
                            /// </summary>
                            [NameInMap("Cidrblock")]
                            [Validation(Required=false)]
                            public string Cidrblock { get; set; }

                            /// <summary>
                            /// The description of the VPC.
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// The number of ECS instances that run in the VPC.
                            /// </summary>
                            [NameInMap("EcsNum")]
                            [Validation(Required=false)]
                            public int? EcsNum { get; set; }

                            /// <summary>
                            /// Indicates whether the VPC has expired. Valid values:
                            /// 
                            /// *   true: The VPC has expired.
                            /// *   false: The VPC has not expired.
                            /// </summary>
                            [NameInMap("Expired")]
                            [Validation(Required=false)]
                            public bool? Expired { get; set; }

                            /// <summary>
                            /// The ID of the region.
                            /// </summary>
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }

                            /// <summary>
                            /// The status of the VPC.
                            /// </summary>
                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }

                            /// <summary>
                            /// The ID of the user.
                            /// </summary>
                            [NameInMap("UserId")]
                            [Validation(Required=false)]
                            public string UserId { get; set; }

                            /// <summary>
                            /// The unique ID of the VPC.
                            /// </summary>
                            [NameInMap("VpcId")]
                            [Validation(Required=false)]
                            public string VpcId { get; set; }

                            /// <summary>
                            /// The name of the VPC.
                            /// </summary>
                            [NameInMap("VpcName")]
                            [Validation(Required=false)]
                            public string VpcName { get; set; }

                        }

                        /// <summary>
                        /// The unique ID of the virtual private cloud (VPC).
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// The ID of the zone.
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

            }

        }

    }

}
