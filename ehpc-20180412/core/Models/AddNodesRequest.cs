// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class AddNodesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allocate a public IP address to the compute nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllocatePublicAddress")]
        [Validation(Required=false)]
        public bool? AllocatePublicAddress { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. The parameter takes effect only when EcsChargeType is set to PrePaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto-renewal</description></item>
        /// <item><description>false: disables auto-renewal</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period of the subscription compute nodes. The parameter takes effect when AutoRenew is set to true.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when PeriodUnit is set to Week: 1, 2, and 3.</description></item>
        /// <item><description>Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, and 12.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How do I ensure the idempotence of a request?</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the E-HPC cluster.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable hyper-threading for the compute node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ComputeEnableHt")]
        [Validation(Required=false)]
        public bool? ComputeEnableHt { get; set; }

        /// <summary>
        /// <para>The protection period of the preemptible instance. Unit: hours. Valid values: 0 and 1. A value of 0 indicates that the preemptible instance has no protection period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ComputeSpotDuration")]
        [Validation(Required=false)]
        public int? ComputeSpotDuration { get; set; }

        /// <summary>
        /// <para>The interruption mode of the preemptible instance. Default value: Terminate. Set the value to Terminate, which indicates that the instance is released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terminate</para>
        /// </summary>
        [NameInMap("ComputeSpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string ComputeSpotInterruptionBehavior { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of the compute nodes. The value can be accurate to three decimal places. The parameter only takes effect when SpotStrategy is set to SpotWithPriceLimit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.68</para>
        /// </summary>
        [NameInMap("ComputeSpotPriceLimit")]
        [Validation(Required=false)]
        public string ComputeSpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The preemption policy of the compute nodes. The parameter only takes effect when EcsChargeType is set to PostPaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instance is a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: The policy applies to preemptible instances for which a maximum hourly price is specified.</description></item>
        /// <item><description>SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("ComputeSpotStrategy")]
        [Validation(Required=false)]
        public string ComputeSpotStrategy { get; set; }

        /// <summary>
        /// <para>The number of compute nodes that you want to add. Valid values: 1 to 99. The value of this parameter is greater than that of the MinCount parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the number of available ECS instances is less than the value of the MinCount parameter, the compute nodes cannot be added.</description></item>
        /// <item><description>If the number of available ECS instances is greater than the value of the MinCount parameter and less than that of the Count parameter, the compute nodes are added based on the value of the MinCount parameter.</description></item>
        /// <item><description>If the number of available ECS instances is greater than the value of the Count parameter, the compute nodes are added based on the value of the Count parameter.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The mode in which the compute nodes are added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>manual: The compute nodes are manually added.</description></item>
        /// <item><description>autoscale: The compute nodes are automatically added.</description></item>
        /// </list>
        /// <para>Default value: manual.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manual</para>
        /// </summary>
        [NameInMap("CreateMode")]
        [Validation(Required=false)]
        public string CreateMode { get; set; }

        /// <summary>
        /// <para>The list of data disks.</para>
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<AddNodesRequestDataDisks> DataDisks { get; set; }
        public class AddNodesRequestDataDisks : TeaModel {
            /// <summary>
            /// <para>The type of the data disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk</description></item>
            /// <item><description>cloud_ssd: SSD</description></item>
            /// <item><description>cloud_essd: ESSD</description></item>
            /// <item><description>cloud: basic disk</description></item>
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
            /// <para>The KMS key ID of the data disk.</para>
            /// <para>Valid values of N: 0 to 16.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40826X</para>
            /// </summary>
            [NameInMap("DataDiskKMSKeyId")]
            [Validation(Required=false)]
            public string DataDiskKMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD used as the data disk. The parameter only takes effect only when the DataDisks.N.DataDiskCategory parameter is set to cloud_essd. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
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
        /// <para>The information about Domain Name System (DNS) settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;DnsType\&quot;:\&quot;PrivateZone\&quot;,\&quot;DnsName\&quot;:\&quot;xxxxx\&quot;}&quot;</para>
        /// </summary>
        [NameInMap("DnsConfig")]
        [Validation(Required=false)]
        public string DnsConfig { get; set; }

        /// <summary>
        /// <para>The billing method of the compute nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go</description></item>
        /// <item><description>PrePaid: subscription</description></item>
        /// </list>
        /// <para>Default value: PostPaid.</para>
        /// <para>If the parameter is set to PrePaid, auto-renewal is enabled by default. After the E-HPC cluster is released, auto-renewal is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("EcsChargeType")]
        [Validation(Required=false)]
        public string EcsChargeType { get; set; }

        /// <summary>
        /// <para>The prefix of the hostname. You can specify the parameter to manage the compute nodes in an efficient manner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>compute</para>
        /// </summary>
        [NameInMap("HostNamePrefix")]
        [Validation(Required=false)]
        public string HostNamePrefix { get; set; }

        /// <summary>
        /// <para>The suffix of the hostname. You can specify the parameter to manage the compute nodes in an efficient manner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("HostNameSuffix")]
        [Validation(Required=false)]
        public string HostNameSuffix { get; set; }

        /// <summary>
        /// <para>The ID of the image that is specified for the compute nodes. The image must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The operating system that is specified by the image must be the same as that of the existing cluster nodes. For example, if the operating system of the cluster nodes is CentOS, you can select only a CentOS image.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you add nodes to a hybrid cloud cluster that supports multiple operating systems, you can select a Windows Server image or a CentOS image when the operating system of nodes is Windows.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The major version of the image specified for the compute nodes that you want to add is the same as that of the image of the cluster. For example, if the version of the cluster image is CentOS 7.x, the version of the image specified for the compute nodes must be CentOS 7.x.</description></item>
        /// </list>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87213.html">ListImages</a> and <a href="https://help.aliyun.com/document_detail/87215.html">ListCustomImages</a> operations to query the image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos_7_06_64_20G_alibase_20190711.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The type of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: public image</description></item>
        /// <item><description>self: custom image</description></item>
        /// <item><description>others: shared image</description></item>
        /// <item><description>marketplace: Alibaba Cloud Marketplace image</description></item>
        /// </list>
        /// <para>Default value: system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// <para>The instance type of the compute nodes. The default value is the instance type that was specified when you created the E-HPC cluster or the last time when you added compute nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.n1.tiny</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The billing method of the elastic IP address (EIP). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: pay-by-bandwidth</description></item>
        /// <item><description>PayByTraffic: pay-by-traffic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum inbound public bandwidth. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the purchased outbound public bandwidth is less than or equal to 10 Mbit/s, the valid values of the parameter are 1 to 10 and the default value is 10.</description></item>
        /// <item><description>If the purchased outbound public bandwidth is greater than 10 Mbit/s, the valid values of this parameter are 1 to the amount of the outbound bandwidth that is purchased.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandWidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandWidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthOut { get; set; }

        /// <summary>
        /// <para>The queue to which the compute nodes are added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workq</para>
        /// </summary>
        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        /// <summary>
        /// <para>The minimum number of the compute nodes that you want to add. Valid values: 1 to 99. The value of the parameter is less than that of the Count parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the number of available ECS instances is less than the value of the MinCount parameter, the compute nodes cannot be added.</description></item>
        /// <item><description>If the number of available ECS instances is greater than the value of the MinCount parameter and less than that of the Count parameter, the compute nodes are added based on the value of the MinCount parameter.</description></item>
        /// <item><description>If the number of available ECS instances is greater than the value of the Count parameter, the compute nodes are added based on the value of the Count parameter.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinCount")]
        [Validation(Required=false)]
        public int? MinCount { get; set; }

        /// <summary>
        /// <para>The communication mode of the ENI. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: uses the TCP communication mode.</description></item>
        /// <item><description>HighPerformance: enables the Elastic RDMA Interface (ERI) and uses the remote direct memory access (RDMA) communication mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("NetworkInterfaceTrafficMode")]
        [Validation(Required=false)]
        public string NetworkInterfaceTrafficMode { get; set; }

        /// <summary>
        /// <para>The duration of the subscription. The unit of the duration is specified by the PeriodUnit parameter. The parameter only takes effect when InstanceChargeType is set to PrePaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid values when PeriodUnit is set to Week: 1, 2, 3, and 4.</description></item>
        /// <item><description>Valid values when PeriodUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Week</description></item>
        /// <item><description>Month</description></item>
        /// </list>
        /// <para>Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>Specifies whether to set this operation as a synchronous operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Sync")]
        [Validation(Required=false)]
        public bool? Sync { get; set; }

        /// <summary>
        /// <para>The performance level of the ESSD to be used as the system disk. Default value: PL1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
        /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <para>Default value: PL1.</para>
        /// <para>For more information about ESSD performance parameters, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("SystemDiskLevel")]
        [Validation(Required=false)]
        public string SystemDiskLevel { get; set; }

        /// <summary>
        /// <para>The size of the system disk. Unit: GiB.</para>
        /// <para>Valid values: 40 to 500.</para>
        /// <para>Default value: 40.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The type of the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_efficiency: ultra disk</description></item>
        /// <item><description>cloud_ssd: SSD</description></item>
        /// <item><description>cloud_essd: enhanced SSD (ESSD)</description></item>
        /// <item><description>cloud: basic disk. Disks of this type are retired.</description></item>
        /// </list>
        /// <para>Default value: cloud_efficiency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("SystemDiskType")]
        [Validation(Required=false)]
        public string SystemDiskType { get; set; }

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
