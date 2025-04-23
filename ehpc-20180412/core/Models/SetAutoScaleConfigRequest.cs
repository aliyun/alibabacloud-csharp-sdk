// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SetAutoScaleConfigRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

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
        /// <para>Specifies whether to enable auto scale-out. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto scale-out.</description></item>
        /// <item><description>false: disables auto scale-out.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAutoGrow")]
        [Validation(Required=false)]
        public bool? EnableAutoGrow { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto scale-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto scale-in.</description></item>
        /// <item><description>false: disables auto scale-in.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAutoShrink")]
        [Validation(Required=false)]
        public bool? EnableAutoShrink { get; set; }

        /// <summary>
        /// <para>The compute nodes that are excluded from auto scaling tasks. Separate multiple compute nodes with commas (,).</para>
        /// <para>If you want to retain a compute node, you can specify the node as an additional node to retain the node when it is idle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp19lgqwxb4206t5****,i-bp1g4hvzs9pywrhb****</para>
        /// </summary>
        [NameInMap("ExcludeNodes")]
        [Validation(Required=false)]
        public string ExcludeNodes { get; set; }

        /// <summary>
        /// <para>The percentage of extra compute nodes. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// <para>If you need to add 100 compute nodes and the value of the ExtraNodesGrowRatio parameter is 2, 102 compute nodes are added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExtraNodesGrowRatio")]
        [Validation(Required=false)]
        public int? ExtraNodesGrowRatio { get; set; }

        /// <summary>
        /// <para>The interval between two consecutive rounds of scale-out. Unit: minutes.</para>
        /// <para>Valid values: 2 to 10.</para>
        /// <para>Default value: 2.</para>
        /// <remarks>
        /// <para>An interval may exist during multiple rounds of a scale-out task or between two consecutive scale-out tasks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GrowIntervalInMinutes")]
        [Validation(Required=false)]
        public int? GrowIntervalInMinutes { get; set; }

        /// <summary>
        /// <para>The percentage of each round of a scale-out task. Valid values: 1 to 100.</para>
        /// <para>Default value: 100.</para>
        /// <para>If you set GrowRatio to 50, the scale-out has two rounds. Each round completes half of the scale-out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("GrowRatio")]
        [Validation(Required=false)]
        public int? GrowRatio { get; set; }

        /// <summary>
        /// <para>The scale-out timeout period. Unit: minutes.</para>
        /// <para>Valid values: 10 to 60.</para>
        /// <para>Default value: 20.</para>
        /// <para>If the scale-out timeout period has been reached but the scale-out nodes still do not reach the Running state, the system releases them.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("GrowTimeoutInMinutes")]
        [Validation(Required=false)]
        public int? GrowTimeoutInMinutes { get; set; }

        /// <summary>
        /// <para>The IDs of the images.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If both <c>Queues.N.QueueImageId</c> and <c>ImageId</c> are specified, <c>Queues.N.QueueImageId</c> prevails.</para>
        /// </description></item>
        /// <item><description><para>If you set <c>Queues.N.QueueImageId</c> or <c>ImageId</c>, the parameter that you set takes effect.</para>
        /// </description></item>
        /// <item><description><para>If you leave both <c>Queues.N.QueueImageId</c> and <c>ImageId</c> empty, the image that was specified when you created the cluster or the last time you scaled out the cluster is used by default.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>centos_7_03_64_20G_alibase_201708****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The maximum number of compute nodes that can be added to the cluster. Valid values: 0 to 500.</para>
        /// <para>Default value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxNodesInCluster")]
        [Validation(Required=false)]
        public int? MaxNodesInCluster { get; set; }

        /// <summary>
        /// <para>The information about the queue.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Queues")]
        [Validation(Required=false)]
        public List<SetAutoScaleConfigRequestQueues> Queues { get; set; }
        public class SetAutoScaleConfigRequestQueues : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically specify the minimum number of compute nodes that can be added in each round of scale-out. If you set this parameter to true, the minimum number of nodes for each scale-out is equal to the number of nodes required by the job. The maximum number is 99.</para>
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
            public List<SetAutoScaleConfigRequestQueuesDataDisks> DataDisks { get; set; }
            public class SetAutoScaleConfigRequestQueuesDataDisks : TeaModel {
                /// <summary>
                /// <para>The category of the data disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_efficiency: ultra disk.</description></item>
                /// <item><description>cloud_ssd: standard SSD.</description></item>
                /// <item><description>cloud_essd: ESSD.</description></item>
                /// <item><description>cloud: basic disk.</description></item>
                /// </list>
                /// <para>Default value: cloud_efficiency.</para>
                /// <para>Valid values of N: 0 to 16.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("DataDiskCategory")]
                [Validation(Required=false)]
                public string DataDiskCategory { get; set; }

                /// <summary>
                /// <para>Specifies whether the data disk is released when the node is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <para>Default value: true.</para>
                /// <para>Valid values of N: 0 to 16.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DataDiskDeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DataDiskDeleteWithInstance { get; set; }

                /// <summary>
                /// <para>Specifies whether to encrypt the data disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// <para>Valid values of N: 0 to 16.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DataDiskEncrypted")]
                [Validation(Required=false)]
                public bool? DataDiskEncrypted { get; set; }

                /// <summary>
                /// <para>The Key Management Service (KMS) key ID of the data disk.</para>
                /// <para>Valid values of N: 0 to 16.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40826X</para>
                /// </summary>
                [NameInMap("DataDiskKMSKeyId")]
                [Validation(Required=false)]
                public string DataDiskKMSKeyId { get; set; }

                /// <summary>
                /// <para>The performance level of the ESSD used as the data disk. The parameter takes effect only when the Queues.N.DataDisks.N.DataDiskCategory parameter is set to cloud_essd. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0: An ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
                /// <item><description>PL1: An ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
                /// <item><description>PL2: An ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
                /// <item><description>PL3: An ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
                /// </list>
                /// <para>Default value: PL1.</para>
                /// <para>Valid values of N: 0 to 16.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("DataDiskPerformanceLevel")]
                [Validation(Required=false)]
                public string DataDiskPerformanceLevel { get; set; }

                /// <summary>
                /// <para>The size of the data disk. Unit: GB.</para>
                /// <para>Valid values: 40 to 500.</para>
                /// <para>Default value: 40.</para>
                /// <para>Valid values of N: 0 to 16.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("DataDiskSize")]
                [Validation(Required=false)]
                public int? DataDiskSize { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the queue enables auto scale-out. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables auto scale-out.</description></item>
            /// <item><description>false: disables auto scale-out.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 8.</para>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableAutoGrow")]
            [Validation(Required=false)]
            public bool? EnableAutoGrow { get; set; }

            /// <summary>
            /// <para>Specifies whether the queue enables auto scale-in. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables auto scale-in.</description></item>
            /// <item><description>false: disables auto scale-in.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 8.</para>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableAutoShrink")]
            [Validation(Required=false)]
            public bool? EnableAutoShrink { get; set; }

            /// <summary>
            /// <para>The hostname prefix of the host that is used to perform scale-out for the queue. You can manage compute nodes that have a specified hostname prefix.</para>
            /// <para>Valid values of N: 1 to 8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>compute</para>
            /// </summary>
            [NameInMap("HostNamePrefix")]
            [Validation(Required=false)]
            public string HostNamePrefix { get; set; }

            /// <summary>
            /// <para>The hostname suffix of the host that is used to perform scale-out for the queue. You can manage nodes that have a specified hostname suffix.</para>
            /// <para>Valid values of N: 1 to 8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>000</para>
            /// </summary>
            [NameInMap("HostNameSuffix")]
            [Validation(Required=false)]
            public string HostNameSuffix { get; set; }

            /// <summary>
            /// <para>The instance type of the compute nodes that are automatically added to the queue. Valid values of N: 1 to 8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.n1.medium</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The instance types of the nodes in the queue.</para>
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<SetAutoScaleConfigRequestQueuesInstanceTypes> InstanceTypes { get; set; }
            public class SetAutoScaleConfigRequestQueuesInstanceTypes : TeaModel {
                /// <summary>
                /// <para>The instance type of the compute nodes that are automatically added to the queue.</para>
                /// <para>You can specify the specification for 1 to 8 nodes.</para>
                /// <para>The instance types of N compute nodes in the queue can be set at the same time when auto scaling is performed in the queue. Valid values of N: 0 to 500.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.n1.tiny</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The protection period of the preemptible instance. Unit: hours. Valid values: 0 to 1. A value of 0 means that no protection period is specified. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SpotDuration")]
                [Validation(Required=false)]
                public int? SpotDuration { get; set; }

                /// <summary>
                /// <para>The interruption mode of the preemptible instance. The value can only be Terminate, which indicates that the instance is released.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Terminate</para>
                /// </summary>
                [NameInMap("SpotInterruptionBehavior")]
                [Validation(Required=false)]
                public string SpotInterruptionBehavior { get; set; }

                /// <summary>
                /// <para>The maximum hourly price of the compute nodes that are automatically added to the queue. The value can be accurate to three decimal places. The parameter takes effect only when <c>Queues.N.InstanceTypes.N.SpotStrategy</c> is set to <c>SpotWithPriceLimit</c>.</para>
                /// <para>You can specify the maximum hourly price for 1 to 8 compute nodes.</para>
                /// <para>The maximum hourly prices of N compute nodes in the queue can be set at the same time when auto scaling is performed in the queue. Valid values of N: 0 to 500.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.660</para>
                /// </summary>
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                /// <summary>
                /// <para>The preemption policy for the compute node that is automatically added to the queue. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoSpot: The compute node is created as a pay-as-you-go instance.</description></item>
                /// <item><description>SpotWithPriceLimit: The compute node is created as a preemptible instance that has a user-defined maximum hourly price.</description></item>
                /// <item><description>SpotAsPriceGo: The compute node is created as a preemptible instance for which the market price at the time of purchase is used as the bid price.</description></item>
                /// </list>
                /// <para>Default value: NoSpot.</para>
                /// <para>You can specify the preemption policy for 1 to 8 compute nodes.</para>
                /// <para>The preemption policies of N compute nodes in the queue can be set at the same time when auto scaling is performed in the queue. Valid values of N: 0 to 500.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SpotWithPriceLimit</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// <para>The vSwitch ID of the compute nodes that are automatically added to the queue.</para>
                /// <para>You can specify 1 to 8 IDs.</para>
                /// <para>The vSwitch IDs of N compute nodes in the queue can be set at the same time when auto scaling is performed in the queue. Valid values of N: 0 to 500.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1lfcjbfb099rrjn****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the zone that compute nodes automatically added to the queue belong.</para>
                /// <para>You can specify 1 to 8 IDs.</para>
                /// <para>The zone IDs of N compute nodes in the queue can be set at the same time when auto scaling is performed in the queue. Valid values of N: 0 to 500.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of compute nodes that can be added to the queue. Valid values: 0 to 500.</para>
            /// <para>Valid values of N: 1 to 8.</para>
            /// <para>Default value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
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
            /// <para>The minimum number of compute nodes that can be removed from the queue. Valid values: 0 to 50.</para>
            /// <para>Valid values of N: 1 to 8.</para>
            /// <para>Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MinNodesInQueue")]
            [Validation(Required=false)]
            public int? MinNodesInQueue { get; set; }

            /// <summary>
            /// <para>The minimum number of compute nodes that can be added in each round of scale-out. Valid values: 1 to 99</para>
            /// <para>Default value: 1.</para>
            /// <para>If the number of compute nodes that you want to add in a round is less than the value of this property, the system automatically changes the value of this property to the number of compute nodes that you want to add in a round. This helps ensure that compute nodes can be added as expected.</para>
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
            /// <para>The image ID of the queue where the scale-out is performed. Valid values of N: 1 to 8.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>If you set both <c>Queues.N.QueueImageId</c> and <c>ImageId</c>, <c>Queues.N.QueueImageId</c> prevails.</para>
            /// </description></item>
            /// <item><description><para>If you set <c>Queues.N.QueueImageId</c> or <c>ImageId</c>, the parameter that you set takes effect.</para>
            /// </description></item>
            /// <item><description><para>If you leave both <c>Queues.N.QueueImageId</c> and <c>ImageId</c> empty, the image that was specified when you created the cluster or the last time when you scaled out the cluster is used by default.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>centos_7_03_64_20G_alibase_201708****</para>
            /// </summary>
            [NameInMap("QueueImageId")]
            [Validation(Required=false)]
            public string QueueImageId { get; set; }

            /// <summary>
            /// <para>The name of the queue. You can specify 1 to 8 names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster1</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>Specifies whether the instances are unordered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <remarks>
            /// <para> If you set this parameter to true, the system selects instance types in descending order of the number of instances in stock during auto scaling.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SortedByInventory")]
            [Validation(Required=false)]
            public bool? SortedByInventory { get; set; }

            /// <summary>
            /// <para>The maximum hourly price of the compute nodes that are automatically added to the queue. The value can be accurate to three decimal places. The parameter takes effect only when <c>Queues.N.SpotStrategy</c> is set to <c>SpotWithPriceLimit</c>.</para>
            /// <para>Valid values of N: 1 to 8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.662</para>
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

            /// <summary>
            /// <para>The preemption policy of the compute node that is automatically added to the queue. Valid values of N: 1 to 8.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSpot: The compute node is created as a pay-as-you-go instance.</description></item>
            /// <item><description>SpotWithPriceLimit: The compute node is created as a preemptible instance that has a user-defined maximum hourly price.</description></item>
            /// <item><description>SpotAsPriceGo: The compute node is created as a preemptible instance for which the market price at the time of purchase is used as the bid price.</description></item>
            /// </list>
            /// <para>Default value: NoSpot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The category of the system disk specified for the compute nodes that are added to the queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: enhanced SSD (ESSD).</description></item>
            /// <item><description>cloud: basic disk. Disks of this type are retired.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 8.</para>
            /// <para>Default value: cloud_efficiency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The performance level of the system disk specified for the compute nodes that are added to the queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: An ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: An ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: An ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: An ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 8.</para>
            /// <para>Default value: PL1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("SystemDiskLevel")]
            [Validation(Required=false)]
            public string SystemDiskLevel { get; set; }

            /// <summary>
            /// <para>The size of the system disk specified for the compute nodes that are added to the queue. Unit: GB.</para>
            /// <para>Valid values: 40 to 500.</para>
            /// <para>Valid values of N: 1 to 8.</para>
            /// <para>Default value: 40.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        /// <summary>
        /// <para>The number of consecutive times that a compute node is idle during the resource scale-in check.</para>
        /// <para>Valid values: 2 to 5.</para>
        /// <para>Default value: 3.</para>
        /// <para>If the parameter is set to 3, a compute node is idle more than three consecutive times. In this case, the node is released. If a compute node is idle for longer than 6 minutes continuously, it is released by default. This is because the default value of the ShrinkIntervalInMinutes parameter is 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ShrinkIdleTimes")]
        [Validation(Required=false)]
        public int? ShrinkIdleTimes { get; set; }

        /// <summary>
        /// <para>The interval between two consecutive rounds of scale-in. Unit: minutes.</para>
        /// <para>Valid values: 2 to 10.</para>
        /// <para>Default value: 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ShrinkIntervalInMinutes")]
        [Validation(Required=false)]
        public int? ShrinkIntervalInMinutes { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of the compute nodes. The value can be accurate to three decimal places. The parameter takes effect only when <c>SpotStrategy</c> is set to <c>SpotWithPriceLimit</c>.</para>
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
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SpotWithPriceLimit</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

    }

}
