// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteMonitorGroupInstancesRequest : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The instances to be removed from the application group. Separate multiple instances with commas (,). You can remove a maximum of 20 instances from an application group at a time.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The abbreviation of the service name. Valid values:
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
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public string InstanceIdList { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
