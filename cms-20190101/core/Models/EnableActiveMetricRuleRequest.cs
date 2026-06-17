// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class EnableActiveMetricRuleRequest : TeaModel {
        /// <summary>
        /// <para>The cloud service for which you want to enable initiative alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ECS: Elastic Compute Service (ECS)</para>
        /// </description></item>
        /// <item><description><para>rds: ApsaraDB RDS</para>
        /// </description></item>
        /// <item><description><para>slb: Server Load Balancer (SLB)</para>
        /// </description></item>
        /// <item><description><para>redis_standard: Redis Open-Source Edition (standard architecture)</para>
        /// </description></item>
        /// <item><description><para>redis_sharding: Redis Open-Source Edition (cluster architecture)</para>
        /// </description></item>
        /// <item><description><para>redis_splitrw: Redis Open-Source Edition (read/write splitting architecture)</para>
        /// </description></item>
        /// <item><description><para>mongodb: ApsaraDB for MongoDB of the replica set architecture</para>
        /// </description></item>
        /// <item><description><para>mongodb_sharding: ApsaraDB for MongoDB of the sharded cluster architecture</para>
        /// </description></item>
        /// <item><description><para>hbase: ApsaraDB for HBase</para>
        /// </description></item>
        /// <item><description><para>elasticsearch: Elasticsearch</para>
        /// </description></item>
        /// <item><description><para>opensearch: OpenSearch</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
