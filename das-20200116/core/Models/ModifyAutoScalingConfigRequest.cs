// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifyAutoScalingConfigRequest : TeaModel {
        /// <summary>
        /// <para>The configuration items for the bandwidth elastic scaling feature.</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestBandwidth Bandwidth { get; set; }
        public class ModifyAutoScalingConfigRequestBandwidth : TeaModel {
            /// <summary>
            /// <para>Specifies whether to apply the configurations under the <b>Bandwidth</b> configuration item for the bandwidth elastic scaling feature:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// <para>The threshold of average bandwidth usage that triggers automatic bandwidth downgrade. Unit: %. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>10</b></description></item>
            /// <item><description><b>20</b></description></item>
            /// <item><description><b>30</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("BandwidthUsageLowerThreshold")]
            [Validation(Required=false)]
            public int? BandwidthUsageLowerThreshold { get; set; }

            /// <summary>
            /// <para>The threshold of average bandwidth usage that triggers automatic bandwidth upgrade. Unit: %. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>50</b></description></item>
            /// <item><description><b>60</b></description></item>
            /// <item><description><b>70</b></description></item>
            /// <item><description><b>80</b></description></item>
            /// <item><description><b>90</b></description></item>
            /// <item><description><b>95</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("BandwidthUsageUpperThreshold")]
            [Validation(Required=false)]
            public int? BandwidthUsageUpperThreshold { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic bandwidth downgrade:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Downgrade")]
            [Validation(Required=false)]
            public bool? Downgrade { get; set; }

            /// <summary>
            /// <para>The observation window for automatic bandwidth upgrade. The parameter value consists of a number and a time unit suffix. The time suffix <b>m</b> indicates minutes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1m</b></description></item>
            /// <item><description><b>5m</b></description></item>
            /// <item><description><b>10m</b></description></item>
            /// <item><description><b>15m</b></description></item>
            /// <item><description><b>30m</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5m</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("ObservationWindowSize")]
            [Validation(Required=false)]
            public string ObservationWindowSize { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic bandwidth upgrade:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Upgrade")]
            [Validation(Required=false)]
            public bool? Upgrade { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The configuration items for the resource elastic scaling feature.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestResource Resource { get; set; }
        public class ModifyAutoScalingConfigRequestResource : TeaModel {
            /// <summary>
            /// <para>Specifies whether to apply the configurations under the <b>Resource</b> configuration item for the resource elastic scaling feature:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// <para>The threshold of average CPU utilization that triggers automatic resource scale-up. Unit: %. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>70</b></description></item>
            /// <item><description><b>80</b></description></item>
            /// <item><description><b>90</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("CpuUsageUpperThreshold")]
            [Validation(Required=false)]
            public int? CpuUsageUpperThreshold { get; set; }

            /// <summary>
            /// <para>The observation window for scale-down. The parameter value consists of a number and a time unit suffix. The time suffix <b>m</b> indicates minutes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1m</b></description></item>
            /// <item><description><b>3m</b></description></item>
            /// <item><description><b>5m</b></description></item>
            /// <item><description><b>10m</b></description></item>
            /// <item><description><b>20m</b></description></item>
            /// <item><description><b>30m</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5m</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("DowngradeObservationWindowSize")]
            [Validation(Required=false)]
            public string DowngradeObservationWindowSize { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable resource elastic scaling:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The observation window for scale-up. The parameter value consists of a number and a time unit suffix. The time suffix <b>m</b> indicates minutes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1m</b></description></item>
            /// <item><description><b>3m</b></description></item>
            /// <item><description><b>5m</b></description></item>
            /// <item><description><b>10m</b></description></item>
            /// <item><description><b>20m</b></description></item>
            /// <item><description><b>30m</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5m</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("UpgradeObservationWindowSize")]
            [Validation(Required=false)]
            public string UpgradeObservationWindowSize { get; set; }

        }

        /// <summary>
        /// <para>The configuration items for the shard elastic scaling feature.</para>
        /// </summary>
        [NameInMap("Shard")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestShard Shard { get; set; }
        public class ModifyAutoScalingConfigRequestShard : TeaModel {
            /// <summary>
            /// <para>Specifies whether to apply the configurations under the <b>Shard</b> configuration item for the shard elastic scaling feature:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: The shard elastic scaling feature is supported only when the target database instance is Tair (Redis® OSS-Compatible) cloud-native (formerly cloud disk) edition in cluster architecture on the China site.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic shard reduction:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The automatic shard reduction feature is currently in canary release.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Downgrade")]
            [Validation(Required=false)]
            public bool? Downgrade { get; set; }

            /// <summary>
            /// <para>The observation window for automatic shard reduction. The parameter value consists of a number and a time unit suffix. The time suffix <b>h</b> indicates hours, and <b>d</b> indicates days. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1h</b></description></item>
            /// <item><description><b>2h</b></description></item>
            /// <item><description><b>3h</b></description></item>
            /// <item><description><b>1d</b></description></item>
            /// <item><description><b>7d</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1h</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("DowngradeObservationWindowSize")]
            [Validation(Required=false)]
            public string DowngradeObservationWindowSize { get; set; }

            /// <summary>
            /// <para>The maximum total number of shards for the instance. The value must be a positive integer. Valid values: 4 to 32.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("MaxShards")]
            [Validation(Required=false)]
            public int? MaxShards { get; set; }

            /// <summary>
            /// <para>The threshold of average memory utilization that triggers automatic shard reduction. Unit: %. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>10</b></description></item>
            /// <item><description><b>20</b></description></item>
            /// <item><description><b>30</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("MemUsageLowerThreshold")]
            [Validation(Required=false)]
            public int? MemUsageLowerThreshold { get; set; }

            /// <summary>
            /// <para>The threshold of average memory utilization that triggers automatic shard addition. Unit: %. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>50</b></description></item>
            /// <item><description><b>60</b></description></item>
            /// <item><description><b>70</b></description></item>
            /// <item><description><b>80</b></description></item>
            /// <item><description><b>90</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("MemUsageUpperThreshold")]
            [Validation(Required=false)]
            public int? MemUsageUpperThreshold { get; set; }

            /// <summary>
            /// <para>The minimum total number of shards for the instance. The value must be a positive integer. Valid values: 4 to 32.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("MinShards")]
            [Validation(Required=false)]
            public int? MinShards { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic shard addition:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Upgrade")]
            [Validation(Required=false)]
            public bool? Upgrade { get; set; }

            /// <summary>
            /// <para>The observation window for automatic shard addition. The parameter value consists of a number and a time unit suffix. The time suffix <b>m</b> indicates minutes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>5m</b></description></item>
            /// <item><description><b>10m</b></description></item>
            /// <item><description><b>15m</b></description></item>
            /// <item><description><b>30m</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5m</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("UpgradeObservationWindowSize")]
            [Validation(Required=false)]
            public string UpgradeObservationWindowSize { get; set; }

        }

        /// <summary>
        /// <para>The configuration items for the specification elastic scaling feature.</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestSpec Spec { get; set; }
        public class ModifyAutoScalingConfigRequestSpec : TeaModel {
            /// <summary>
            /// <para>Specifies whether to apply the configurations under the <b>Spec</b> configuration item for the specification elastic scaling feature:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// <para>The cool-down period. The parameter value consists of a number and a time unit suffix. The supported database instances and valid values are as follows. The time suffix <b>m</b> indicates minutes, <b>h</b> indicates hours, and <b>d</b> indicates days:</para>
            /// <list type="bullet">
            /// <item><description>PolarDB for MySQL Cluster Edition: <b>5m</b>, <b>10m</b>, <b>30m</b>, <b>1h</b>, <b>2h</b>, <b>3h</b>, <b>1d</b>, and <b>7d</b>.</description></item>
            /// <item><description>ApsaraDB RDS for MySQL high availability series cloud disk edition: <b>5m</b>, <b>10m</b>, <b>30m</b>, <b>1h</b>, <b>2h</b>, <b>3h</b>, <b>1d</b>, and <b>7d</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5m</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("CoolDownTime")]
            [Validation(Required=false)]
            public string CoolDownTime { get; set; }

            /// <summary>
            /// <para>The threshold of average CPU utilization that triggers automatic specification scale-up. Unit: %. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>50</b></description></item>
            /// <item><description><b>60</b></description></item>
            /// <item><description><b>70</b></description></item>
            /// <item><description><b>80</b></description></item>
            /// <item><description><b>90</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: You must set this parameter when the target database instance is PolarDB for MySQL Cluster Edition or ApsaraDB RDS for MySQL high availability series cloud disk edition.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("CpuUsageUpperThreshold")]
            [Validation(Required=false)]
            public int? CpuUsageUpperThreshold { get; set; }

            /// <summary>
            /// <para>Specifies whether automatic specification scale-down is enabled:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: You must set this parameter when the target database instance is PolarDB for MySQL Cluster Edition or ApsaraDB RDS for MySQL high availability series cloud disk edition.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("Downgrade")]
            [Validation(Required=false)]
            public bool? Downgrade { get; set; }

            /// <summary>
            /// <para>The maximum number of read-only nodes for the instance.</para>
            /// <remarks>
            /// <para>Notice: You must set this parameter when the target database instance is PolarDB for MySQL Cluster Edition.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("MaxReadOnlyNodes")]
            [Validation(Required=false)]
            public int? MaxReadOnlyNodes { get; set; }

            /// <summary>
            /// <para>The upper limit of the specification for automatic scale-up. You can only scale up to a higher specification within the same series of the database instance. For more details, see the specification documentation for each database instance:
            /// &lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>For PolarDB for MySQL Cluster Edition, see <a href="https://help.aliyun.com/document_detail/102542.html">Compute node specifications</a>.</description></item>
            /// <item><description>For ApsaraDB RDS for MySQL high availability series cloud disk edition, see <a href="https://help.aliyun.com/document_detail/276974.html">Product specifications</a>.</description></item>
            /// <item><description>For Tair (Redis® OSS-Compatible) cloud-native (formerly cloud disk) open-source edition, see <a href="https://help.aliyun.com/document_detail/144986.html">Instance specifications</a>.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>For PolarDB for MySQL Cluster Edition, see <a href="https://help.aliyun.com/document_detail/102542.html">Compute node specifications</a>.</description></item>
            /// <item><description>For ApsaraDB RDS for MySQL high availability series cloud disk edition, see <a href="https://help.aliyun.com/document_detail/276974.html">Product specifications</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x8.12xlarge</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("MaxSpec")]
            [Validation(Required=false)]
            public string MaxSpec { get; set; }

            /// <summary>
            /// <para>The threshold of average memory utilization that triggers automatic specification scale-up. Unit: %. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>50</b></description></item>
            /// <item><description><b>60</b></description></item>
            /// <item><description><b>70</b></description></item>
            /// <item><description><b>80</b></description></item>
            /// <item><description><b>90</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: You must set this parameter when the target database instance is Tair (Redis® OSS-Compatible) cloud-native (formerly cloud disk) open-source edition on the China site.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("MemUsageUpperThreshold")]
            [Validation(Required=false)]
            public int? MemUsageUpperThreshold { get; set; }

            /// <summary>
            /// <para>The observation window. The parameter value consists of a number and a time unit suffix. The supported database instances and valid values are as follows. The time suffix <b>m</b> indicates minutes, and <b>h</b> indicates hours:</para>
            /// <list type="bullet">
            /// <item><description>PolarDB for MySQL Cluster Edition: <b>5m</b>, <b>10m</b>, <b>15m</b>, and <b>30m</b>.</description></item>
            /// <item><description>ApsaraDB RDS for MySQL high availability series cloud disk edition: <b>5m</b>, <b>20m</b>, <b>30m</b>, <b>40m</b>, and <b>1h</b>.</description></item>
            /// <item><description>Tair (Redis® OSS-Compatible) cloud-native (formerly cloud disk) open-source edition: <b>5m</b>, <b>10m</b>, <b>15m</b>, and <b>30m</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5m</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("ObservationWindowSize")]
            [Validation(Required=false)]
            public string ObservationWindowSize { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic specification scale-up:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("Upgrade")]
            [Validation(Required=false)]
            public bool? Upgrade { get; set; }

        }

        /// <summary>
        /// <para>The configuration items for the automatic storage expansion feature.</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestStorage Storage { get; set; }
        public class ModifyAutoScalingConfigRequestStorage : TeaModel {
            /// <summary>
            /// <para>Specifies whether to apply the configurations under the <b>Storage</b> configuration item for the automatic storage expansion feature:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// <para>The threshold of average storage space utilization that triggers automatic storage expansion. Unit: %. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>50</b></description></item>
            /// <item><description><b>60</b></description></item>
            /// <item><description><b>70</b></description></item>
            /// <item><description><b>80</b></description></item>
            /// <item><description><b>90</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("DiskUsageUpperThreshold")]
            [Validation(Required=false)]
            public int? DiskUsageUpperThreshold { get; set; }

            /// <summary>
            /// <para>The upper limit of the storage space. The value must be greater than or equal to the current total storage space of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ESSD cloud disk upper limit: 32,000 GB.</description></item>
            /// <item><description>Standard SSD upper limit: 6,000 GB.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Standard SSDs are retired. <a href="https://help.aliyun.com/document_detail/314678.html">Upgrade to ESSD cloud disks</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>32000</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("MaxStorage")]
            [Validation(Required=false)]
            public int? MaxStorage { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic storage expansion:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("Upgrade")]
            [Validation(Required=false)]
            public bool? Upgrade { get; set; }

        }

    }

}
