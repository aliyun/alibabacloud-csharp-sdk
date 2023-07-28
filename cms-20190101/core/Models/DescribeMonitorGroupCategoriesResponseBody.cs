// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupCategoriesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The cloud services to which the resources in the application group belong and the number of resources that belong to the cloud service.
        /// </summary>
        [NameInMap("MonitorGroupCategories")]
        [Validation(Required=false)]
        public DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategories MonitorGroupCategories { get; set; }
        public class DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategories : TeaModel {
            /// <summary>
            /// The ID of the application group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// One of the cloud services to which the resources in the application group belong and the number of resources that belong to the cloud service.
            /// </summary>
            [NameInMap("MonitorGroupCategory")]
            [Validation(Required=false)]
            public DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategoriesMonitorGroupCategory MonitorGroupCategory { get; set; }
            public class DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategoriesMonitorGroupCategory : TeaModel {
                [NameInMap("CategoryItem")]
                [Validation(Required=false)]
                public List<DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategoriesMonitorGroupCategoryCategoryItem> CategoryItem { get; set; }
                public class DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategoriesMonitorGroupCategoryCategoryItem : TeaModel {
                    /// <summary>
                    /// The name of the cloud service. Valid values:
                    /// 
                    /// *   ecs: Elastic Compute Service (ECS) instances that are provided by Alibaba Cloud and hosts that are not provided by Alibaba Cloud
                    /// *   rds: ApsaraDB RDS
                    /// *   ads: AnalyticDB
                    /// *   slb: Server Load Balancer (SLB)
                    /// *   vpc: Virtual Private Cloud (VPC)
                    /// *   apigateway: API Gateway
                    /// *   cdn: Alibaba Cloud Content Delivery Network (CDN)
                    /// *   cs: Container Service for Swarm
                    /// *   dcdn: Dynamic Route for CDN (DCDN)
                    /// *   ddos: Anti-DDoS
                    /// *   eip: Elastic IP Address (EIP)
                    /// *   elasticsearch: Elasticsearch
                    /// *   emr: E-MapReduce
                    /// *   ess: Auto Scaling
                    /// *   hbase: ApsaraDB for HBase
                    /// *   iot_edge: IoT Edge
                    /// *   k8s_pod: pods in Container Service for Kubernetes (ACK)
                    /// *   kvstore_sharding: ApsaraDB for Redis of the cluster master-replica architecture
                    /// *   kvstore_splitrw: ApsaraDB for Redis of the read/write splitting architecture
                    /// *   kvstore_standard: ApsaraDB for Redis of the standard master-replica architecture
                    /// *   memcache: ApsaraDB for Memcache
                    /// *   mns: Message Service (MNS)
                    /// *   mongodb: ApsaraDB for MongoDB of the replica set architecture
                    /// *   mongodb_cluster: ApsaraDB for MongoDB of the cluster architecture
                    /// *   mongodb_sharding: ApsaraDB for MongoDB of the sharded cluster architecture
                    /// *   mq_topic: MNS topics
                    /// *   ocs: ApsaraDB for Memcache of earlier versions
                    /// *   opensearch: Open Search
                    /// *   oss: Object Storage Service (OSS)
                    /// *   polardb: PolarDB
                    /// *   petadata: HybridDB for MySQL
                    /// *   scdn: Secure CDN (SCDN)
                    /// *   sharebandwidthpackages: EIP Bandwidth Plan
                    /// *   sls: Log Service
                    /// *   vpn: VPN Gateway
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// The number of resources that belong to the cloud service.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
