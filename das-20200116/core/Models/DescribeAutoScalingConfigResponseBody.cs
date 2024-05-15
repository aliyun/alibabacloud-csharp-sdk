// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeAutoScalingConfigResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The configurations of the auto scaling feature.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAutoScalingConfigResponseBodyData Data { get; set; }
        public class DescribeAutoScalingConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The configurations of the automatic bandwidth adjustment feature.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataBandwidth Bandwidth { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataBandwidth : TeaModel {
                /// <summary>
                /// The average bandwidth usage threshold that triggers automatic bandwidth downgrade. Unit: %.
                /// </summary>
                [NameInMap("BandwidthUsageLowerThreshold")]
                [Validation(Required=false)]
                public int? BandwidthUsageLowerThreshold { get; set; }

                /// <summary>
                /// The average bandwidth usage threshold that triggers automatic bandwidth adjustment. Unit: %.
                /// </summary>
                [NameInMap("BandwidthUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? BandwidthUsageUpperThreshold { get; set; }

                /// <summary>
                /// Indicates whether the automatic bandwidth downgrade feature is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Downgrade")]
                [Validation(Required=false)]
                public bool? Downgrade { get; set; }

                /// <summary>
                /// The observation window of the automatic bandwidth adjustment feature. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:
                /// 
                /// *   **s**: seconds.
                /// *   **m**: minutes.
                /// *   **h**: hours.
                /// *   **d**: days.
                /// 
                /// >  A value of **5m** indicates 5 minutes.
                /// </summary>
                [NameInMap("ObservationWindowSize")]
                [Validation(Required=false)]
                public string ObservationWindowSize { get; set; }

                /// <summary>
                /// Indicates whether the automatic bandwidth adjustment feature is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Upgrade")]
                [Validation(Required=false)]
                public bool? Upgrade { get; set; }

            }

            /// <summary>
            /// The configurations of the auto scaling feature for local resources.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataResource Resource { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataResource : TeaModel {
                /// <summary>
                /// The scale-out step size of CPU.
                /// </summary>
                [NameInMap("CpuStep")]
                [Validation(Required=false)]
                public int? CpuStep { get; set; }

                /// <summary>
                /// The average CPU utilization threshold that triggers automatic scale-out of local resources. Unit: %.
                /// </summary>
                [NameInMap("CpuUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? CpuUsageUpperThreshold { get; set; }

                /// <summary>
                /// The observation window of the automatic scale-in feature for local resources. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:
                /// 
                /// *   **s**: seconds.
                /// *   **m**: minutes.
                /// *   **h**: hours.
                /// *   **d**: days.
                /// 
                /// >  A value of **5m** indicates 5 minutes.
                /// </summary>
                [NameInMap("DowngradeObservationWindowSize")]
                [Validation(Required=false)]
                public string DowngradeObservationWindowSize { get; set; }

                /// <summary>
                /// Indicates whether the auto scaling feature is enabled for local resources. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// The observation window of the automatic scale-out feature for local resources. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:
                /// 
                /// *   **s**: seconds.
                /// *   **m**: minutes.
                /// *   **h**: hours.
                /// *   **d**: days.
                /// 
                /// >  A value of **5m** indicates 5 minutes.
                /// </summary>
                [NameInMap("UpgradeObservationWindowSize")]
                [Validation(Required=false)]
                public string UpgradeObservationWindowSize { get; set; }

            }

            /// <summary>
            /// The configurations of the auto scaling feature for shards.
            /// </summary>
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataShard Shard { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataShard : TeaModel {
                /// <summary>
                /// Indicates whether the feature of automatically removing shards is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Downgrade")]
                [Validation(Required=false)]
                public bool? Downgrade { get; set; }

                /// <summary>
                /// The observation window of the feature of automatically removing shards. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:
                /// 
                /// *   **s**: seconds.
                /// *   **m**: minutes.
                /// *   **h**: hours.
                /// *   **d**: days.
                /// 
                /// >  A value of **1d** indicates one day.
                /// </summary>
                [NameInMap("DowngradeObservationWindowSize")]
                [Validation(Required=false)]
                public string DowngradeObservationWindowSize { get; set; }

                /// <summary>
                /// The maximum number of shards in the instance.
                /// </summary>
                [NameInMap("MaxShards")]
                [Validation(Required=false)]
                public int? MaxShards { get; set; }

                /// <summary>
                /// The average memory usage threshold that triggers automatic removal of shards. Unit: %.
                /// </summary>
                [NameInMap("MemUsageLowerThreshold")]
                [Validation(Required=false)]
                public int? MemUsageLowerThreshold { get; set; }

                /// <summary>
                /// The average memory usage threshold that triggers automatic adding of shards. Unit: %.
                /// </summary>
                [NameInMap("MemUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? MemUsageUpperThreshold { get; set; }

                /// <summary>
                /// The minimum number of shards in the instance.
                /// </summary>
                [NameInMap("MinShards")]
                [Validation(Required=false)]
                public int? MinShards { get; set; }

                /// <summary>
                /// Indicates whether the feature of automatically adding shards is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Upgrade")]
                [Validation(Required=false)]
                public bool? Upgrade { get; set; }

                /// <summary>
                /// The observation window of the feature of automatically adding shards. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:
                /// 
                /// *   **s**: seconds.
                /// *   **m**: minutes.
                /// *   **h**: hours.
                /// *   **d**: days.
                /// 
                /// >  A value of **5m** indicates 5 minutes.
                /// </summary>
                [NameInMap("UpgradeObservationWindowSize")]
                [Validation(Required=false)]
                public string UpgradeObservationWindowSize { get; set; }

            }

            /// <summary>
            /// The configurations of the auto scaling feature for specifications.
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataSpec Spec { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataSpec : TeaModel {
                /// <summary>
                /// The quiescent period. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:
                /// 
                /// *   **s**: seconds.
                /// *   **m**: minutes.
                /// *   **h**: hours.
                /// *   **d**: days.
                /// 
                /// >  A value of **5m** indicates 5 minutes.
                /// </summary>
                [NameInMap("CoolDownTime")]
                [Validation(Required=false)]
                public string CoolDownTime { get; set; }

                /// <summary>
                /// The average CPU utilization threshold that triggers automatic specification scale-up. Unit: %.
                /// </summary>
                [NameInMap("CpuUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? CpuUsageUpperThreshold { get; set; }

                /// <summary>
                /// Indicates whether the automatic specification scale-down feature is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Downgrade")]
                [Validation(Required=false)]
                public bool? Downgrade { get; set; }

                /// <summary>
                /// The maximum number of read-only nodes of the instance.
                /// </summary>
                [NameInMap("MaxReadOnlyNodes")]
                [Validation(Required=false)]
                public int? MaxReadOnlyNodes { get; set; }

                /// <summary>
                /// The maximum specifications to which the database instance can be upgraded. For more information about the specifications of each type of supported database instances, see the following topics:
                /// 
                /// *   PolarDB for MySQL Cluster Edition instances: [Specifications of compute nodes](https://help.aliyun.com/document_detail/102542.html).
                /// *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs): [Specifications](https://help.aliyun.com/document_detail/276974.html).
                /// </summary>
                [NameInMap("MaxSpec")]
                [Validation(Required=false)]
                public string MaxSpec { get; set; }

                /// <summary>
                /// The average memory usage threshold that triggers automatic specification scale-up. Unit: %.
                /// </summary>
                [NameInMap("MemUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? MemUsageUpperThreshold { get; set; }

                /// <summary>
                /// The observation window. The return value consists of a numeric value and a time unit suffix. Valid values of the time unit suffix:
                /// 
                /// *   **s**: seconds.
                /// *   **m**: minutes.
                /// *   **h**: hours.
                /// *   **d**: days.
                /// 
                /// >  A value of **5m** indicates 5 minutes.
                /// </summary>
                [NameInMap("ObservationWindowSize")]
                [Validation(Required=false)]
                public string ObservationWindowSize { get; set; }

                /// <summary>
                /// Indicates whether the automatic specification scale-up feature is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Upgrade")]
                [Validation(Required=false)]
                public bool? Upgrade { get; set; }

            }

            /// <summary>
            /// The configurations of the automatic storage expansion feature.
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public DescribeAutoScalingConfigResponseBodyDataStorage Storage { get; set; }
            public class DescribeAutoScalingConfigResponseBodyDataStorage : TeaModel {
                /// <summary>
                /// The average storage usage threshold that triggers automatic storage expansion. Unit: %.
                /// </summary>
                [NameInMap("DiskUsageUpperThreshold")]
                [Validation(Required=false)]
                public int? DiskUsageUpperThreshold { get; set; }

                /// <summary>
                /// The maximum storage size. Unit: GB.
                /// </summary>
                [NameInMap("MaxStorage")]
                [Validation(Required=false)]
                public int? MaxStorage { get; set; }

                /// <summary>
                /// Indicates whether the automatic storage expansion feature is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Upgrade")]
                [Validation(Required=false)]
                public bool? Upgrade { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
