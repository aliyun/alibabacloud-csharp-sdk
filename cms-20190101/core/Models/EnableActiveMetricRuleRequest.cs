// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class EnableActiveMetricRuleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the value of this parameter on the client side. Make sure that the value is unique across different requests. The value can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000-xxxx-xxxxx--xxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the availability of the webhook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The name of the Alibaba Cloud service that supports one-click alert rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ecs: Elastic Compute Service (ECS).</description></item>
        /// <item><description>rds: ApsaraDB RDS.</description></item>
        /// <item><description>slb: Server Load Balancer (SLB).</description></item>
        /// <item><description>redis_standard: Standard architecture of open-source Redis.</description></item>
        /// <item><description>redis_sharding: Cluster architecture of open-source Redis.</description></item>
        /// <item><description>redis_splitrw: Read/write splitting architecture of open-source Redis.</description></item>
        /// <item><description>mongodb: ApsaraDB for MongoDB (replica set).</description></item>
        /// <item><description>mongodb_sharding: ApsaraDB for MongoDB (sharded cluster).</description></item>
        /// <item><description>hbase: ApsaraDB for HBase.</description></item>
        /// <item><description>elasticsearch: Elasticsearch.</description></item>
        /// <item><description>opensearch: OpenSearch.</description></item>
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
