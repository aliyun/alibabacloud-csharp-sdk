// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateLogStoreRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to record public IP addresses. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description><para>true: records public IP addresses.</para>
        /// </description></item>
        /// <item><description><para>false: does not record public IP addresses.</para>
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
        /// <para>Specifies whether to automatically split a shard.</para>
        /// <list type="bullet">
        /// <item><description><para>true: automatically splits a shard.</para>
        /// </description></item>
        /// <item><description><para>false: does not automatically split a shard.</para>
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
        /// <para>Specifies whether to enable web tracking. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables web tracking.</para>
        /// </description></item>
        /// <item><description><para>false: does not enable web tracking.</para>
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
        /// <para>The encryption configuration.</para>
        /// </summary>
        [NameInMap("encrypt_conf")]
        [Validation(Required=false)]
        public EncryptConf EncryptConf { get; set; }

        /// <summary>
        /// <para>The retention period of data in the hot tier of the Logstore. Minimum value: 7. Unit: days. Valid values: 7 to 3000. After the retention period of the hot tier ends, the data is moved to the Infrequent Access (IA) storage class. For more information, see <a href="https://help.aliyun.com/document_detail/308645.html">Automatic Storage Tiering</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("hot_ttl")]
        [Validation(Required=false)]
        public int? HotTtl { get; set; }

        /// <summary>
        /// <para>The retention period for data in the IA storage class. Data in this storage class has no minimum retention period. Data must be stored for at least 30 days before it is moved to Archive storage.</para>
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
        /// <para>The maximum number of shards to which a shard can be split. The value must be an integer from 1 to 256.</para>
        /// <remarks>
        /// <para>This parameter is required if autoSplit is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("maxSplitShard")]
        [Validation(Required=false)]
        public int? MaxSplitShard { get; set; }

        /// <summary>
        /// <para>SLS provides two types of Logstores: Standard and Query.</para>
        /// <list type="bullet">
        /// <item><description><para><b>standard</b>: supports one-stop data analytics. This type of Logstore is suitable for scenarios such as real-time monitoring, interactive analysis, and building a complete observability system.</para>
        /// </description></item>
        /// <item><description><para><b>query</b>: supports high-performance queries. The index traffic cost of a Query Logstore is about half that of a Standard Logstore. However, a Query Logstore does not support SQL analysis. This type of Logstore is suitable for scenarios that involve large data volumes, long retention periods of weeks or months, and no log analysis.</para>
        /// </description></item>
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
        /// <para>You cannot update the number of shards with this operation. To change the number of shards, call the SplitShard or MergeShards operation.</para>
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
        /// <para>The hash-based write configuration.</para>
        /// </summary>
        [NameInMap("shardingPolicy")]
        [Validation(Required=false)]
        public ShardingPolicy ShardingPolicy { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The type of observable data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>None: logs. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>Metrics: metrics.</para>
        /// </description></item>
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
        /// <para>The data retention period. Unit: days. Valid values: 1 to 3650. If you set this parameter to 3650, the data is permanently retained.</para>
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
