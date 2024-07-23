// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifyAutoScalingConfigRequest : TeaModel {
        /// <summary>
        /// <para>The configuration item of the automatic bandwidth adjustment feature.</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestBandwidth Bandwidth { get; set; }
        public class ModifyAutoScalingConfigRequestBandwidth : TeaModel {
            /// <summary>
            /// <para>Specifies whether to apply the <b>Bandwidth</b> configuration of the automatic bandwidth adjustment feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// <para>The average bandwidth usage threshold that triggers automatic bandwidth downgrade. Unit: %. Valid values:</para>
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
            /// <para>The average bandwidth usage threshold that triggers automatic bandwidth upgrade. Unit: %. Valid values:</para>
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
            /// <para>Specifies whether to enable the automatic bandwidth downgrade feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Downgrade")]
            [Validation(Required=false)]
            public bool? Downgrade { get; set; }

            /// <summary>
            /// <para>The observation window of the automatic bandwidth adjustment feature. The value of this parameter consists of a numeric value and a time unit suffix. The <b>m</b> time unit suffix specifies the minute. Valid values:</para>
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
            /// <para>Specifies whether to enable the automatic bandwidth upgrade feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
        /// <para>The configuration item of the auto scaling feature for resources.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestResource Resource { get; set; }
        public class ModifyAutoScalingConfigRequestResource : TeaModel {
            /// <summary>
            /// <para>Specifies whether to apply the <b>Resource</b> configuration of the auto scaling feature for resources. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <para>The average CPU utilization threshold that triggers automatic scale-out of resources. Unit: %. Valid values:</para>
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
            /// <para>The observation window of the automatic resource scale-in feature. The value of this parameter consists of a numeric value and a time unit suffix. The <b>m</b> time unit suffix specifies the minute. Valid values:</para>
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
            /// <para>Specifies whether to enable the auto scaling feature for resources. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <para>The observation window of the automatic resource scale-out feature. The value of this parameter consists of a numeric value and a time unit suffix. The <b>m</b> time unit suffix specifies the minute. Valid values:</para>
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
        /// <para>The configuration item of the auto scaling feature for shards.</para>
        /// </summary>
        [NameInMap("Shard")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestShard Shard { get; set; }
        public class ModifyAutoScalingConfigRequestShard : TeaModel {
            /// <summary>
            /// <para>Specifies whether to apply the <b>Shard</b> configuration of the auto scaling feature for shards. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>The auto scaling feature for shards is available only for ApsaraDB for Redis Community Edition cloud-native instances on the China site (aliyun.com).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the feature of automatically removing shards. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> The feature of automatically removing shards is in canary release.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Downgrade")]
            [Validation(Required=false)]
            public bool? Downgrade { get; set; }

            /// <summary>
            /// <para>The observation window of the feature of automatically removing shards. The value of this parameter consists of a numeric value and a time unit suffix. The <b>h</b> time unit suffix specifies the hour. The <b>d</b> time unit suffix specifies the day. Valid values:</para>
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
            /// <para>The maximum number of shards in the instance. The value must be a positive integer. Valid values: 4 to 32.</para>
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
            /// <para>The average memory usage threshold that triggers automatic removal of shards. Unit: %. Valid values:</para>
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
            /// <para>The average memory usage threshold that triggers automatic adding of shards. Unit: %. Valid values:</para>
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
            /// <para>The minimum number of shards in the instance. The value must be a positive integer. Valid values: 4 to 32.</para>
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
            /// <para>Specifies whether to enable the feature of automatically adding shards. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Upgrade")]
            [Validation(Required=false)]
            public bool? Upgrade { get; set; }

            /// <summary>
            /// <para>The observation window of the feature of automatically adding shards. The value of this parameter consists of a numeric value and a time unit suffix. The <b>m</b> time unit suffix specifies the minute. Valid values:</para>
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
        /// <para>The configuration item of the auto scaling feature for specifications.</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestSpec Spec { get; set; }
        public class ModifyAutoScalingConfigRequestSpec : TeaModel {
            /// <summary>
            /// <para>Specifies whether to apply the <b>Spec</b> configuration of the auto scaling feature for specifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// <para>The quiescent period. The value of this parameter consists of a numeric value and a time unit suffix. The <b>m</b> time unit suffix specifies the minute, the <b>h</b> time unit suffix specifies the hour, and the <b>d</b> time suffix unit specifies the day.</para>
            /// <list type="bullet">
            /// <item><description>Valid values for PolarDB for MySQL Cluster Edition instances: <b>5m</b>, <b>10m</b>, <b>30m</b>, <b>1h</b>, <b>2h</b>, <b>3h</b>, <b>1d</b>, and <b>7d</b>.</description></item>
            /// <item><description>Valid values for ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs: <b>5m</b>, <b>10m</b>, <b>30m</b>, <b>1h</b>, <b>2h</b>, <b>3h</b>, <b>1d</b>, and <b>7d</b>.</description></item>
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
            /// <para>The average CPU utilization threshold that triggers automatic specification scale-up. Unit: %. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>50</b></description></item>
            /// <item><description><b>60</b></description></item>
            /// <item><description><b>70</b></description></item>
            /// <item><description><b>80</b></description></item>
            /// <item><description><b>90</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be specified if the database instance is a PolarDB for MySQL Cluster Edition instance or an ApsaraDB RDS for MySQL High-availability Edition instance that uses standard SSDs or ESSDs.</para>
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
            /// <para>Specifies whether to enable the automatic specification scale-down feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be specified if the database instance is a PolarDB for MySQL Cluster Edition instance or an ApsaraDB RDS for MySQL High-availability Edition instance that uses standard SSDs or ESSDs.</para>
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
            /// <para>The maximum number of read-only nodes of the instance.</para>
            /// <remarks>
            /// <para>This parameter must be specified if the database instance is a PolarDB for MySQL Cluster Edition instance.</para>
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
            /// <para>The maximum specifications to which the database instance can be scaled up. The database instance can be upgraded only to a database instance of the same edition with higher specifications. For information about the specifications of different database instances, see the following topics:</para>
            /// <list type="bullet">
            /// <item><description>PolarDB for MySQL Cluster Edition instances: <a href="https://help.aliyun.com/document_detail/102542.html">Specifications of compute nodes</a></description></item>
            /// <item><description>ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs: <a href="https://help.aliyun.com/document_detail/276974.html">Specifications</a></description></item>
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
            /// <para>The average memory usage threshold that triggers automatic specification scale-up. Unit: %. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>50</b></description></item>
            /// <item><description><b>60</b></description></item>
            /// <item><description><b>70</b></description></item>
            /// <item><description><b>80</b></description></item>
            /// <item><description><b>90</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be specified if the database instance is an ApsaraDB for Redis Community Edition cloud-native instance on the China site (aliyun.com).</para>
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
            /// <para>The observation window. The value of this parameter consists of a numeric value and a time unit suffix. The <b>m</b> time unit suffix specifies the minute and the <b>h</b> time unit suffix specifies the hour.</para>
            /// <list type="bullet">
            /// <item><description>Valid values for PolarDB for MySQL Cluster Edition instances: <b>5m</b>, <b>10m</b>, <b>15m</b>, and <b>30m</b>.</description></item>
            /// <item><description>Valid values for ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs: <b>5m</b>, <b>20m</b>, <b>30m</b>, <b>40m</b>, and <b>1h</b>.</description></item>
            /// <item><description>Valid values for ApsaraDB for Redis Community Edition cloud-native instances: <b>5m</b>, <b>10m</b>, <b>15m</b>, and <b>30m</b>.</description></item>
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
            /// <para>Specifies whether to enable the automatic specification scale-up feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
        /// <para>The configuration item of the automatic storage expansion feature.</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestStorage Storage { get; set; }
        public class ModifyAutoScalingConfigRequestStorage : TeaModel {
            /// <summary>
            /// <para>Specifies whether to apply the <b>Storage</b> configuration of the automatic storage expansion feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// <para>The average storage usage threshold that triggers automatic storage expansion. Unit: %. Valid values:</para>
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
            /// <para>The maximum storage size of the database instance. The value must be greater than or equal to the total storage size of the instance. Valid values of different types of instances:</para>
            /// <list type="bullet">
            /// <item><description>If the ApsaraDB for RDS instance uses ESSDs, the value of this parameter can be set to 32000, in GB.</description></item>
            /// <item><description>If the ApsaraDB for RDS instance uses standard SSDs, the value of this parameter can be set to 6000, in GB.</description></item>
            /// </list>
            /// <remarks>
            /// <para> The ApsaraDB RDS for MySQL instances that use standard SSDs are discontinued. We recommend that you <a href="https://help.aliyun.com/document_detail/314678.html">upgrade the storage type of an ApsaraDB RDS for MySQL instance from standard SSDs to ESSDs</a>.</para>
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
            /// <para>Specifies whether to enable the automatic storage expansion feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
