// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyMonitorGroupInstancesRequest : TeaModel {
        /// <summary>
        /// The ID of the application group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ModifyMonitorGroupInstancesRequestInstances> Instances { get; set; }
        public class ModifyMonitorGroupInstancesRequestInstances : TeaModel {
            /// <summary>
            /// The abbreviation of the name of the service to which the instances to be added to the application group belong. Valid values:
            /// 
            /// *   ECS: Elastic Compute Service (ECS) instances provided by Alibaba Cloud and hosts not provided by Alibaba Cloud
            /// 
            /// *   RDS: ApsaraDB for RDS
            /// 
            /// *   ADS: AnalyticDB
            /// 
            /// *   SLB: Server Load Balancer (SLB)
            /// 
            /// *   VPC: Virtual Private Cloud (VPC)
            /// 
            /// *   APIGATEWAY: API Gateway
            /// 
            /// *   CDN: Alibaba Cloud Content Delivery Network (CDN)
            /// 
            /// *   CS: Container Service for Swarm
            /// 
            /// *   DCDN: Dynamic Route for CDN
            /// 
            /// *   DDoS: Anti-DDoS Pro
            /// 
            /// *   EIP: Elastic IP Address (EIP)
            /// 
            /// *   ELASTICSEARCH: Elasticsearch
            /// 
            /// *   EMR: E-MapReduce
            /// 
            /// *   ESS: Auto Scaling
            /// 
            /// *   HBASE: ApsaraDB for Hbase
            /// 
            /// *   IOT_EDGE: IoT Edge
            /// 
            /// *   K8S_POD: pods in Container Service for Kubernetes
            /// 
            /// *   KVSTORE_SHARDING: ApsaraDB for Redis of the cluster architecture
            /// 
            /// *   KVSTORE_SPLITRW: ApsaraDB for Redis of the read/write splitting architecture
            /// 
            /// *   KVSTORE_STANDARD: ApsaraDB for Redis of the standard architecture
            /// 
            /// *   MEMCACHE: ApsaraDB for Memcache
            /// 
            /// *   MNS: Message Service (MNS)
            /// 
            /// *   MONGODB: ApsaraDB for MongoDB of the replica set architecture
            /// 
            /// *   MONGODB_CLUSTER: ApsaraDB for MongoDB of the cluster architecture
            /// 
            /// *   MONGODB_SHARDING: ApsaraDB for MongoDB of the sharded cluster architecture
            /// 
            /// *   MQ_TOPIC: MNS topics
            /// 
            /// *   OCS: ApsaraDB for Memcache of earlier versions
            /// 
            /// *   OPENSEARCH: Open Search
            /// 
            /// *   OSS: Object Storage Service (OSS)
            /// 
            /// *   POLARDB: PolarDB
            /// 
            /// *   PETADATA: HybridDB for MySQL
            /// 
            /// *   SCDN: Secure Content Delivery Network (SCDN)
            /// 
            /// *   SHAREBANDWIDTHPACKAGES: EIP Bandwidth Plan
            /// 
            /// *   SLS: Log Service
            /// 
            /// *   VPN: VPN Gateway
            /// 
            ///     Valid values of N: 1 to 2000.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The ID of the instance. Valid values of N: 1 to 2000.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the instance. Valid values of N: 1 to 2000.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The ID of the region where the instance resides. Valid values of N: 1 to 2000.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
