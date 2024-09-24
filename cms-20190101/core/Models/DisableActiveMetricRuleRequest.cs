// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DisableActiveMetricRuleRequest : TeaModel {
        /// <summary>
        /// <para>The service for which you want to disable one-click alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ecs: Elastic Compute Service (ECS)</description></item>
        /// <item><description>rds: ApsaraDB RDS</description></item>
        /// <item><description>slb: Server Load Balancer (SLB)</description></item>
        /// <item><description>redis_standard: ApsaraDB for Redis of the standard architecture</description></item>
        /// <item><description>redis_sharding: ApsaraDB for Redis of the cluster architecture</description></item>
        /// <item><description>redis_splitrw: ApsaraDB for Redis of the read/write splitting architecture</description></item>
        /// <item><description>mongodb: ApsaraDB for MongoDB of the replica set architecture</description></item>
        /// <item><description>mongodb_sharding: ApsaraDB for MongoDB of the sharded cluster architecture</description></item>
        /// <item><description>hbase: ApsaraDB for HBase</description></item>
        /// <item><description>elasticsearch: Elasticsearch</description></item>
        /// <item><description>opensearch: Open Search</description></item>
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
