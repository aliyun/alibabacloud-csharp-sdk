// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>For more information about how to define a resource group, see ResGroupEntity.</para>
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
                /// <para>The UID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>****@aliyun.com</para>
                /// </summary>
                [NameInMap("AdminUserId")]
                [Validation(Required=false)]
                public string AdminUserId { get; set; }

                /// <summary>
                /// <para>The time when the resource group was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1557890594376</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QqLZDA3pBZ</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8592</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TIa2LGixyD</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the region where the resource group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The Server Load Balancer (SLB) instances.</para>
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
                        /// <para>The IP address of the SLB instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.xxx.xx</para>
                        /// </summary>
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// <para>The type of the IP address of the SLB instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Internet: Users can connect to the SLB instance over the Internet.</description></item>
                        /// <item><description>Intranet: Users can connect to the SLB instance over the internal network.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Intranet</para>
                        /// </summary>
                        [NameInMap("AddressType")]
                        [Validation(Required=false)]
                        public string AddressType { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the SLB instance has expired. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true: The SLB instance has expired.</description></item>
                        /// <item><description>false: The SLB instance has not expired.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Expired")]
                        [Validation(Required=false)]
                        public bool? Expired { get; set; }

                        /// <summary>
                        /// <para>The ID of the group to which the SLB instance belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>64189****</para>
                        /// </summary>
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public int? GroupId { get; set; }

                        /// <summary>
                        /// <para>The network type of the SLB instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Classic network</description></item>
                        /// <item><description>VPC</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <para>The ID of the region.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-beijing</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The unique ID of the SLB instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>lb-2zebf1fpbpkc7dnro****</para>
                        /// </summary>
                        [NameInMap("SlbId")]
                        [Validation(Required=false)]
                        public string SlbId { get; set; }

                        /// <summary>
                        /// <para>The name of the SLB instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>a9315af59b4cd11e9a18c00163e1****</para>
                        /// </summary>
                        [NameInMap("SlbName")]
                        [Validation(Required=false)]
                        public string SlbName { get; set; }

                        /// <summary>
                        /// <para>The status of the SLB instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>active</para>
                        /// </summary>
                        [NameInMap("SlbStatus")]
                        [Validation(Required=false)]
                        public string SlbStatus { get; set; }

                        /// <summary>
                        /// <para>The UID of the Alibaba Cloud account.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>****@aliyun.com</para>
                        /// </summary>
                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                        /// <summary>
                        /// <para>The ID of the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-m5e666n89m2bx8jar****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// <para>The ID of the vSwitch.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-mktkxkhah14****</para>
                        /// </summary>
                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the resource group was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1573281040827</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The Elastic Compute Service (ECS) instances.</para>
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
                        /// <para>The total number of CPU cores.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Cpu")]
                        [Validation(Required=false)]
                        public int? Cpu { get; set; }

                        /// <summary>
                        /// <para>The description of the ECS instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The elastic compute unit (ECU) that corresponds to the ECS instance.</para>
                        /// </summary>
                        [NameInMap("EcuEntity")]
                        [Validation(Required=false)]
                        public ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntityEcuEntity EcuEntity { get; set; }
                        public class ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntityEcuEntity : TeaModel {
                            /// <summary>
                            /// <para>The number of available CPUs.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("AvailableCpu")]
                            [Validation(Required=false)]
                            public int? AvailableCpu { get; set; }

                            /// <summary>
                            /// <para>The size of the available memory.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("AvailableMem")]
                            [Validation(Required=false)]
                            public int? AvailableMem { get; set; }

                            /// <summary>
                            /// <para>The total number of CPU cores.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("Cpu")]
                            [Validation(Required=false)]
                            public int? Cpu { get; set; }

                            /// <summary>
                            /// <para>The time when the ECU was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1557890594376</para>
                            /// </summary>
                            [NameInMap("CreateTime")]
                            [Validation(Required=false)]
                            public long? CreateTime { get; set; }

                            /// <summary>
                            /// <para>Indicates whether Docker is installed. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>true: Docker is installed.</description></item>
                            /// <item><description>false: Docker is not installed.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("DockerEnv")]
                            [Validation(Required=false)]
                            public bool? DockerEnv { get; set; }

                            /// <summary>
                            /// <para>The unique ID of the elastic compute unit (ECU). You can run the <c>dmidecode</c> command on the ECS instance to query the ECU ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0de2ebdb-9490-4fc4-be41***************</para>
                            /// </summary>
                            [NameInMap("EcuId")]
                            [Validation(Required=false)]
                            public string EcuId { get; set; }

                            /// <summary>
                            /// <para>The time when the last heartbeat detection was performed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1573281040819</para>
                            /// </summary>
                            [NameInMap("HeartbeatTime")]
                            [Validation(Required=false)]
                            public long? HeartbeatTime { get; set; }

                            /// <summary>
                            /// <para>The ID of the instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>i-2zej4i2jdf*********</para>
                            /// </summary>
                            [NameInMap("InstanceId")]
                            [Validation(Required=false)]
                            public string InstanceId { get; set; }

                            /// <summary>
                            /// <para>The private IP address of the ECU.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>192.168.xxx.xx</para>
                            /// </summary>
                            [NameInMap("IpAddr")]
                            [Validation(Required=false)]
                            public string IpAddr { get; set; }

                            /// <summary>
                            /// <para>The total size of memory. Unit: MB.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("Mem")]
                            [Validation(Required=false)]
                            public int? Mem { get; set; }

                            /// <summary>
                            /// <para>The name of the ECU.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>test</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the ECU is online. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>true: The ECU is online.</description></item>
                            /// <item><description>false: The ECU is offline.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Online")]
                            [Validation(Required=false)]
                            public bool? Online { get; set; }

                            /// <summary>
                            /// <para>The ID of the region.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>cn-beijing</para>
                            /// </summary>
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }

                            /// <summary>
                            /// <para>The time when the ECU was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1573281040827</para>
                            /// </summary>
                            [NameInMap("UpdateTime")]
                            [Validation(Required=false)]
                            public long? UpdateTime { get; set; }

                            /// <summary>
                            /// <para>The ID of the user associated with the ECU.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>edas_****_test@aliyun-****.com</para>
                            /// </summary>
                            [NameInMap("UserId")]
                            [Validation(Required=false)]
                            public string UserId { get; set; }

                            /// <summary>
                            /// <para>The ID of the VPC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>vpc-2ze1ram356umxs598****</para>
                            /// </summary>
                            [NameInMap("VpcId")]
                            [Validation(Required=false)]
                            public string VpcId { get; set; }

                            /// <summary>
                            /// <para>The ID of the zone.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>cn-beijing-b</para>
                            /// </summary>
                            [NameInMap("ZoneId")]
                            [Validation(Required=false)]
                            public string ZoneId { get; set; }

                        }

                        /// <summary>
                        /// <para>The elastic IP address (EIP).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.xxx.xx</para>
                        /// </summary>
                        [NameInMap("Eip")]
                        [Validation(Required=false)]
                        public string Eip { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the ECS instance has expired. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true: The ECS instance has expired.</description></item>
                        /// <item><description>false: The ECS instance has not expired.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Expired")]
                        [Validation(Required=false)]
                        public bool? Expired { get; set; }

                        /// <summary>
                        /// <para>The ID of the resource group in Enterprise Distributed Application Service (EDAS).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>64189****</para>
                        /// </summary>
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public string GroupId { get; set; }

                        /// <summary>
                        /// <para>The name of the host.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>iZm5e853hvvrodnvqus****</para>
                        /// </summary>
                        [NameInMap("HostName")]
                        [Validation(Required=false)]
                        public string HostName { get; set; }

                        /// <summary>
                        /// <para>The private IP address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.xx.xxx</para>
                        /// </summary>
                        [NameInMap("InnerIp")]
                        [Validation(Required=false)]
                        public string InnerIp { get; set; }

                        /// <summary>
                        /// <para>The ID of the ECS instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-m5e853hvvrodnvqu****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The name of the ECS instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>betabjmixcoud_01</para>
                        /// </summary>
                        [NameInMap("InstanceName")]
                        [Validation(Required=false)]
                        public string InstanceName { get; set; }

                        /// <summary>
                        /// <para>The total size of memory. Unit: MB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Mem")]
                        [Validation(Required=false)]
                        public int? Mem { get; set; }

                        /// <summary>
                        /// <para>The private IP address of the ECS instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.xx.xxx</para>
                        /// </summary>
                        [NameInMap("PrivateIp")]
                        [Validation(Required=false)]
                        public string PrivateIp { get; set; }

                        /// <summary>
                        /// <para>The public IP address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.xx.xxx</para>
                        /// </summary>
                        [NameInMap("PublicIp")]
                        [Validation(Required=false)]
                        public string PublicIp { get; set; }

                        /// <summary>
                        /// <para>The ID of the region.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ch-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The serial number of the ECS instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>98b480b8-458b-4ff3-84b9-cf7097c5****</para>
                        /// </summary>
                        [NameInMap("SerialNum")]
                        [Validation(Required=false)]
                        public string SerialNum { get; set; }

                        /// <summary>
                        /// <para>The ID of the security group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-m5eajgzn6b8sg9mv****</para>
                        /// </summary>
                        [NameInMap("SgId")]
                        [Validation(Required=false)]
                        public string SgId { get; set; }

                        /// <summary>
                        /// <para>The status of the ECS instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Pending: The ECS instance is being created.</description></item>
                        /// <item><description>Running: The ECS instance is running.</description></item>
                        /// <item><description>Starting: The ECS instance is being started.</description></item>
                        /// <item><description>Stopping: The ECS instance is being stopped.</description></item>
                        /// <item><description>Stopped: The ECS instance is stopped.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Running</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The ID of the user account.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><b><b><em>common</em></b></b>@aliyun.com</para>
                        /// </summary>
                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                        /// <summary>
                        /// <para>The VPCs.</para>
                        /// </summary>
                        [NameInMap("VpcEntity")]
                        [Validation(Required=false)]
                        public ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntityVpcEntity VpcEntity { get; set; }
                        public class ListResourceGroupResponseBodyResourceGroupListResGroupEntityEcsListEcsEntityVpcEntity : TeaModel {
                            /// <summary>
                            /// <para>The IPv4 CIDR block of the vSwitch.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>192.168.xx.xxx</para>
                            /// </summary>
                            [NameInMap("Cidrblock")]
                            [Validation(Required=false)]
                            public string Cidrblock { get; set; }

                            /// <summary>
                            /// <para>The description of the VPC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>&quot;&quot;</para>
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// <para>The number of ECS instances that run in the VPC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("EcsNum")]
                            [Validation(Required=false)]
                            public int? EcsNum { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the VPC has expired. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>true: The VPC has expired.</description></item>
                            /// <item><description>false: The VPC has not expired.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Expired")]
                            [Validation(Required=false)]
                            public bool? Expired { get; set; }

                            /// <summary>
                            /// <para>The ID of the region.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>cn-qingdao</para>
                            /// </summary>
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }

                            /// <summary>
                            /// <para>The status of the VPC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Running</para>
                            /// </summary>
                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }

                            /// <summary>
                            /// <para>The ID of the user.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><b><b><em>common</em></b></b>@aliyun.com</para>
                            /// </summary>
                            [NameInMap("UserId")]
                            [Validation(Required=false)]
                            public string UserId { get; set; }

                            /// <summary>
                            /// <para>The unique ID of the VPC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>vpc-bp13evu42t1er****</para>
                            /// </summary>
                            [NameInMap("VpcId")]
                            [Validation(Required=false)]
                            public string VpcId { get; set; }

                            /// <summary>
                            /// <para>The name of the VPC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>test</para>
                            /// </summary>
                            [NameInMap("VpcName")]
                            [Validation(Required=false)]
                            public string VpcName { get; set; }

                        }

                        /// <summary>
                        /// <para>The unique ID of the virtual private cloud (VPC).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-bp13evu4aayj2t1er****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// <para>The ID of the zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-qingdao-h</para>
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
