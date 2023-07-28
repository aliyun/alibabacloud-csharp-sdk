// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupInstancesRequest : TeaModel {
        /// <summary>
        /// The abbreviation of the name of the service to which the instances in the application group belong. Valid values:
        /// 
        /// *   ECS: Elastic Compute Service (ECS) instances provided by Alibaba Cloud and hosts not provided by Alibaba Cloud
        /// *   RDS: ApsaraDB for RDS
        /// *   ADS: AnalyticDB
        /// *   SLB: Server Load Balancer (SLB)
        /// *   VPC: Virtual Private Cloud (VPC)
        /// *   APIGATEWAY: API Gateway
        /// *   CDN: Alibaba Cloud Content Delivery Network (CDN)
        /// *   CS: Container Service for Swarm
        /// *   DCDN: Dynamic Route for CDN
        /// *   DDoS: Anti-DDoS Pro
        /// *   EIP: Elastic IP Address (EIP)
        /// *   ELASTICSEARCH: Elasticsearch
        /// *   EMR: E-MapReduce
        /// *   ESS: Auto Scaling
        /// *   HBASE: ApsaraDB for Hbase
        /// *   IOT_EDGE: IoT Edge
        /// *   K8S_POD: pods in Container Service for Kubernetes
        /// *   KVSTORE_SHARDING: ApsaraDB for Redis of the cluster architecture
        /// *   KVSTORE_SPLITRW: ApsaraDB for Redis of the read/write splitting architecture
        /// *   KVSTORE_STANDARD: ApsaraDB for Redis of the standard architecture
        /// *   MEMCACHE: ApsaraDB for Memcache
        /// *   MNS: Message Service (MNS)
        /// *   MONGODB: ApsaraDB for MongoDB of the replica set architecture
        /// *   MONGODB_CLUSTER: ApsaraDB for MongoDB of the cluster architecture
        /// *   MONGODB_SHARDING: ApsaraDB for MongoDB of the sharded cluster architecture
        /// *   MQ_TOPIC: MNS topics
        /// *   OCS: ApsaraDB for Memcache of earlier versions
        /// *   OPENSEARCH: Open Search
        /// *   OSS: Object Storage Service (OSS)
        /// *   POLARDB: PolarDB
        /// *   PETADATA: HybridDB for MySQL
        /// *   SCDN: Secure Content Delivery Network (SCDN)
        /// *   SHAREBANDWIDTHPACKAGES: EIP Bandwidth Plan
        /// *   SLS: Log Service
        /// *   VPN: VPN Gateway
        /// 
        /// Valid values of N: 1 to 200.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The ID of the application group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The ID of the instance. You can query multiple instances by specifying multiple IDs.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The keyword used to search for instances. Fuzzy search based on instance name is supported.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
