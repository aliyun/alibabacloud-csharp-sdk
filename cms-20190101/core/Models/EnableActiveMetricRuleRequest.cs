// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class EnableActiveMetricRuleRequest : TeaModel {
        /// <summary>
        /// The cloud service for which you want to enable initiative alert. Valid values:
        /// 
        /// *   ecs: Elastic Compute Service (ECS)
        /// *   rds: ApsaraDB RDS
        /// *   slb: Server Load Balancer (SLB)
        /// *   redis_standard: ApsaraDB for Redis of the standard architecture
        /// *   redis_sharding: ApsaraDB for Redis of the cluster architecture
        /// *   redis_splitrw: ApsaraDB for Redis of the read/write splitting architecture
        /// *   mongodb: ApsaraDB for MongoDB of the replica set architecture
        /// *   mongodb_sharding: ApsaraDB for MongoDB of the sharded cluster architecture
        /// *   hbase: ApsaraDB for HBase
        /// *   elasticsearch: Elasticsearch
        /// *   opensearch: OpenSearch
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
