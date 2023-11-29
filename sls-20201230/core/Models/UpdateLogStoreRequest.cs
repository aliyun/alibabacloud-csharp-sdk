// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateLogStoreRequest : TeaModel {
        /// <summary>
        /// Specifies whether to record public IP addresses. Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("appendMeta")]
        [Validation(Required=false)]
        public bool? AppendMeta { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic sharding. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("autoSplit")]
        [Validation(Required=false)]
        public bool? AutoSplit { get; set; }

        /// <summary>
        /// Specifies whether to enable the web tracking feature. Default value: false. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("enable_tracking")]
        [Validation(Required=false)]
        public bool? EnableTracking { get; set; }

        /// <summary>
        /// The data structure of the encryption configuration.
        /// </summary>
        [NameInMap("encrypt_conf")]
        [Validation(Required=false)]
        public EncryptConf EncryptConf { get; set; }

        /// <summary>
        /// The retention period of data in the hot storage tier of the Logstore. Minimum value: 30. Unit: day. You can specify a value that ranges from 30 to the value of ttl. Hot data that is stored for longer than the period specified by hot_ttl is converted to cold data. For more information, see [Enable hot and cold-tiered storage for a Logstore](~~308645~~).
        /// </summary>
        [NameInMap("hot_ttl")]
        [Validation(Required=false)]
        public int? HotTtl { get; set; }

        /// <summary>
        /// The name of the Logstore.
        /// </summary>
        [NameInMap("logstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// The maximum number of shards into which existing shards can be automatically split. Valid values: 1 to 64.
        /// 
        /// > If you set autoSplit to true, you must specify maxSplitShard.
        /// </summary>
        [NameInMap("maxSplitShard")]
        [Validation(Required=false)]
        public int? MaxSplitShard { get; set; }

        /// <summary>
        /// The type of the Logstore. Simple Log Service provides two types of Logstores: Standard Logstores and Query Logstores.
        /// 
        /// *   **standard**: Standard Logstore. This type of Logstore supports the log analysis feature and is suitable for scenarios such as real-time monitoring and interactive analysis. You can also use this type of Logstore to build a comprehensive observability system.
        /// *   **query**: Query Logstore. This type of Logstore supports high-performance queries. The index traffic fee of a Query Logstore is approximately half that of a Standard Logstore. Query Logstores do not support SQL analysis. Query Logstores are suitable for scenarios in which the volume of data is large, the log retention period is long, or log analysis is not required. Log retention periods of weeks or months are considered long.
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The number of shards.
        /// 
        /// > You cannot call the UpdateLogstore operation to change the number of shards. You can call the SplitShard or MergeShards operation to change the number of shards.
        /// </summary>
        [NameInMap("shardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// The type of the log that you want to query. Valid values:
        /// 
        /// *   None: all types of logs.
        /// *   Metrics: metrics.
        /// </summary>
        [NameInMap("telemetryType")]
        [Validation(Required=false)]
        public string TelemetryType { get; set; }

        /// <summary>
        /// The retention period of data. Unit: day. Valid values: 1 to 3650. If you set ttl to 3650, data is permanently stored.
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
