// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateLogStoreRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to record the public IP address and log arrival time. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description>true: enables the feature. After this feature is enabled, Simple Log Service automatically adds the public IP address of the log source device and the time when the log arrives at the server to the Tag field of the log.</description></item>
        /// <item><description>false: disables the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("appendMeta")]
        [Validation(Required=false)]
        public bool? AppendMeta { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic sharding. After this feature is enabled, a shard is automatically split when the write traffic continuously exceeds the limit, which improves write capacity. You must set maxSplitShard (the maximum number of shards after splitting) when you enable automatic sharding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoSplit")]
        [Validation(Required=false)]
        public bool? AutoSplit { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the WebTracking feature. Default value: false. You can use the WebTracking feature to collect and analyze user behavior data in browsers or mini programs, such as page views, purchase records, and time on site.</para>
        /// <list type="bullet">
        /// <item><description>true: enables WebTracking.</description></item>
        /// <item><description>false: disables WebTracking.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable_tracking")]
        [Validation(Required=false)]
        public bool? EnableTracking { get; set; }

        /// <summary>
        /// <para>The encryption configuration. Encryption is disabled by default.</para>
        /// <para>Example 1 (enable default encryption):</para>
        /// <pre><c>{
        ///     &quot;enable&quot;: true,
        ///     &quot;encrypt_conf&quot;: &quot;default&quot;
        /// }
        /// </c></pre>
        /// <para>Example 2 (enable BYOK encryption):</para>
        /// <pre><c>{
        ///     &quot;enable&quot;: true,
        ///     &quot;encrypt_conf&quot;: &quot;default&quot;,
        ///     &quot;user_cmk_info&quot;: {
        ///         &quot;cmk_key_id&quot;: &quot;xxxxx&quot;,
        ///         &quot;arn&quot;: &quot;acs:ram::112340000000:role/rolename&quot;,
        ///         &quot;region&quot;: &quot;ap-southeast-1&quot;
        ///     }
        /// }
        /// </c></pre>
        /// </summary>
        [NameInMap("encrypt_conf")]
        [Validation(Required=false)]
        public EncryptConf EncryptConf { get; set; }

        /// <summary>
        /// <para>The retention period of data in the hot tier of the Logstore. Unit: days. Minimum value: 7. The value cannot exceed the value of ttl. By default, all data within the retention period is stored in the hot tier.</para>
        /// <para>After the data storage time exceeds the configured hot data retention period, the data is moved to the infrequent access (IA) tier. When you enable the IA tier, the hot data retention period must be at least 7 days. For more information, see <a href="https://help.aliyun.com/document_detail/308645.html">Intelligent tiering</a>.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>Scenario 1 (hot tier only, 30 days): <c>{&quot;ttl&quot;: 30}</c> or <c>{&quot;ttl&quot;: 30, &quot;hot_ttl&quot;: 30}</c></description></item>
        /// <item><description>Scenario 2 (hot tier 7 days, IA tier 23 days): <c>{&quot;ttl&quot;: 30, &quot;hot_ttl&quot;: 7}</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("hot_ttl")]
        [Validation(Required=false)]
        public int? HotTtl { get; set; }

        /// <summary>
        /// <para>Infrequent access (IA) tier. No minimum storage time is required. Data must be stored for at least 30 days before being moved to the archive tier.</para>
        /// <para>When the log retention period exceeds the sum of the hot tier retention period and the IA tier retention period, the remaining storage time is converted to archive tier storage.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>Scenario 1 (hot tier 7 days, IA tier 23 days): <c>{&quot;ttl&quot;: 30, &quot;hot_ttl&quot;: 7}</c></description></item>
        /// <item><description>Scenario 2 (hot tier 7 days, IA tier 30 days, archive tier 60 days): <c>{&quot;ttl&quot;: 97, &quot;hot_ttl&quot;: 7, &quot;infrequentAccessTTL&quot;: 30}</c></description></item>
        /// <item><description>Scenario 3 (hot tier 60 days, IA tier 0 days, archive tier 60 days): <c>{&quot;ttl&quot;: 120, &quot;hot_ttl&quot;: 60, &quot;infrequentAccessTTL&quot;: 0}</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("infrequentAccessTTL")]
        [Validation(Required=false)]
        public int? InfrequentAccessTTL { get; set; }

        /// <summary>
        /// <para>The name of the Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("logstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <para>The maximum number of shards for automatic sharding. Minimum value: 1. Maximum value: 256.</para>
        /// <remarks>
        /// <para>This parameter is required when autoSplit is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("maxSplitShard")]
        [Validation(Required=false)]
        public int? MaxSplitShard { get; set; }

        /// <summary>
        /// <para>Simple Log Service provides two types of Logstores: Standard and Query.</para>
        /// <list type="bullet">
        /// <item><description><b>standard</b>: supports one-stop data analytics capabilities of Simple Log Service. This type is suitable for scenarios such as real-time monitoring, interactive analysis, and building complete observability systems.</description></item>
        /// <item><description><b>query</b>: supports high-performance queries. The index traffic fee is approximately half that of the Standard type. However, SQL analysis is not supported. This type is suitable for scenarios with large data volumes, long storage periods (weeks or months), and no log analysis requirements.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The number of shards.</para>
        /// <remarks>
        /// <para>This operation does not support updating the number of shards. You can modify the number of shards only by calling the SplitShard or MergeShards operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("shardCount")]
        [Validation(Required=false)]
        [Obsolete]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The hash-based write configuration. When data is written, logs are routed to shards based on the configured hash policy. Before configuring this parameter, ensure that the hash ranges of shards are evenly distributed. This configuration may affect write capacity. Proceed with caution.</para>
        /// </summary>
        [NameInMap("shardingPolicy")]
        [Validation(Required=false)]
        public ShardingPolicy ShardingPolicy { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The type of observable data. The default value is log data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None: log data. This is the default value.</description></item>
        /// <item><description>Metrics: time series data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("telemetryType")]
        [Validation(Required=false)]
        [Obsolete]
        public string TelemetryType { get; set; }

        /// <summary>
        /// <para>The data retention period. Unit: days. Valid values: 1 to 3650. A value of 3650 indicates permanent retention.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
