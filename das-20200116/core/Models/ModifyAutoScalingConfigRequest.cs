// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifyAutoScalingConfigRequest : TeaModel {
        /// <summary>
        /// The configuration item of the automatic bandwidth adjustment feature.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestBandwidth Bandwidth { get; set; }
        public class ModifyAutoScalingConfigRequestBandwidth : TeaModel {
            /// <summary>
            /// Specifies whether to apply the **Bandwidth** configuration of the automatic bandwidth adjustment feature. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// The average bandwidth usage threshold that triggers automatic bandwidth downgrade. Unit: %. Valid values:
            /// 
            /// *   **10**
            /// *   **20**
            /// *   **30**
            /// </summary>
            [NameInMap("BandwidthUsageLowerThreshold")]
            [Validation(Required=false)]
            public int? BandwidthUsageLowerThreshold { get; set; }

            /// <summary>
            /// The average bandwidth usage threshold that triggers automatic bandwidth upgrade. Unit: %. Valid values:
            /// 
            /// *   **50**
            /// *   **60**
            /// *   **70**
            /// *   **80**
            /// *   **90**
            /// *   **95**
            /// </summary>
            [NameInMap("BandwidthUsageUpperThreshold")]
            [Validation(Required=false)]
            public int? BandwidthUsageUpperThreshold { get; set; }

            /// <summary>
            /// Specifies whether to enable the automatic bandwidth downgrade feature. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Downgrade")]
            [Validation(Required=false)]
            public bool? Downgrade { get; set; }

            /// <summary>
            /// The observation window of the automatic bandwidth adjustment feature. The value of this parameter consists of a numeric value and a time unit suffix. The **m** time unit suffix specifies the minute. Valid values:
            /// 
            /// *   **1m**
            /// *   **5m**
            /// *   **10m**
            /// *   **15m**
            /// *   **30m**
            /// </summary>
            [NameInMap("ObservationWindowSize")]
            [Validation(Required=false)]
            public string ObservationWindowSize { get; set; }

            /// <summary>
            /// Specifies whether to enable the automatic bandwidth upgrade feature. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Upgrade")]
            [Validation(Required=false)]
            public bool? Upgrade { get; set; }

        }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The configuration item of the auto scaling feature for resources.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestResource Resource { get; set; }
        public class ModifyAutoScalingConfigRequestResource : TeaModel {
            /// <summary>
            /// Specifies whether to apply the **Resource** configuration of the auto scaling feature for resources. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// The average CPU utilization threshold that triggers automatic scale-out of resources. Unit: %. Valid values:
            /// 
            /// *   **70**
            /// *   **80**
            /// *   **90**
            /// </summary>
            [NameInMap("CpuUsageUpperThreshold")]
            [Validation(Required=false)]
            public int? CpuUsageUpperThreshold { get; set; }

            /// <summary>
            /// The observation window of the automatic resource scale-in feature. The value of this parameter consists of a numeric value and a time unit suffix. The **m** time unit suffix specifies the minute. Valid values:
            /// 
            /// *   **1m**
            /// *   **3m**
            /// *   **5m**
            /// *   **10m**
            /// *   **20m**
            /// *   **30m**
            /// </summary>
            [NameInMap("DowngradeObservationWindowSize")]
            [Validation(Required=false)]
            public string DowngradeObservationWindowSize { get; set; }

            /// <summary>
            /// Specifies whether to enable the auto scaling feature for resources. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The observation window of the automatic resource scale-out feature. The value of this parameter consists of a numeric value and a time unit suffix. The **m** time unit suffix specifies the minute. Valid values:
            /// 
            /// *   **1m**
            /// *   **3m**
            /// *   **5m**
            /// *   **10m**
            /// *   **20m**
            /// *   **30m**
            /// </summary>
            [NameInMap("UpgradeObservationWindowSize")]
            [Validation(Required=false)]
            public string UpgradeObservationWindowSize { get; set; }

        }

        /// <summary>
        /// The configuration item of the auto scaling feature for shards.
        /// </summary>
        [NameInMap("Shard")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestShard Shard { get; set; }
        public class ModifyAutoScalingConfigRequestShard : TeaModel {
            /// <summary>
            /// Specifies whether to apply the **Shard** configuration of the auto scaling feature for shards. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// > The auto scaling feature for shards is available only for ApsaraDB for Redis Community Edition cloud-native instances on the China site (aliyun.com).
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// Specifies whether to enable the feature of automatically removing shards. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// >  The feature of automatically removing shards is in canary release.
            /// </summary>
            [NameInMap("Downgrade")]
            [Validation(Required=false)]
            public bool? Downgrade { get; set; }

            /// <summary>
            /// The observation window of the feature of automatically removing shards. The value of this parameter consists of a numeric value and a time unit suffix. The **h** time unit suffix specifies the hour. The **d** time unit suffix specifies the day. Valid values:
            /// 
            /// *   **1h**
            /// *   **2h**
            /// *   **3h**
            /// *   **1d**
            /// *   **7d**
            /// </summary>
            [NameInMap("DowngradeObservationWindowSize")]
            [Validation(Required=false)]
            public string DowngradeObservationWindowSize { get; set; }

            /// <summary>
            /// The maximum number of shards in the instance. The value must be a positive integer. Valid values: 4 to 32.
            /// </summary>
            [NameInMap("MaxShards")]
            [Validation(Required=false)]
            public int? MaxShards { get; set; }

            /// <summary>
            /// The average memory usage threshold that triggers automatic removal of shards. Unit: %. Valid values:
            /// 
            /// *   **10**
            /// *   **20**
            /// *   **30**
            /// </summary>
            [NameInMap("MemUsageLowerThreshold")]
            [Validation(Required=false)]
            public int? MemUsageLowerThreshold { get; set; }

            /// <summary>
            /// The average memory usage threshold that triggers automatic adding of shards. Unit: %. Valid values:
            /// 
            /// *   **50**
            /// *   **60**
            /// *   **70**
            /// *   **80**
            /// *   **90**
            /// </summary>
            [NameInMap("MemUsageUpperThreshold")]
            [Validation(Required=false)]
            public int? MemUsageUpperThreshold { get; set; }

            /// <summary>
            /// The minimum number of shards in the instance. The value must be a positive integer. Valid values: 4 to 32.
            /// </summary>
            [NameInMap("MinShards")]
            [Validation(Required=false)]
            public int? MinShards { get; set; }

            /// <summary>
            /// Specifies whether to enable the feature of automatically adding shards. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Upgrade")]
            [Validation(Required=false)]
            public bool? Upgrade { get; set; }

            /// <summary>
            /// The observation window of the feature of automatically adding shards. The value of this parameter consists of a numeric value and a time unit suffix. The **m** time unit suffix specifies the minute. Valid values:
            /// 
            /// *   **5m**
            /// *   **10m**
            /// *   **15m**
            /// *   **30m**
            /// </summary>
            [NameInMap("UpgradeObservationWindowSize")]
            [Validation(Required=false)]
            public string UpgradeObservationWindowSize { get; set; }

        }

        /// <summary>
        /// The configuration item of the auto scaling feature for specifications.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestSpec Spec { get; set; }
        public class ModifyAutoScalingConfigRequestSpec : TeaModel {
            /// <summary>
            /// Specifies whether to apply the **Spec** configuration of the auto scaling feature for specifications. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// The quiescent period. The value of this parameter consists of a numeric value and a time unit suffix. The **m** time unit suffix specifies the minute, the **h** time unit suffix specifies the hour, and the **d** time suffix unit specifies the day.
            /// 
            /// *   Valid values for PolarDB for MySQL Cluster Edition instances: **5m**, **10m**, **30m**, **1h**, **2h**, **3h**, **1d**, and **7d**.
            /// *   Valid values for ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs: **5m**, **10m**, **30m**, **1h**, **2h**, **3h**, **1d**, and **7d**.
            /// </summary>
            [NameInMap("CoolDownTime")]
            [Validation(Required=false)]
            public string CoolDownTime { get; set; }

            /// <summary>
            /// The average CPU utilization threshold that triggers automatic specification scale-up. Unit: %. Valid values:
            /// 
            /// *   **50**
            /// *   **60**
            /// *   **70**
            /// *   **80**
            /// *   **90**
            /// 
            /// > This parameter must be specified if the database instance is a PolarDB for MySQL Cluster Edition instance or an ApsaraDB RDS for MySQL High-availability Edition instance that uses standard SSDs or ESSDs.
            /// </summary>
            [NameInMap("CpuUsageUpperThreshold")]
            [Validation(Required=false)]
            public int? CpuUsageUpperThreshold { get; set; }

            /// <summary>
            /// Specifies whether to enable the automatic specification scale-down feature. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// > This parameter must be specified if the database instance is a PolarDB for MySQL Cluster Edition instance or an ApsaraDB RDS for MySQL High-availability Edition instance that uses standard SSDs or ESSDs.
            /// </summary>
            [NameInMap("Downgrade")]
            [Validation(Required=false)]
            public bool? Downgrade { get; set; }

            /// <summary>
            /// The maximum number of read-only nodes of the instance.
            /// 
            /// > This parameter must be specified if the database instance is a PolarDB for MySQL Cluster Edition instance.
            /// </summary>
            [NameInMap("MaxReadOnlyNodes")]
            [Validation(Required=false)]
            public int? MaxReadOnlyNodes { get; set; }

            /// <summary>
            /// The maximum specifications to which the database instance can be scaled up. The database instance can be upgraded only to a database instance of the same edition with higher specifications. For information about the specifications of different database instances, see the following topics:
            /// 
            /// *   PolarDB for MySQL Cluster Edition instances: [Specifications of compute nodes](https://help.aliyun.com/document_detail/102542.html)
            /// *   ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs: [Specifications](https://help.aliyun.com/document_detail/276974.html)
            /// </summary>
            [NameInMap("MaxSpec")]
            [Validation(Required=false)]
            public string MaxSpec { get; set; }

            /// <summary>
            /// The average memory usage threshold that triggers automatic specification scale-up. Unit: %. Valid values:
            /// 
            /// *   **50**
            /// *   **60**
            /// *   **70**
            /// *   **80**
            /// *   **90**
            /// 
            /// > This parameter must be specified if the database instance is an ApsaraDB for Redis Community Edition cloud-native instance on the China site (aliyun.com).
            /// </summary>
            [NameInMap("MemUsageUpperThreshold")]
            [Validation(Required=false)]
            public int? MemUsageUpperThreshold { get; set; }

            /// <summary>
            /// The observation window. The value of this parameter consists of a numeric value and a time unit suffix. The **m** time unit suffix specifies the minute and the **h** time unit suffix specifies the hour.
            /// 
            /// *   Valid values for PolarDB for MySQL Cluster Edition instances: **5m**, **10m**, **15m**, and **30m**.
            /// *   Valid values for ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs: **5m**, **20m**, **30m**, **40m**, and **1h**.
            /// *   Valid values for ApsaraDB for Redis Community Edition cloud-native instances: **5m**, **10m**, **15m**, and **30m**.
            /// </summary>
            [NameInMap("ObservationWindowSize")]
            [Validation(Required=false)]
            public string ObservationWindowSize { get; set; }

            /// <summary>
            /// Specifies whether to enable the automatic specification scale-up feature. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Upgrade")]
            [Validation(Required=false)]
            public bool? Upgrade { get; set; }

        }

        /// <summary>
        /// The configuration item of the automatic storage expansion feature.
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public ModifyAutoScalingConfigRequestStorage Storage { get; set; }
        public class ModifyAutoScalingConfigRequestStorage : TeaModel {
            /// <summary>
            /// Specifies whether to apply the **Storage** configuration of the automatic storage expansion feature. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Apply")]
            [Validation(Required=false)]
            public bool? Apply { get; set; }

            /// <summary>
            /// The average storage usage threshold that triggers automatic storage expansion. Unit: %. Valid values:
            /// 
            /// *   **50**
            /// *   **60**
            /// *   **70**
            /// *   **80**
            /// *   **90**
            /// </summary>
            [NameInMap("DiskUsageUpperThreshold")]
            [Validation(Required=false)]
            public int? DiskUsageUpperThreshold { get; set; }

            /// <summary>
            /// The maximum storage size of the database instance. The value must be greater than or equal to the total storage size of the instance. Valid values of different types of instances:
            /// 
            /// *   If the ApsaraDB for RDS instance uses ESSDs, the value of this parameter can be set to 32000, in GB.
            /// *   If the ApsaraDB for RDS instance uses standard SSDs, the value of this parameter can be set to 6000, in GB.
            /// 
            /// >  The ApsaraDB RDS for MySQL instances that use standard SSDs are discontinued. We recommend that you [upgrade the storage type of an ApsaraDB RDS for MySQL instance from standard SSDs to ESSDs](https://help.aliyun.com/document_detail/314678.html).
            /// </summary>
            [NameInMap("MaxStorage")]
            [Validation(Required=false)]
            public int? MaxStorage { get; set; }

            /// <summary>
            /// Specifies whether to enable the automatic storage expansion feature. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Upgrade")]
            [Validation(Required=false)]
            public bool? Upgrade { get; set; }

        }

    }

}
