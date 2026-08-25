// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeAutoScalingConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The elastic scaling feature configuration of the instance.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAutoScalingConfigResponseBodyData Data { get; set; }
        public class DescribeAutoScalingConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The bandwidth elastic scaling feature configuration of the instance.</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataBandwidth Bandwidth { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataBandwidth : TeaModel {
                /// <summary>
                /// <para>The average bandwidth usage threshold that triggers automatic bandwidth downgrade. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("BandwidthUsageLowerThreshold")]
                [Validation(Required=false)]
                public int? BandwidthUsageLowerThreshold { get; set; }

                /// <summary>
                /// <para>The average bandwidth usage threshold that triggers automatic bandwidth upgrade. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("BandwidthUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? BandwidthUsageUpperThreshold { get; set; }

                /// <summary>
                /// <para>Indicates whether automatic bandwidth downgrade is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Downgrade")]
                [Validation(Required=false)]
                public bool? Downgrade { get; set; }

                /// <summary>
                /// <para>The observation window for automatic bandwidth upgrade. The value consists of a number and a time unit suffix. The time unit suffixes are:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para>For example, <b>5m</b> indicates 5 minutes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5m</para>
                /// </summary>
                [NameInMap("ObservationWindowSize")]
                [Validation(Required=false)]
                public string ObservationWindowSize { get; set; }

                /// <summary>
                /// <para>Indicates whether automatic bandwidth upgrade is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
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
            /// <para>The local resource elastic scaling feature configuration of the instance.</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataResource Resource { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataResource : TeaModel {
                /// <summary>
                /// <para>The CPU scale-up increment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CpuStep")]
                [Validation(Required=false)]
                public int? CpuStep { get; set; }

                /// <summary>
                /// <para>The average CPU utilization threshold that triggers automatic local resource scale-up. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("CpuUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? CpuUsageUpperThreshold { get; set; }

                /// <summary>
                /// <para>The scale-down observation window. The value consists of a number and a time unit suffix. The time unit suffixes are:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para>For example, <b>5m</b> indicates 5 minutes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5m</para>
                /// </summary>
                [NameInMap("DowngradeObservationWindowSize")]
                [Validation(Required=false)]
                public string DowngradeObservationWindowSize { get; set; }

                /// <summary>
                /// <para>Indicates whether local resource elastic scaling is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The scale-up observation window. The value consists of a number and a time unit suffix. The time unit suffixes are:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para>For example, <b>5m</b> indicates 5 minutes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5m</para>
                /// </summary>
                [NameInMap("UpgradeObservationWindowSize")]
                [Validation(Required=false)]
                public string UpgradeObservationWindowSize { get; set; }

            }

            /// <summary>
            /// <para>The shard elastic scaling feature configuration of the instance.</para>
            /// </summary>
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataShard Shard { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataShard : TeaModel {
                /// <summary>
                /// <para>Indicates whether automatic shard removal is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Downgrade")]
                [Validation(Required=false)]
                public bool? Downgrade { get; set; }

                /// <summary>
                /// <para>The observation window for automatic shard removal. The value consists of a number and a time unit suffix. The time unit suffixes are:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para>For example, <b>1d</b> indicates 1 day.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1d</para>
                /// </summary>
                [NameInMap("DowngradeObservationWindowSize")]
                [Validation(Required=false)]
                public string DowngradeObservationWindowSize { get; set; }

                /// <summary>
                /// <para>The maximum total number of shards for the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("MaxShards")]
                [Validation(Required=false)]
                public int? MaxShards { get; set; }

                /// <summary>
                /// <para>The average memory utilization threshold that triggers automatic shard removal. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("MemUsageLowerThreshold")]
                [Validation(Required=false)]
                public int? MemUsageLowerThreshold { get; set; }

                /// <summary>
                /// <para>The average memory utilization threshold that triggers automatic shard addition. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("MemUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? MemUsageUpperThreshold { get; set; }

                /// <summary>
                /// <para>The minimum total number of shards for the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MinShards")]
                [Validation(Required=false)]
                public int? MinShards { get; set; }

                /// <summary>
                /// <para>Indicates whether automatic shard addition is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Upgrade")]
                [Validation(Required=false)]
                public bool? Upgrade { get; set; }

                /// <summary>
                /// <para>The observation window for automatic shard addition. The value consists of a number and a time unit suffix. The time unit suffixes are:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para>For example, <b>5m</b> indicates 5 minutes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5m</para>
                /// </summary>
                [NameInMap("UpgradeObservationWindowSize")]
                [Validation(Required=false)]
                public string UpgradeObservationWindowSize { get; set; }

            }

            /// <summary>
            /// <para>The specification elastic scaling feature configuration.</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataSpec Spec { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataSpec : TeaModel {
                /// <summary>
                /// <para>The cool-down period. The value consists of a number and a time unit suffix. The time unit suffixes are:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para>For example, <b>5m</b> indicates 5 minutes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5m</para>
                /// </summary>
                [NameInMap("CoolDownTime")]
                [Validation(Required=false)]
                public string CoolDownTime { get; set; }

                /// <summary>
                /// <para>The average CPU utilization threshold that triggers automatic specification scale-up. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("CpuUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? CpuUsageUpperThreshold { get; set; }

                /// <summary>
                /// <para>Indicates whether automatic specification scale-down is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Downgrade")]
                [Validation(Required=false)]
                public bool? Downgrade { get; set; }

                /// <summary>
                /// <para>The maximum number of read-only nodes for the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxReadOnlyNodes")]
                [Validation(Required=false)]
                public int? MaxReadOnlyNodes { get; set; }

                /// <summary>
                /// <para>The maximum specification for automatic scale-up. For details, refer to the product specification documentation for each database instance:
                /// &lt;props=&quot;china&quot;&gt;</para>
                /// <list type="bullet">
                /// <item><description>For PolarDB for MySQL Cluster Edition, see <a href="https://help.aliyun.com/document_detail/102542.html">Compute node specifications</a>.</description></item>
                /// <item><description>For ApsaraDB RDS for MySQL high-availability series with cloud disks, see <a href="https://help.aliyun.com/document_detail/276974.html">Product specifications</a>.</description></item>
                /// <item><description>For Redis community cloud disk edition, see <a href="https://help.aliyun.com/document_detail/144986.html">Instance specifications</a>.</description></item>
                /// </list>
                /// <para>&lt;props=&quot;intl&quot;&gt;</para>
                /// <list type="bullet">
                /// <item><description>For PolarDB for MySQL Cluster Edition, see <a href="https://help.aliyun.com/document_detail/102542.html">Compute node specifications</a>.</description></item>
                /// <item><description>For ApsaraDB RDS for MySQL high-availability series with cloud disks, see <a href="https://help.aliyun.com/document_detail/276974.html">Product specifications</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>polar.mysql.x8.12xlarge</para>
                /// </summary>
                [NameInMap("MaxSpec")]
                [Validation(Required=false)]
                public string MaxSpec { get; set; }

                /// <summary>
                /// <para>The average memory utilization threshold that triggers automatic specification scale-up. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("MemUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? MemUsageUpperThreshold { get; set; }

                /// <summary>
                /// <para>The observation window. The value consists of a number and a time unit suffix. The time unit suffixes are:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para>For example, <b>5m</b> indicates 5 minutes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5m</para>
                /// </summary>
                [NameInMap("ObservationWindowSize")]
                [Validation(Required=false)]
                public string ObservationWindowSize { get; set; }

                /// <summary>
                /// <para>Indicates whether automatic specification scale-up is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
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
            /// <para>The Automatic storage scaling feature configuration of the instance.</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataStorage Storage { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataStorage : TeaModel {
                /// <summary>
                /// <para>The average storage utilization threshold that triggers automatic storage scaling. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("DiskUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? DiskUsageUpperThreshold { get; set; }

                /// <summary>
                /// <para>The maximum storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32000</para>
                /// </summary>
                [NameInMap("MaxStorage")]
                [Validation(Required=false)]
                public int? MaxStorage { get; set; }

                /// <summary>
                /// <para>Indicates whether automatic storage scaling is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Upgrade")]
                [Validation(Required=false)]
                public bool? Upgrade { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
