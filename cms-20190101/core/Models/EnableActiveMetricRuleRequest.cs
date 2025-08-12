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
        /// <item><description>ECS: Elastic Compute Service (ECS)</description></item>
        /// <item><description>rds: ApsaraDB RDS</description></item>
        /// <item><description>slb: Server Load Balancer (SLB)</description></item>
        /// <item><description>redis_standard: Redis Open-Source Edition (standard architecture)</description></item>
        /// <item><description>redis_sharding: Redis Open-Source Edition (cluster architecture)</description></item>
        /// <item><description>redis_splitrw: Redis Open-Source Edition (read/write splitting architecture)</description></item>
        /// <item><description>mongodb: ApsaraDB for MongoDB of the replica set architecture</description></item>
        /// <item><description>mongodb_sharding: ApsaraDB for MongoDB of the sharded cluster architecture</description></item>
        /// <item><description>hbase: ApsaraDB for HBase</description></item>
        /// <item><description>elasticsearch: Elasticsearch</description></item>
        /// <item><description>opensearch: OpenSearch</description></item>
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
