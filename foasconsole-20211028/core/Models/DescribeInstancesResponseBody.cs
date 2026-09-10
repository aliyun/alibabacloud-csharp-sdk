// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the instance group.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
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
            /// <item><description>POST: pay-as-you-go.</description></item>
            /// <item><description>PRE: subscription.</description></item>
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
                /// <b>Example:</b>
                /// <para>a6f35c0ff73448</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterStage")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesClusterStateClusterStage ClusterStage { get; set; }
                public class DescribeInstancesResponseBodyInstancesClusterStateClusterStage : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>f0957e82de6e47</para>
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("CurrentStage")]
                    [Validation(Required=false)]
                    public int? CurrentStage { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The status of the project space. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CREATING: Being created.</description></item>
                    /// <item><description>DELETING: Being deleted.</description></item>
                    /// <item><description>MODIFYING: Resource specifications are being modified.</description></item>
                    /// <item><description>SUCCESS: The previous operation was successful.</description></item>
                    /// <item><description>FAILED: The previous operation failed.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TotalStageWithWeight")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesClusterStateClusterStageTotalStageWithWeight> TotalStageWithWeight { get; set; }
                    public class DescribeInstancesResponseBodyInstancesClusterStateClusterStageTotalStageWithWeight : TeaModel {
                        [NameInMap("StepIndex")]
                        [Validation(Required=false)]
                        public int? StepIndex { get; set; }

                        [NameInMap("StepName")]
                        [Validation(Required=false)]
                        public string StepName { get; set; }

                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                [NameInMap("CreateTimeout")]
                [Validation(Required=false)]
                public bool? CreateTimeout { get; set; }

                /// <summary>
                /// <para>The cluster status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>CREATING: Being created.</para>
                /// </description></item>
                /// <item><description><para>RUNNING: Running.</para>
                /// </description></item>
                /// <item><description><para>DISABLE: Invalid.</para>
                /// </description></item>
                /// <item><description><para>DELETING: Being deleted.</para>
                /// </description></item>
                /// <item><description><para>DELETED: Deleted.</para>
                /// </description></item>
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
                /// <item><description><para>CREATING: Being created.</para>
                /// </description></item>
                /// <item><description><para>RUNNING: Running.</para>
                /// </description></item>
                /// <item><description><para>DISABLE: Invalid.</para>
                /// </description></item>
                /// <item><description><para>DELETING: Being deleted.</para>
                /// </description></item>
                /// <item><description><para>DELETED: Deleted.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("SubStatus")]
                [Validation(Required=false)]
                public string SubStatus { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("UserSlbDto")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesClusterStateUserSlbDto UserSlbDto { get; set; }
                public class DescribeInstancesResponseBodyInstancesClusterStateUserSlbDto : TeaModel {
                    [NameInMap("ExistSlb")]
                    [Validation(Required=false)]
                    public bool? ExistSlb { get; set; }

                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    [NameInMap("SlbIp")]
                    [Validation(Required=false)]
                    public string SlbIp { get; set; }

                    [NameInMap("SlbStatus")]
                    [Validation(Required=false)]
                    public string SlbStatus { get; set; }

                    [NameInMap("UserSlbListeners")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesClusterStateUserSlbDtoUserSlbListeners> UserSlbListeners { get; set; }
                    public class DescribeInstancesResponseBodyInstancesClusterStateUserSlbDtoUserSlbListeners : TeaModel {
                        [NameInMap("ListenersStatus")]
                        [Validation(Required=false)]
                        public string ListenersStatus { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                    }

                }

                [NameInMap("VpcCidr")]
                [Validation(Required=false)]
                public string VpcCidr { get; set; }

            }

            /// <summary>
            /// <para>The cluster status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATING: Being created.</description></item>
            /// <item><description>RUNNING: Running.</description></item>
            /// <item><description>DISABLE: Invalid.</description></item>
            /// <item><description>DELETING: Being deleted.</description></item>
            /// <item><description>DELETED: Deleted.</description></item>
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
                /// <b>Example:</b>
                /// <para>ea2e9545fdc942</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ElasticUsedCpu")]
                [Validation(Required=false)]
                public float? ElasticUsedCpu { get; set; }

                [NameInMap("ElasticUsedMemory")]
                [Validation(Required=false)]
                public float? ElasticUsedMemory { get; set; }

                [NameInMap("ElasticUsedResource")]
                [Validation(Required=false)]
                public float? ElasticUsedResource { get; set; }

                [NameInMap("GuaranteedUsedCpu")]
                [Validation(Required=false)]
                public float? GuaranteedUsedCpu { get; set; }

                [NameInMap("GuaranteedUsedMemory")]
                [Validation(Required=false)]
                public float? GuaranteedUsedMemory { get; set; }

                [NameInMap("GuaranteedUsedResource")]
                [Validation(Required=false)]
                public float? GuaranteedUsedResource { get; set; }

                /// <summary>
                /// <para>Indicates whether zone-disaster recovery resources are selected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Ha")]
                [Validation(Required=false)]
                public bool? Ha { get; set; }

                [NameInMap("HaUsedCpu")]
                [Validation(Required=false)]
                public float? HaUsedCpu { get; set; }

                [NameInMap("HaUsedMemory")]
                [Validation(Required=false)]
                public float? HaUsedMemory { get; set; }

                [NameInMap("HaUsedResource")]
                [Validation(Required=false)]
                public float? HaUsedResource { get; set; }

                [NameInMap("UsedCpu")]
                [Validation(Required=false)]
                public float? UsedCpu { get; set; }

                [NameInMap("UsedMemory")]
                [Validation(Required=false)]
                public float? UsedMemory { get; set; }

                [NameInMap("UsedResource")]
                [Validation(Required=false)]
                public float? UsedResource { get; set; }

            }

            [NameInMap("ClusterUsedStorage")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesClusterUsedStorage ClusterUsedStorage { get; set; }
            public class DescribeInstancesResponseBodyInstancesClusterUsedStorage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>f0957e82de6e47</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

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

            [NameInMap("ElasticOrderState")]
            [Validation(Required=false)]
            public string ElasticOrderState { get; set; }

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
            /// <para>Indicates whether zone-disaster recovery resources are selected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Ha")]
            [Validation(Required=false)]
            public bool? Ha { get; set; }

            /// <summary>
            /// <para>The zone-disaster recovery resource description.</para>
            /// </summary>
            [NameInMap("HaResourceSpec")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesHaResourceSpec HaResourceSpec { get; set; }
            public class DescribeInstancesResponseBodyInstancesHaResourceSpec : TeaModel {
                /// <summary>
                /// <para>The number of CPUs for zone-disaster recovery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The memory size of zone-disaster recovery resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>48</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            /// <summary>
            /// <para>The vSwitch group in the secondary zone for zone-disaster recovery.</para>
            /// </summary>
            [NameInMap("HaVSwitchIds")]
            [Validation(Required=false)]
            public List<string> HaVSwitchIds { get; set; }

            /// <summary>
            /// <para>The vSwitch group information for the secondary zone of zone-disaster recovery.</para>
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
                /// <para>The region.</para>
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
                /// <para>The zone ID of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The secondary zone ID for zone-disaster recovery.</para>
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
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("HostNames")]
                [Validation(Required=false)]
                public List<string> HostNames { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
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
            /// <para>The workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vvp1</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The type of the monitoring and alerting service. You can select ARMS or CloudMonitor.</para>
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
            /// <item><description>NOT_INIT: The order is placed but components are not yet deployed.</description></item>
            /// <item><description>NORMAL: Normal.</description></item>
            /// <item><description>CEASE: Expired.</description></item>
            /// <item><description>RELEASE: Overdue.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("OrderState")]
            [Validation(Required=false)]
            public string OrderState { get; set; }

            [NameInMap("OssInfo")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesOssInfo OssInfo { get; set; }
            public class DescribeInstancesResponseBodyInstancesOssInfo : TeaModel {
                [NameInMap("AccessId")]
                [Validation(Required=false)]
                public string AccessId { get; set; }

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

                [NameInMap("BucketVersioningStatus")]
                [Validation(Required=false)]
                public string BucketVersioningStatus { get; set; }

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
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1629879567394</para>
            /// </summary>
            [NameInMap("ResourceCreateTime")]
            [Validation(Required=false)]
            public long? ResourceCreateTime { get; set; }

            /// <summary>
            /// <para>The overdue time.</para>
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
            /// <para>The resource specification information.</para>
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
                /// <para>Indicates whether fully managed storage is selected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Used.</description></item>
                /// <item><description>false: Not used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FullyManaged")]
                [Validation(Required=false)]
                public bool? FullyManaged { get; set; }

                /// <summary>
                /// <para>The order status of fully managed storage. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>NOT_INIT: The order is placed but components are not yet deployed.</para>
                /// </description></item>
                /// <item><description><para>NORMAL: Normal.</para>
                /// </description></item>
                /// <item><description><para>CEASE: Expired.</para>
                /// </description></item>
                /// <item><description><para>RELEASE: Overdue.</para>
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

                [NameInMap("SupportCreateFullyManagedStorage")]
                [Validation(Required=false)]
                public bool? SupportCreateFullyManagedStorage { get; set; }

                [NameInMap("SupportMigrationProgressDetection")]
                [Validation(Required=false)]
                public bool? SupportMigrationProgressDetection { get; set; }

            }

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
            /// <para>The ID of the user to whom the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>183899668736****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>The vSwitch ID group.</para>
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
                /// <para>VPC ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp16h9ru9gvz2tygo*****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone ID of the workspace.</para>
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
                /// <para>The VPC CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.5.0/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The VPC description.</para>
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
                /// <item><description><para>Pending: Being configured.</para>
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
                /// <para>The VPC name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flink集群vpc</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <para>The zone ID of the instance.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
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
