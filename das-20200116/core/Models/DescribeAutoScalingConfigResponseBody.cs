// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeAutoScalingConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The configurations of the auto scaling feature for instances.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAutoScalingConfigResponseBodyData Data { get; set; }
        public class DescribeAutoScalingConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configurations of the automatic bandwidth adjustment feature.</para>
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
                /// <para>The average bandwidth usage threshold that triggers automatic bandwidth adjustment. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("BandwidthUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? BandwidthUsageUpperThreshold { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic bandwidth downgrade feature is enabled. Valid values:</para>
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
                /// <para>The observation window of the automatic bandwidth adjustment feature. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para> A value of <b>5m</b> indicates 5 minutes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5m</para>
                /// </summary>
                [NameInMap("ObservationWindowSize")]
                [Validation(Required=false)]
                public string ObservationWindowSize { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic bandwidth adjustment feature is enabled. Valid values:</para>
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
            /// <para>The configurations of the auto scaling feature for local resources.</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataResource Resource { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataResource : TeaModel {
                /// <summary>
                /// <para>The scale-out step size of CPU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CpuStep")]
                [Validation(Required=false)]
                public int? CpuStep { get; set; }

                /// <summary>
                /// <para>The average CPU utilization threshold that triggers automatic scale-out of local resources. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("CpuUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? CpuUsageUpperThreshold { get; set; }

                /// <summary>
                /// <para>The observation window of the automatic scale-in feature for local resources. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para> A value of <b>5m</b> indicates 5 minutes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5m</para>
                /// </summary>
                [NameInMap("DowngradeObservationWindowSize")]
                [Validation(Required=false)]
                public string DowngradeObservationWindowSize { get; set; }

                /// <summary>
                /// <para>Indicates whether the auto scaling feature is enabled for local resources. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The observation window of the automatic scale-out feature for local resources. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para> A value of <b>5m</b> indicates 5 minutes.</para>
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
            /// <para>The configurations of the auto scaling feature for shards.</para>
            /// </summary>
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataShard Shard { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataShard : TeaModel {
                /// <summary>
                /// <para>Indicates whether the feature of automatically removing shards is enabled. Valid values:</para>
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
                /// <para>The observation window of the feature of automatically removing shards. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para> A value of <b>1d</b> indicates one day.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1d</para>
                /// </summary>
                [NameInMap("DowngradeObservationWindowSize")]
                [Validation(Required=false)]
                public string DowngradeObservationWindowSize { get; set; }

                /// <summary>
                /// <para>The maximum number of shards in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("MaxShards")]
                [Validation(Required=false)]
                public int? MaxShards { get; set; }

                /// <summary>
                /// <para>The average memory usage threshold that triggers automatic removal of shards. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("MemUsageLowerThreshold")]
                [Validation(Required=false)]
                public int? MemUsageLowerThreshold { get; set; }

                /// <summary>
                /// <para>The average memory usage threshold that triggers automatic adding of shards. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("MemUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? MemUsageUpperThreshold { get; set; }

                /// <summary>
                /// <para>The minimum number of shards in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MinShards")]
                [Validation(Required=false)]
                public int? MinShards { get; set; }

                /// <summary>
                /// <para>Indicates whether the feature of automatically adding shards is enabled. Valid values:</para>
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
                /// <para>The observation window of the feature of automatically adding shards. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para> A value of <b>5m</b> indicates 5 minutes.</para>
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
            /// <para>The configurations of the auto scaling feature for specifications.</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataSpec Spec { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataSpec : TeaModel {
                /// <summary>
                /// <para>The quiescent period. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para> A value of <b>5m</b> indicates 5 minutes.</para>
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
                /// <para>Indicates whether the automatic specification scale-down feature is enabled. Valid values:</para>
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
                /// <para>The maximum number of read-only nodes of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxReadOnlyNodes")]
                [Validation(Required=false)]
                public int? MaxReadOnlyNodes { get; set; }

                /// <summary>
                /// <para>The maximum specifications to which the cluster can be scaled up. For more information about the specifications of each type of supported database instances, see the following topics:</para>
                /// <list type="bullet">
                /// <item><description>PolarDB for MySQL Cluster Edition instances: <a href="https://help.aliyun.com/document_detail/102542.html">Compute node specifications of PolarDB for MySQL Enterprise Edition</a></description></item>
                /// <item><description>ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs: <a href="https://help.aliyun.com/document_detail/276974.html">Specifications</a></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>polar.mysql.x8.12xlarge</para>
                /// </summary>
                [NameInMap("MaxSpec")]
                [Validation(Required=false)]
                public string MaxSpec { get; set; }

                /// <summary>
                /// <para>The average memory usage threshold that triggers automatic specification scale-up. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("MemUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? MemUsageUpperThreshold { get; set; }

                /// <summary>
                /// <para>The observation window. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: seconds.</description></item>
                /// <item><description><b>m</b>: minutes.</description></item>
                /// <item><description><b>h</b>: hours.</description></item>
                /// <item><description><b>d</b>: days.</description></item>
                /// </list>
                /// <remarks>
                /// <para> A value of <b>5m</b> indicates 5 minutes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5m</para>
                /// </summary>
                [NameInMap("ObservationWindowSize")]
                [Validation(Required=false)]
                public string ObservationWindowSize { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic specification scale-up feature is enabled. Valid values:</para>
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
            /// <para>The configurations of the automatic storage expansion feature.</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataStorage Storage { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataStorage : TeaModel {
                /// <summary>
                /// <para>The average storage usage threshold that triggers automatic storage expansion. Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("DiskUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? DiskUsageUpperThreshold { get; set; }

                /// <summary>
                /// <para>The maximum storage size. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32000</para>
                /// </summary>
                [NameInMap("MaxStorage")]
                [Validation(Required=false)]
                public int? MaxStorage { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic storage expansion feature is enabled. Valid values:</para>
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

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
