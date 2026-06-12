// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Logstore : TeaModel {
        /// <summary>
        /// <para>Specifies whether to include the client\&quot;s public IP address in the log data. The default is false.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Records the public IP address.</para>
        /// </description></item>
        /// <item><description><para>false: Does not record the public IP address.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("appendMeta")]
        [Validation(Required=false)]
        public bool? AppendMeta { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto split.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables auto split.</para>
        /// </description></item>
        /// <item><description><para>false: Disables auto split.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoSplit")]
        [Validation(Required=false)]
        public bool? AutoSplit { get; set; }

        /// <summary>
        /// <para>The creation time of the Logstore, specified as a UNIX timestamp (the number of seconds since January 1, 1970, 00:00:00 UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1453949705</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        [NameInMap("enableModify")]
        [Validation(Required=false)]
        public bool? EnableModify { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable WebTracking. The default value is false.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables WebTracking.</para>
        /// </description></item>
        /// <item><description><para>false: Disables WebTracking.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable_tracking")]
        [Validation(Required=false)]
        public bool? EnableTracking { get; set; }

        /// <summary>
        /// <para>The data encryption configuration.</para>
        /// </summary>
        [NameInMap("encrypt_conf")]
        [Validation(Required=false)]
        public EncryptConf EncryptConf { get; set; }

        /// <summary>
        /// <para>The number of days to retain data in the hot storage tier. The minimum value is 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("hot_ttl")]
        [Validation(Required=false)]
        public int? HotTtl { get; set; }

        /// <summary>
        /// <para>The number of days to retain data in the infrequent access storage tier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("infrequentAccessTTL")]
        [Validation(Required=false)]
        public int? InfrequentAccessTTL { get; set; }

        /// <summary>
        /// <para>The time the Logstore was last modified, specified as a UNIX timestamp (the number of seconds since January 1, 1970, 00:00:00 UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1524155379</para>
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public int? LastModifyTime { get; set; }

        /// <summary>
        /// <para>The name of the Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-logstore</para>
        /// </summary>
        [NameInMap("logstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <para>The maximum number of shards that an auto split can create. Valid values: 1 to 64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("maxSplitShard")]
        [Validation(Required=false)]
        public int? MaxSplitShard { get; set; }

        /// <summary>
        /// <para>Log Service provides two types of Logstores: Standard and Query.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Standard</b>: Supports the full suite of Log Service data analysis features. This mode is ideal for real-time monitoring, interactive analysis, and building complete observability solutions.</para>
        /// </description></item>
        /// <item><description><para><b>Query</b>: Optimized for high-performance queries with indexing traffic costs that are approximately half those of the Standard mode. This mode does not support SQL analysis and is best for use cases involving large data volumes and long retention periods, where complex log analysis is not a requirement.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The IngestProcessor ID.</para>
        /// </summary>
        [NameInMap("processorId")]
        [Validation(Required=false)]
        public string ProcessorId { get; set; }

        /// <summary>
        /// <para>The product type of the logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("productType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The number of shards in the Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("shardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        [NameInMap("shardingPolicy")]
        [Validation(Required=false)]
        public ShardingPolicy ShardingPolicy { get; set; }

        /// <summary>
        /// <para>The type of log data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Metrics: The Logstore is optimized for time-series storage.</para>
        /// </description></item>
        /// <item><description><para>None: The Logstore uses standard storage for logs.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Metrics</para>
        /// </summary>
        [NameInMap("telemetryType")]
        [Validation(Required=false)]
        public string TelemetryType { get; set; }

        /// <summary>
        /// <para>The data retention period in days. Valid values: 1 to 3,650. A value of 3,650 indicates permanent storage.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
