// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance group details.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Ansm")]
            [Validation(Required=false)]
            public bool? Ansm { get; set; }

            /// <summary>
            /// <para>The processor architecture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>X86</para>
            /// </summary>
            [NameInMap("ArchitectureType")]
            [Validation(Required=false)]
            public string ArchitectureType { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c20c******404</para>
            /// </summary>
            [NameInMap("AskClusterId")]
            [Validation(Required=false)]
            public string AskClusterId { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>POST: pay-as-you-go</description></item>
            /// <item><description>PRE: subscription</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PRE</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The cluster state.</para>
            /// </summary>
            [NameInMap("ClusterState")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesClusterState ClusterState { get; set; }
            public class DescribeInstancesResponseBodyInstancesClusterState : TeaModel {
                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a6f35c0ff73448</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The cluster stage information.</para>
                /// </summary>
                [NameInMap("ClusterStage")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesClusterStateClusterStage ClusterStage { get; set; }
                public class DescribeInstancesResponseBodyInstancesClusterStateClusterStage : TeaModel {
                    /// <summary>
                    /// <para>The cluster ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>f0957e82de6e47</para>
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// <para>The sequence number of the current stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CurrentStage")]
                    [Validation(Required=false)]
                    public int? CurrentStage { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Resource creation failed</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The status of the workspace. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CREATING: The workspace is being created.</description></item>
                    /// <item><description>DELETING: The workspace is being deleted.</description></item>
                    /// <item><description>MODIFYING: The resource specifications are being modified.</description></item>
                    /// <item><description>SUCCESS: The previous operation succeeded.</description></item>
                    /// <item><description>FAILED: The previous operation failed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREATING</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The list of stages and weights.</para>
                    /// </summary>
                    [NameInMap("TotalStageWithWeight")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesClusterStateClusterStageTotalStageWithWeight> TotalStageWithWeight { get; set; }
                    public class DescribeInstancesResponseBodyInstancesClusterStateClusterStageTotalStageWithWeight : TeaModel {
                        /// <summary>
                        /// <para>The stage sequence number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("StepIndex")]
                        [Validation(Required=false)]
                        public int? StepIndex { get; set; }

                        /// <summary>
                        /// <para>The stage name.</para>
                        /// </summary>
                        [NameInMap("StepName")]
                        [Validation(Required=false)]
                        public string StepName { get; set; }

                        /// <summary>
                        /// <para>The stage weight.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the cluster creation timed out.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CreateTimeout")]
                [Validation(Required=false)]
                public bool? CreateTimeout { get; set; }

                /// <summary>
                /// <para>The cluster status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CREATING: The cluster is being created.</description></item>
                /// <item><description>RUNNING: The cluster is running.</description></item>
                /// <item><description>DISABLE: The cluster is invalid.</description></item>
                /// <item><description>DELETING: The cluster is being deleted.</description></item>
                /// <item><description>DELETED: The cluster is deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The cluster status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CREATING: The cluster is being created.</description></item>
                /// <item><description>RUNNING: The cluster is running.</description></item>
                /// <item><description>DISABLE: The cluster is invalid.</description></item>
                /// <item><description>DELETING: The cluster is being deleted.</description></item>
                /// <item><description>DELETED: The cluster is deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("SubStatus")]
                [Validation(Required=false)]
                public string SubStatus { get; set; }

                /// <summary>
                /// <para>The cluster-related URLs.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://flink-cn-hongkong.data.aliyun.com">https://flink-cn-hongkong.data.aliyun.com</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The user-side load balancing information.</para>
                /// </summary>
                [NameInMap("UserSlbDto")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesClusterStateUserSlbDto UserSlbDto { get; set; }
                public class DescribeInstancesResponseBodyInstancesClusterStateUserSlbDto : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether a user-side load balancing instance exists.</para>
                    /// </summary>
                    [NameInMap("ExistSlb")]
                    [Validation(Required=false)]
                    public bool? ExistSlb { get; set; }

                    /// <summary>
                    /// <para>The load balancing instance ID.</para>
                    /// </summary>
                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    /// <summary>
                    /// <para>The IP address of the load balancing instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.1.10</para>
                    /// </summary>
                    [NameInMap("SlbIp")]
                    [Validation(Required=false)]
                    public string SlbIp { get; set; }

                    /// <summary>
                    /// <para>The instance status of the load balancing instance.</para>
                    /// </summary>
                    [NameInMap("SlbStatus")]
                    [Validation(Required=false)]
                    public string SlbStatus { get; set; }

                    /// <summary>
                    /// <para>The list of user-side load balancing listeners.</para>
                    /// </summary>
                    [NameInMap("UserSlbListeners")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesClusterStateUserSlbDtoUserSlbListeners> UserSlbListeners { get; set; }
                    public class DescribeInstancesResponseBodyInstancesClusterStateUserSlbDtoUserSlbListeners : TeaModel {
                        /// <summary>
                        /// <para>The listener status.</para>
                        /// </summary>
                        [NameInMap("ListenersStatus")]
                        [Validation(Required=false)]
                        public string ListenersStatus { get; set; }

                        /// <summary>
                        /// <para>The listener port.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8080</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                    }

                }

                /// <summary>
                /// <para>The CIDR block of the VPC where the cluster is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/16</para>
                /// </summary>
                [NameInMap("VpcCidr")]
                [Validation(Required=false)]
                public string VpcCidr { get; set; }

            }

            /// <summary>
            /// <para>The cluster status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATING: The cluster is being created.</description></item>
            /// <item><description>RUNNING: The cluster is running.</description></item>
            /// <item><description>DISABLE: The cluster is invalid.</description></item>
            /// <item><description>DELETING: The cluster is being deleted.</description></item>
            /// <item><description>DELETED: The cluster is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("ClusterStatus")]
            [Validation(Required=false)]
            public string ClusterStatus { get; set; }

            /// <summary>
            /// <para>The overall resource usage of the Flink service.</para>
            /// </summary>
            [NameInMap("ClusterUsedResources")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesClusterUsedResources ClusterUsedResources { get; set; }
            public class DescribeInstancesResponseBodyInstancesClusterUsedResources : TeaModel {
                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ea2e9545fdc942</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The number of elastic CPUs used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ElasticUsedCpu")]
                [Validation(Required=false)]
                public float? ElasticUsedCpu { get; set; }

                /// <summary>
                /// <para>The amount of elastic memory used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ElasticUsedMemory")]
                [Validation(Required=false)]
                public float? ElasticUsedMemory { get; set; }

                /// <summary>
                /// <para>The resource count of used elastic resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ElasticUsedResource")]
                [Validation(Required=false)]
                public float? ElasticUsedResource { get; set; }

                /// <summary>
                /// <para>The number of guaranteed CPUs used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("GuaranteedUsedCpu")]
                [Validation(Required=false)]
                public float? GuaranteedUsedCpu { get; set; }

                /// <summary>
                /// <para>The amount of guaranteed memory used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("GuaranteedUsedMemory")]
                [Validation(Required=false)]
                public float? GuaranteedUsedMemory { get; set; }

                /// <summary>
                /// <para>The resource count of used guaranteed resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("GuaranteedUsedResource")]
                [Validation(Required=false)]
                public float? GuaranteedUsedResource { get; set; }

                /// <summary>
                /// <para>Indicates whether cross-zone high-availability resources are selected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Ha")]
                [Validation(Required=false)]
                public bool? Ha { get; set; }

                /// <summary>
                /// <para>The number of cross-zone high-availability CPUs used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HaUsedCpu")]
                [Validation(Required=false)]
                public float? HaUsedCpu { get; set; }

                /// <summary>
                /// <para>The amount of active memory used for cross-zone high availability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HaUsedMemory")]
                [Validation(Required=false)]
                public float? HaUsedMemory { get; set; }

                /// <summary>
                /// <para>The number of cross-zone high-availability compute units used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HaUsedResource")]
                [Validation(Required=false)]
                public float? HaUsedResource { get; set; }

                /// <summary>
                /// <para>The total number of CPUs used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UsedCpu")]
                [Validation(Required=false)]
                public float? UsedCpu { get; set; }

                /// <summary>
                /// <para>The total amount of memory used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UsedMemory")]
                [Validation(Required=false)]
                public float? UsedMemory { get; set; }

                /// <summary>
                /// <para>The total number of compute units used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UsedResource")]
                [Validation(Required=false)]
                public float? UsedResource { get; set; }

            }

            /// <summary>
            /// <para>The storage resource usage information of the cluster.</para>
            /// </summary>
            [NameInMap("ClusterUsedStorage")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesClusterUsedStorage ClusterUsedStorage { get; set; }
            public class DescribeInstancesResponseBodyInstancesClusterUsedStorage : TeaModel {
                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f0957e82de6e47</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The amount of storage used by the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UsedStorage")]
                [Validation(Required=false)]
                public float? UsedStorage { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>Indicates whether elastic resources are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Elastic")]
            [Validation(Required=false)]
            public bool? Elastic { get; set; }

            /// <summary>
            /// <para>The elastic order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-cn-e3afbd321</para>
            /// </summary>
            [NameInMap("ElasticInstanceId")]
            [Validation(Required=false)]
            public string ElasticInstanceId { get; set; }

            /// <summary>
            /// <para>The status of the elastic resource order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("ElasticOrderState")]
            [Validation(Required=false)]
            public string ElasticOrderState { get; set; }

            /// <summary>
            /// <para>The specifications of pay-as-you-go elastic resources.</para>
            /// </summary>
            [NameInMap("ElasticResourceSpec")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesElasticResourceSpec ElasticResourceSpec { get; set; }
            public class DescribeInstancesResponseBodyInstancesElasticResourceSpec : TeaModel {
                /// <summary>
                /// <para>The number of CPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The amount of memory used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>280</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether cross-zone high-availability resources are selected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Ha")]
            [Validation(Required=false)]
            public bool? Ha { get; set; }

            /// <summary>
            /// <para>The description of cross-zone high-availability resources.</para>
            /// </summary>
            [NameInMap("HaResourceSpec")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesHaResourceSpec HaResourceSpec { get; set; }
            public class DescribeInstancesResponseBodyInstancesHaResourceSpec : TeaModel {
                /// <summary>
                /// <para>The number of cross-zone high-availability CPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The memory size of cross-zone high-availability resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>48</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            /// <summary>
            /// <para>The vSwitch group in the secondary zone for cross-zone high availability.</para>
            /// </summary>
            [NameInMap("HaVSwitchIds")]
            [Validation(Required=false)]
            public List<string> HaVSwitchIds { get; set; }

            /// <summary>
            /// <para>The vSwitch group information in the secondary zone for cross-zone high availability.</para>
            /// </summary>
            [NameInMap("HaVSwitchInfo")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesHaVSwitchInfo> HaVSwitchInfo { get; set; }
            public class DescribeInstancesResponseBodyInstancesHaVSwitchInfo : TeaModel {
                /// <summary>
                /// <para>The number of available IP addresses in the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("AvailableIpAddressCount")]
                [Validation(Required=false)]
                public long? AvailableIpAddressCount { get; set; }

                /// <summary>
                /// <para>The description of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The vSwitch CIDR block information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.16.0/24</para>
                /// </summary>
                [NameInMap("VSwitchCidr")]
                [Validation(Required=false)]
                public string VSwitchCidr { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-wz9e9zt38b9f3l6*****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The vSwitch name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test vSwitch</para>
                /// </summary>
                [NameInMap("VSwitchName")]
                [Validation(Required=false)]
                public string VSwitchName { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6d0akr6lzd75v****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the zone to which the workspace belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the secondary zone for zone-disaster recovery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongkong-b</para>
            /// </summary>
            [NameInMap("HaZoneId")]
            [Validation(Required=false)]
            public string HaZoneId { get; set; }

            /// <summary>
            /// <para>The domain name information added by the user.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("HostAliases")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesHostAliases> HostAliases { get; set; }
            public class DescribeInstancesResponseBodyInstancesHostAliases : TeaModel {
                /// <summary>
                /// <para>The list of hostnames.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("HostNames")]
                [Validation(Required=false)]
                public List<string> HostNames { get; set; }

                /// <summary>
                /// <para>The IP address that corresponds to the hostname.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.20</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-cn-zvp2q0z****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vvp1</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The type of the monitoring and alerting service. Valid values: ARMS and CloudMonitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TAIHAO</para>
            /// </summary>
            [NameInMap("MonitorType")]
            [Validation(Required=false)]
            public string MonitorType { get; set; }

            /// <summary>
            /// <para>The order status of the Flink compute service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_INIT: The order is placed but components are not deployed.</description></item>
            /// <item><description>NORMAL: The order is in the normal state.</description></item>
            /// <item><description>CEASE: The order is expired.</description></item>
            /// <item><description>RELEASE: The order is overdue.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("OrderState")]
            [Validation(Required=false)]
            public string OrderState { get; set; }

            /// <summary>
            /// <para>The access configuration information for OSS.</para>
            /// </summary>
            [NameInMap("OssInfo")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesOssInfo OssInfo { get; set; }
            public class DescribeInstancesResponseBodyInstancesOssInfo : TeaModel {
                /// <summary>
                /// <para>The AccessKey ID for OSS.</para>
                /// </summary>
                [NameInMap("AccessId")]
                [Validation(Required=false)]
                public string AccessId { get; set; }

                /// <summary>
                /// <para>The AccessKey secret for OSS.</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>The name of the bound OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flink-log-john</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The versioning status of the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OFF</para>
                /// </summary>
                [NameInMap("BucketVersioningStatus")]
                [Validation(Required=false)]
                public string BucketVersioningStatus { get; set; }

                /// <summary>
                /// <para>The OSS endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

            }

            /// <summary>
            /// <para>The region to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1629879567394</para>
            /// </summary>
            [NameInMap("ResourceCreateTime")]
            [Validation(Required=false)]
            public long? ResourceCreateTime { get; set; }

            /// <summary>
            /// <para>The time when the instance expires. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637337600000</para>
            /// </summary>
            [NameInMap("ResourceExpiredTime")]
            [Validation(Required=false)]
            public long? ResourceExpiredTime { get; set; }

            /// <summary>
            /// <para>The resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-***</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b3690a1655****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource specifications.</para>
            /// </summary>
            [NameInMap("ResourceSpec")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesResourceSpec ResourceSpec { get; set; }
            public class DescribeInstancesResponseBodyInstancesResourceSpec : TeaModel {
                /// <summary>
                /// <para>The number of CPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The configured memory size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            /// <summary>
            /// <para>The storage information.</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesStorage Storage { get; set; }
            public class DescribeInstancesResponseBodyInstancesStorage : TeaModel {
                /// <summary>
                /// <para>Specifies whether fully managed storage is selected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Yes.</description></item>
                /// <item><description>false: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FullyManaged")]
                [Validation(Required=false)]
                public bool? FullyManaged { get; set; }

                /// <summary>
                /// <para>The order status of the fully managed storage. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>NOT_INIT: The order is placed but components are not deployed.</para>
                /// </description></item>
                /// <item><description><para>NORMAL: The order is in the normal state.</para>
                /// </description></item>
                /// <item><description><para>CEASE: The order is expired.</para>
                /// </description></item>
                /// <item><description><para>RELEASE: The order is overdue.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("OrderState")]
                [Validation(Required=false)]
                public string OrderState { get; set; }

                /// <summary>
                /// <para>The OSS storage information.</para>
                /// </summary>
                [NameInMap("Oss")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesStorageOss Oss { get; set; }
                public class DescribeInstancesResponseBodyInstancesStorageOss : TeaModel {
                    /// <summary>
                    /// <para>The name of the bound OSS bucket.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss_flink</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether the creation of fully managed storage is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportCreateFullyManagedStorage")]
                [Validation(Required=false)]
                public bool? SupportCreateFullyManagedStorage { get; set; }

                /// <summary>
                /// <para>Specifies whether migration progress detection is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportMigrationProgressDetection")]
                [Validation(Required=false)]
                public bool? SupportMigrationProgressDetection { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether disaster recovery drills are supported.</para>
            /// </summary>
            [NameInMap("SupportDisasterRecoveryDrill")]
            [Validation(Required=false)]
            public bool? SupportDisasterRecoveryDrill { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesTags> Tags { get; set; }
            public class DescribeInstancesResponseBodyInstancesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flink</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the user that owns the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>183899668736****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>The vSwitch IDs.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The information about the primary vSwitch group.</para>
            /// </summary>
            [NameInMap("VSwitchInfo")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesVSwitchInfo> VSwitchInfo { get; set; }
            public class DescribeInstancesResponseBodyInstancesVSwitchInfo : TeaModel {
                /// <summary>
                /// <para>The number of available IP addresses in the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>256</para>
                /// </summary>
                [NameInMap("AvailableIpAddressCount")]
                [Validation(Required=false)]
                public string AvailableIpAddressCount { get; set; }

                /// <summary>
                /// <para>The description of the vSwitch group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The vSwitch CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.16.0/24</para>
                /// </summary>
                [NameInMap("VSwitchCidr")]
                [Validation(Required=false)]
                public string VSwitchCidr { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-8vb6jk75wfcwnuq****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The name of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("VSwitchName")]
                [Validation(Required=false)]
                public string VSwitchName { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp16h9ru9gvz2tygo*****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the zone to which the workspace belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze9*******nxfmfcdi</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The VPC information.</para>
            /// </summary>
            [NameInMap("VpcInfo")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesVpcInfo VpcInfo { get; set; }
            public class DescribeInstancesResponseBodyInstancesVpcInfo : TeaModel {
                /// <summary>
                /// <para>The CIDR block of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.5.0/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The description of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The VPC status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Pending: Configuring.</para>
                /// </description></item>
                /// <item><description><para>Available: Available.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-gw8c6nhjta3eq12y****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Flink cluster VPC</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the zone to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of instances per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C8DF2A5B-6FBA-5651-A3D4-960F3664****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
