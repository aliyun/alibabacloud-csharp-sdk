// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetAutoScaleConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The prefix of the queue name. You can query queues that have a specified prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pbs</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable hyper-threading for the ECS instance that is used as the compute node.</para>
        /// <remarks>
        /// <para> You can only disable hyper-threading for some instance types. The hyper-threading is enabled for ECS instances by default. For more information, see <a href="https://help.aliyun.com/document_detail/145895.html">Specify and view CPU options</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ComputeEnableHt")]
        [Validation(Required=false)]
        public bool? ComputeEnableHt { get; set; }

        /// <summary>
        /// <para>The configurations of DNS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;DnsType\&quot;:\&quot;PrivateZone\&quot;,\&quot;DnsName\&quot;:\&quot;xxxxx\&quot;}&quot;</para>
        /// </summary>
        [NameInMap("DnsConfig")]
        [Validation(Required=false)]
        public string DnsConfig { get; set; }

        /// <summary>
        /// <para>The percentage of each round of scale-out. Valid values: 1 to 100.</para>
        /// <para>If you set GrowRatio to 50, the scale-out has two rounds. Each round completes half of the scale-out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutoGrow")]
        [Validation(Required=false)]
        public bool? EnableAutoGrow { get; set; }

        /// <summary>
        /// <para>The number of consecutive times that a compute node is idle during the resource scale-in check. Valid values: 2 to 5.</para>
        /// <para>If the parameter is set to 3, a compute node is idle for more than three consecutive times. In this case, the node is released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutoShrink")]
        [Validation(Required=false)]
        public bool? EnableAutoShrink { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp19lgqwxb4206t5****,i-bp1g4hvzs9pywrhb****</para>
        /// </summary>
        [NameInMap("ExcludeNodes")]
        [Validation(Required=false)]
        public string ExcludeNodes { get; set; }

        /// <summary>
        /// <para>The instance type of the compute nodes that were automatically added in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ExtraNodesGrowRatio")]
        [Validation(Required=false)]
        public int? ExtraNodesGrowRatio { get; set; }

        /// <summary>
        /// <para>The image ID of the compute nodes in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GrowIntervalInMinutes")]
        [Validation(Required=false)]
        public int? GrowIntervalInMinutes { get; set; }

        /// <summary>
        /// <para>The minimum number of compute nodes that can be retained in a queue. Valid values: 0 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("GrowRatio")]
        [Validation(Required=false)]
        public int? GrowRatio { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of the compute nodes. The value can be accurate to three decimal places. The parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("GrowTimeoutInMinutes")]
        [Validation(Required=false)]
        public int? GrowTimeoutInMinutes { get; set; }

        /// <summary>
        /// <para>The preemption policy of the compute nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The compute nodes are pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: The compute nodes are preemptible instances that have a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp10txryr4mhrrt1****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The interval between two consecutive rounds of scale-in. Unit: minutes. Valid values: 2 to 10.</para>
        /// <remarks>
        /// <para> An interval may exist during multiple rounds of a scale-out task or between two consecutive scale-out tasks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("MaxNodesInCluster")]
        [Validation(Required=false)]
        public int? MaxNodesInCluster { get; set; }

        /// <summary>
        /// <para>The auto scaling configuration of the queue.</para>
        /// <remarks>
        /// <para> If auto scaling is enabled for the cluster and queue at the same time, the queue settings prevail.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Queues")]
        [Validation(Required=false)]
        public GetAutoScaleConfigResponseBodyQueues Queues { get; set; }
        public class GetAutoScaleConfigResponseBodyQueues : TeaModel {
            [NameInMap("QueueInfo")]
            [Validation(Required=false)]
            public List<GetAutoScaleConfigResponseBodyQueuesQueueInfo> QueueInfo { get; set; }
            public class GetAutoScaleConfigResponseBodyQueuesQueueInfo : TeaModel {
                /// <summary>
                /// <para>Indicates whether the minimum node number for each scale-out is automatically set. If this parameter is set to true, the minimum number of nodes for each scale-out is equal to the number of nodes required by the job. The maximum number is 99.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoMinNodesPerCycle")]
                [Validation(Required=false)]
                public bool? AutoMinNodesPerCycle { get; set; }

                /// <summary>
                /// <para>The list of data disks.</para>
                /// </summary>
                [NameInMap("DataDisks")]
                [Validation(Required=false)]
                public GetAutoScaleConfigResponseBodyQueuesQueueInfoDataDisks DataDisks { get; set; }
                public class GetAutoScaleConfigResponseBodyQueuesQueueInfoDataDisks : TeaModel {
                    [NameInMap("DataDisksInfo")]
                    [Validation(Required=false)]
                    public List<GetAutoScaleConfigResponseBodyQueuesQueueInfoDataDisksDataDisksInfo> DataDisksInfo { get; set; }
                    public class GetAutoScaleConfigResponseBodyQueuesQueueInfoDataDisksDataDisksInfo : TeaModel {
                        /// <summary>
                        /// <para>The type of the data disk. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>cloud_efficiency: ultra disk.</description></item>
                        /// <item><description>cloud_ssd: standard SSD.</description></item>
                        /// <item><description>cloud_essd: ESSD.</description></item>
                        /// <item><description>cloud: basic disk.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cloud_efficiency</para>
                        /// </summary>
                        [NameInMap("DataDiskCategory")]
                        [Validation(Required=false)]
                        public string DataDiskCategory { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the data disk is released when the node is released. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true</description></item>
                        /// <item><description>false</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("DataDiskDeleteWithInstance")]
                        [Validation(Required=false)]
                        public bool? DataDiskDeleteWithInstance { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the data disk is encrypted. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true</description></item>
                        /// <item><description>false</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("DataDiskEncrypted")]
                        [Validation(Required=false)]
                        public bool? DataDiskEncrypted { get; set; }

                        /// <summary>
                        /// <para>The ID of the KMS key that is used by the data disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40826X</para>
                        /// </summary>
                        [NameInMap("DataDiskKMSKeyId")]
                        [Validation(Required=false)]
                        public string DataDiskKMSKeyId { get; set; }

                        /// <summary>
                        /// <para>The performance level of the ESSD used as the data disk. The parameter is returned only when the DataDisks.N.DataDiskCategory parameter is set to cloud_essd. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>PL0: An ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
                        /// <item><description>PL1: An ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
                        /// <item><description>PL2: An ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
                        /// <item><description>PL3: An ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PL1</para>
                        /// </summary>
                        [NameInMap("DataDiskPerformanceLevel")]
                        [Validation(Required=false)]
                        public string DataDiskPerformanceLevel { get; set; }

                        /// <summary>
                        /// <para>The capacity of the data disk. Unit: GB.</para>
                        /// <para>Valid values: 40 to 500.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>40</para>
                        /// </summary>
                        [NameInMap("DataDiskSize")]
                        [Validation(Required=false)]
                        public int? DataDiskSize { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the queue enabled the auto scale-out. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableAutoGrow")]
                [Validation(Required=false)]
                public bool? EnableAutoGrow { get; set; }

                /// <summary>
                /// <para>Indicates whether the queue enabled the auto scale-in. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableAutoShrink")]
                [Validation(Required=false)]
                public bool? EnableAutoShrink { get; set; }

                /// <summary>
                /// <para>The prefix of the queue name. You can query queues that have a specified prefix.</para>
                /// 
                /// <b>Example:</b>
                /// <para>compute</para>
                /// </summary>
                [NameInMap("HostNamePrefix")]
                [Validation(Required=false)]
                public string HostNamePrefix { get; set; }

                /// <summary>
                /// <para>The suffix of the queue name. You can query queues that have a specified suffix.</para>
                /// 
                /// <b>Example:</b>
                /// <para>000</para>
                /// </summary>
                [NameInMap("HostNameSuffix")]
                [Validation(Required=false)]
                public string HostNameSuffix { get; set; }

                /// <summary>
                /// <para>The instance type of the compute nodes that are automatically added to the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.sn1ne.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The specification information of the compute nodes.</para>
                /// </summary>
                [NameInMap("InstanceTypes")]
                [Validation(Required=false)]
                public GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypes InstanceTypes { get; set; }
                public class GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypes : TeaModel {
                    [NameInMap("InstanceTypeInfo")]
                    [Validation(Required=false)]
                    public List<GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypesInstanceTypeInfo> InstanceTypeInfo { get; set; }
                    public class GetAutoScaleConfigResponseBodyQueuesQueueInfoInstanceTypesInstanceTypeInfo : TeaModel {
                        /// <summary>
                        /// <para>The prefix of the hostname. You can query compute nodes that have a specified prefix.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>compute</para>
                        /// </summary>
                        [NameInMap("HostNamePrefix")]
                        [Validation(Required=false)]
                        public string HostNamePrefix { get; set; }

                        /// <summary>
                        /// <para>The instance type of the compute nodes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ecs.sn1ne.large</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The protection period of the preemptible instance. Unit: hours. Valid values: 0 to 1. Default value: 1. A value of 0 means no protection period is specified.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("SpotDuration")]
                        [Validation(Required=false)]
                        public int? SpotDuration { get; set; }

                        /// <summary>
                        /// <para>The interruption event of the preemptible instance. The value can only be Terminate, which specifies that the instance is released.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Terminate</para>
                        /// </summary>
                        [NameInMap("SpotInterruptionBehavior")]
                        [Validation(Required=false)]
                        public string SpotInterruptionBehavior { get; set; }

                        /// <summary>
                        /// <para>The maximum hourly price of the compute nodes. The value can be accurate to three decimal places. This parameter is valid only when the SpotStrategy parameter is set to SpotWithPriceLimit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.062</para>
                        /// </summary>
                        [NameInMap("SpotPriceLimit")]
                        [Validation(Required=false)]
                        public float? SpotPriceLimit { get; set; }

                        /// <summary>
                        /// <para>The bidding method of the compute nodes. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>NoSpot: The compute nodes are pay-as-you-go instances.</description></item>
                        /// <item><description>SpotWithPriceLimit: The compute nodes are preemptible instances that have a user-defined maximum hourly price.</description></item>
                        /// <item><description>SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NoSpot</para>
                        /// </summary>
                        [NameInMap("SpotStrategy")]
                        [Validation(Required=false)]
                        public string SpotStrategy { get; set; }

                        /// <summary>
                        /// <para>The ID of the vSwitch.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-bp1lfcjbfb099rrjn****</para>
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// <para>The ID of the zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-b</para>
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The maximum number of compute nodes that can be added to a queue. Valid values: 0 to 500.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxNodesInQueue")]
                [Validation(Required=false)]
                public int? MaxNodesInQueue { get; set; }

                /// <summary>
                /// <para>The maximum number of compute nodes that can be added in each round of scale-out. Valid values: 0 to 99.</para>
                /// <para>Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("MaxNodesPerCycle")]
                [Validation(Required=false)]
                public long? MaxNodesPerCycle { get; set; }

                /// <summary>
                /// <para>The minimum number of compute nodes that can be retained in a queue. Valid values: 0 to 50.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MinNodesInQueue")]
                [Validation(Required=false)]
                public int? MinNodesInQueue { get; set; }

                /// <summary>
                /// <para>The minimum number of compute nodes that can be added in each round of scale-out. Valid values: 1 to 99</para>
                /// <para>Default value: 1.</para>
                /// <para>If the compute nodes that you want to add in a round is less than the minimum compute nodes that can be added, the value of this parameter is automatically changed to the number of compute nodes that you want to add. This ensures that compute nodes can be added as expected.</para>
                /// <remarks>
                /// <para> The configuration takes effect only for the minimum compute nodes that can be added in the current round.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MinNodesPerCycle")]
                [Validation(Required=false)]
                public long? MinNodesPerCycle { get; set; }

                /// <summary>
                /// <para>The image ID of the compute node in the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_7_06_64_20G_alibase_2019071****</para>
                /// </summary>
                [NameInMap("QueueImageId")]
                [Validation(Required=false)]
                public string QueueImageId { get; set; }

                /// <summary>
                /// <para>The name of the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workq</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the compute nodes belong.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxp7uc24****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the instances are unordered. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <remarks>
                /// <para> If this parameter is set to true, the system selects instance types in descending order based on the number of instances in stock during auto scaling.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SortedByInventory")]
                [Validation(Required=false)]
                public bool? SortedByInventory { get; set; }

                /// <summary>
                /// <para>The maximum hourly price of the compute nodes. The value can be accurate to three decimal places. This parameter is valid only when the SpotStrategy parameter is set to SpotWithPriceLimit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.062</para>
                /// </summary>
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                /// <summary>
                /// <para>The preemption policy of the compute nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoSpot: The compute nodes are pay-as-you-go instances.</description></item>
                /// <item><description>SpotWithPriceLimit: The compute nodes are preemptible instances that have a user-defined maximum hourly price.</description></item>
                /// <item><description>SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// <para>The category of the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_efficiency: ultra disk.</description></item>
                /// <item><description>cloud_ssd: standard SSD.</description></item>
                /// <item><description>cloud_essd: enhanced SSD (ESSD).</description></item>
                /// <item><description>cloud: basic disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("SystemDiskCategory")]
                [Validation(Required=false)]
                public string SystemDiskCategory { get; set; }

                /// <summary>
                /// <para>The performance level of the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0: An ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
                /// <item><description>PL1: An ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
                /// <item><description>PL2: An ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
                /// <item><description>PL3: An ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("SystemDiskLevel")]
                [Validation(Required=false)]
                public string SystemDiskLevel { get; set; }

                /// <summary>
                /// <para>The system disk size. Unit: GB. Valid values: 40 to 500.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

            }

        }

        /// <summary>
        /// <para>The image ID of the compute nodes in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The suffix of the queue name. You can query queues that have a specified suffix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ShrinkIdleTimes")]
        [Validation(Required=false)]
        public int? ShrinkIdleTimes { get; set; }

        /// <summary>
        /// <para>The auto scaling configuration of the queue.</para>
        /// <remarks>
        /// <para> If auto scaling is enabled for the cluster and queue at the same time, the queue settings prevail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ShrinkIntervalInMinutes")]
        [Validation(Required=false)]
        public int? ShrinkIntervalInMinutes { get; set; }

        /// <summary>
        /// <para>The type of the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_efficiency: ultra disk</description></item>
        /// <item><description>cloud_ssd: SSD</description></item>
        /// <item><description>cloud_essd: ESSD</description></item>
        /// <item><description>cloud: basic disk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0.062</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The percentage of extra compute nodes. Valid values: 0 to 100.</para>
        /// <para>If you need to add 100 compute nodes and the value of the ExtraNodesGrowRatio parameter is 2, 102 compute nodes are added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SpotWithPriceLimit</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The size of the system disk. Unit: GB. Valid values: 40 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>129845258050****</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
