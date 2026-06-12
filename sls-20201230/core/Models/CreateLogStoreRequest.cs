// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateLogStoreRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to record the source <b>public IP address</b> and the <b>server reception time</b>. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Log Service automatically appends the public IP address of the source device and the server reception time to the Tag field of logs.</para>
        /// </description></item>
        /// <item><description><para>false: Log Service does not append the source public IP address or the server reception time.</para>
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
        /// <para>Specifies whether to enable automatic shard splitting. If you set this parameter to true, Log Service automatically splits a shard to increase write throughput when the write traffic to the shard continuously exceeds the service limit. If you enable automatic shard splitting, you must also specify <c>maxSplitShard</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoSplit")]
        [Validation(Required=false)]
        public bool? AutoSplit { get; set; }

        [NameInMap("enableModify")]
        [Validation(Required=false)]
        public bool? EnableModify { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable WebTracking. The default value is false. This feature lets you collect and analyze user behavior data from browsers or mini programs, such as page views, purchase history, and dwell time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable_tracking")]
        [Validation(Required=false)]
        public bool? EnableTracking { get; set; }

        /// <summary>
        /// <para>The encryption configuration. This data structure includes the <c>enable</c>, <c>encrypt_type</c>, and <c>user_cmk_info</c> parameters. For more information, see <a href="https://help.aliyun.com/document_detail/409461.html">EncryptConf</a>.</para>
        /// <para>Example 1 (Enable default encryption):</para>
        /// <pre><c>{
        ///     &quot;enable&quot;: true,
        ///     &quot;encrypt_conf&quot;: &quot;default&quot;
        /// }
        /// </c></pre>
        /// <para>Example 2 (Enable BYOK encryption):</para>
        /// <pre><c>{
        ///     &quot;enable&quot;: true,
        ///     &quot;encrypt_conf&quot;: &quot;default&quot;,
        ///     &quot;user_cmk_info&quot;: {
        ///         &quot;cmk_key_id&quot;: &quot;xxxxx&quot;,
        ///         &quot;arn&quot;: &quot;acs:ram::112340000000:role/rolename&quot;,
        ///         &quot;region&quot;: &quot;cn-hangzhou&quot;
        ///     }
        /// }
        /// </c></pre>
        /// </summary>
        [NameInMap("encrypt_conf")]
        [Validation(Required=false)]
        public EncryptConf EncryptConf { get; set; }

        /// <summary>
        /// <para>The retention period of data in the hot storage tier of the Logstore, in days. The value must be an integer from 7 to the value of <c>ttl</c>. If you do not specify this parameter, data is stored in the hot storage tier for the entire data retention period specified by <c>ttl</c>.</para>
        /// <para>After the hot storage retention period expires, data is moved to the Infrequent Access (IA) storage tier. To enable IA storage, you must set the hot storage retention period to at least 7 days. For more information, see <a href="https://help.aliyun.com/document_detail/308645.html">Smart Tiered Storage</a>.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>Scenario 1 (Store data in the hot storage tier for 30 days): <c>{&quot;ttl&quot;: 30}</c> or <c>{&quot;ttl&quot;: 30, &quot;hot_ttl&quot;: 30}</c></para>
        /// </description></item>
        /// <item><description><para>Scenario 2 (Store data in the hot storage tier for 7 days and in the IA storage tier for 23 days): <c>{&quot;ttl&quot;: 30, &quot;hot_ttl&quot;: 7}</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("hot_ttl")]
        [Validation(Required=false)]
        public int? HotTtl { get; set; }

        /// <summary>
        /// <para>The retention period for Infrequent Access (IA) storage, in days. While this parameter has no minimum value, data must remain in the IA storage tier for at least 30 days before it can be moved to archive storage.</para>
        /// <para>If the total retention period (<c>ttl</c>) is longer than the sum of the hot storage period (<c>hot_ttl</c>) and the IA storage period (<c>infrequentAccessTTL</c>), the remaining time is the archive storage period.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>Scenario 1 (Store data in the hot storage tier for 7 days and in the IA storage tier for 23 days): <c>{&quot;ttl&quot;: 30, &quot;hot_ttl&quot;: 7}</c></para>
        /// </description></item>
        /// <item><description><para>Scenario 2 (Store data in the hot storage tier for 7 days, in the IA storage tier for 30 days, and in the archive storage tier for 60 days): <c>{&quot;ttl&quot;: 97, &quot;hot_ttl&quot;: 7, &quot;infrequentAccessTTL&quot;: 30}</c></para>
        /// </description></item>
        /// <item><description><para>Scenario 3 (Store data in the hot storage tier for 60 days and in the archive storage tier for 60 days, with the IA storage period being 0 days): <c>{&quot;ttl&quot;: 120, &quot;hot_ttl&quot;: 60, &quot;infrequentAccessTTL&quot;: 0}</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("infrequentAccessTTL")]
        [Validation(Required=false)]
        public int? InfrequentAccessTTL { get; set; }

        /// <summary>
        /// <para>The name of the Logstore. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The name must be unique within a project.</para>
        /// </description></item>
        /// <item><description><para>The name can contain only lowercase letters, digits, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>The name must start and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>The name must be 2 to 63 characters long.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-logstore</para>
        /// </summary>
        [NameInMap("logstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <para>The maximum number of shards after an automatic split. The value must be an integer from 1 to 256.</para>
        /// <remarks>
        /// <para>This parameter is required if you set <c>autoSplit</c> to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("maxSplitShard")]
        [Validation(Required=false)]
        public int? MaxSplitShard { get; set; }

        /// <summary>
        /// <para>Log Service provides two types of Logstores: standard and query.</para>
        /// <list type="bullet">
        /// <item><description><para><b>standard</b>: Supports end-to-end data analytics. This mode is suitable for scenarios such as real-time monitoring, interactive analysis, and building a complete observability system.</para>
        /// </description></item>
        /// <item><description><para><b>query</b>: Supports high-performance queries. The index traffic cost is approximately half that of the standard mode, but SQL analysis is not supported. This mode is suitable for scenarios that involve large volumes of data, long retention periods such as weeks or months, and do not require SQL-based analysis.</para>
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
        /// <para>The ID of the IngestProcessor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>processor-nginx-parser-001</para>
        /// </summary>
        [NameInMap("processorId")]
        [Validation(Required=false)]
        public string ProcessorId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Logstore belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxxxxxxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The number of shards.</para>
        /// <remarks>
        /// <para>You cannot update the shard count with this operation. To do so, call the SplitShard or MergeShards operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("shardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The configuration for hash-based writes. When you write data, logs are stored in a shard that is selected based on the configured hash-based sharding policy. Before you configure this parameter, make sure that the hash ranges of the shards are evenly distributed. Improper configuration may affect write performance. Configure this parameter with caution.</para>
        /// </summary>
        [NameInMap("shardingPolicy")]
        [Validation(Required=false)]
        public ShardingPolicy ShardingPolicy { get; set; }

        /// <summary>
        /// <para>The type of observable data. Default value: log data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>None</b>: log data. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>Metrics</b>: Metrics data.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("telemetryType")]
        [Validation(Required=false)]
        public string TelemetryType { get; set; }

        /// <summary>
        /// <para>The data retention period in days. Valid values: 1 to 3,650. If you set this parameter to 3,650, data is stored permanently.</para>
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
