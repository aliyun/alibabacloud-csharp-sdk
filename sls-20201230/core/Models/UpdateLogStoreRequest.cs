// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateLogStoreRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to record public IP addresses. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("appendMeta")]
        [Validation(Required=false)]
        public bool? AppendMeta { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic sharding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoSplit")]
        [Validation(Required=false)]
        public bool? AutoSplit { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the web tracking feature. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable_tracking")]
        [Validation(Required=false)]
        public bool? EnableTracking { get; set; }

        /// <summary>
        /// <para>The data structure of the encryption configuration.</para>
        /// </summary>
        [NameInMap("encrypt_conf")]
        [Validation(Required=false)]
        public EncryptConf EncryptConf { get; set; }

        /// <summary>
        /// <para>The retention period of data in the hot storage tier of the Logstore. Valid values: 7 to 3000. Unit: days. After the retention period that is specified for the hot storage tier elapses, the data is moved to the Infrequent Access (IA) storage tier. For more information, see <a href="https://help.aliyun.com/document_detail/308645.html">Enable hot and cold-tiered storage for a Logstore</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("hot_ttl")]
        [Validation(Required=false)]
        public int? HotTtl { get; set; }

        /// <summary>
        /// <para>The retention period of data in the IA storage tier of the Logstore. You must set this parameter to at least 30 days. After the data retention period that you specify for the IA storage tier elapses, the data is moved to the Archive storage tier.</para>
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
        /// <para>The maximum number of shards into which existing shards can be automatically split. Valid values: 1 to 256.</para>
        /// <remarks>
        /// <para> If you set autoSplit to true, you must specify maxSplitShard.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("maxSplitShard")]
        [Validation(Required=false)]
        public int? MaxSplitShard { get; set; }

        /// <summary>
        /// <para>The type of the Logstore. Simple Log Service provides two types of Logstores: Standard Logstores and Query Logstores. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>standard</b>: Standard Logstore. This type of Logstore supports the log analysis feature and is suitable for scenarios such as real-time monitoring and interactive analysis. You can also use this type of Logstore to build a comprehensive observability system.</description></item>
        /// <item><description><b>query</b>: Query Logstore. This type of Logstore supports high-performance queries. The index traffic fee of a Query Logstore is approximately half that of a Standard Logstore. Query Logstores do not support SQL analysis. Query Logstores are suitable for scenarios in which the amount of data is large, the log retention period is long, or log analysis is not required. If logs are stored for weeks or months, the log retention period is considered long.</description></item>
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
        /// <para> You cannot call the UpdateLogStore operation to change the number of shards. You can call the SplitShard or MergeShards operation to change the number of shards.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("shardCount")]
        [Validation(Required=false)]
        [Obsolete]
        public int? ShardCount { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The type of the observable data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None (default): log data.</description></item>
        /// <item><description>Metrics: metric data.</description></item>
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
        /// <para>The retention period of data. Unit: days. Valid values: 1 to 3650. If you set this parameter to 3650, logs are permanently stored.</para>
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
