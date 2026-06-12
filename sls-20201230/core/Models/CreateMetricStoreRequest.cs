// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateMetricStoreRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to record the public IP address of the client. The default value is false.</para>
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
        /// <para>Specifies whether to enable automatic shard splitting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoSplit")]
        [Validation(Required=false)]
        public bool? AutoSplit { get; set; }

        /// <summary>
        /// <para>The period for which data is stored in the hot tier. Unit: days. The value must be at least 7 and cannot be greater than the value of ttl. If you set this parameter to -1, all data is stored in the hot tier for the duration specified by ttl.</para>
        /// <para>When the hot storage period ends, the data is moved to the IA storage class. For more information, see <a href="https://help.aliyun.com/document_detail/308645.html">Tiered Storage of Hot and Cold Data</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("hot_ttl")]
        [Validation(Required=false)]
        public int? HotTtl { get; set; }

        /// <summary>
        /// <para>The retention period of data in the IA storage class. Unit: days. The minimum value is 30. After this period, data is moved to Archive Storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("infrequentAccessTTL")]
        [Validation(Required=false)]
        public int? InfrequentAccessTTL { get; set; }

        /// <summary>
        /// <para>The maximum number of shards into which a shard can be split. This parameter is valid only if autoSplit is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("maxSplitShard")]
        [Validation(Required=false)]
        public int? MaxSplitShard { get; set; }

        /// <summary>
        /// <para>The type of the Metricstore. Only prometheus is supported. The default value is prometheus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prometheus</para>
        /// </summary>
        [NameInMap("metricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The type of the Metricstore. Only standard is supported. The default value is standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The name of the Metricstore to create.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_metric_store</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of <a href="https://help.aliyun.com/document_detail/28976.html">shards</a> for the Metricstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("shardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// <para>The write hashing configuration.</para>
        /// </summary>
        [NameInMap("shardingPolicy")]
        [Validation(Required=false)]
        public ShardingPolicy ShardingPolicy { get; set; }

        /// <summary>
        /// <para>The data retention period of the Metricstore. Unit: days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
