// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyMonitorGroupInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ModifyMonitorGroupInstancesRequestInstances> Instances { get; set; }
        public class ModifyMonitorGroupInstancesRequestInstances : TeaModel {
            /// <summary>
            /// <para>The abbreviation of the name of the service to which the instances to be added to the application group belong. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ECS: Elastic Compute Service (ECS) instances provided by Alibaba Cloud and hosts not provided by Alibaba Cloud</para>
            /// </description></item>
            /// <item><description><para>RDS: ApsaraDB for RDS</para>
            /// </description></item>
            /// <item><description><para>ADS: AnalyticDB</para>
            /// </description></item>
            /// <item><description><para>SLB: Server Load Balancer (SLB)</para>
            /// </description></item>
            /// <item><description><para>VPC: Virtual Private Cloud (VPC)</para>
            /// </description></item>
            /// <item><description><para>APIGATEWAY: API Gateway</para>
            /// </description></item>
            /// <item><description><para>CDN: Alibaba Cloud Content Delivery Network (CDN)</para>
            /// </description></item>
            /// <item><description><para>CS: Container Service for Swarm</para>
            /// </description></item>
            /// <item><description><para>DCDN: Dynamic Route for CDN</para>
            /// </description></item>
            /// <item><description><para>DDoS: Anti-DDoS Pro</para>
            /// </description></item>
            /// <item><description><para>EIP: Elastic IP Address (EIP)</para>
            /// </description></item>
            /// <item><description><para>ELASTICSEARCH: Elasticsearch</para>
            /// </description></item>
            /// <item><description><para>EMR: E-MapReduce</para>
            /// </description></item>
            /// <item><description><para>ESS: Auto Scaling</para>
            /// </description></item>
            /// <item><description><para>HBASE: ApsaraDB for Hbase</para>
            /// </description></item>
            /// <item><description><para>IOT_EDGE: IoT Edge</para>
            /// </description></item>
            /// <item><description><para>K8S_POD: pods in Container Service for Kubernetes</para>
            /// </description></item>
            /// <item><description><para>KVSTORE_SHARDING: ApsaraDB for Redis of the cluster architecture</para>
            /// </description></item>
            /// <item><description><para>KVSTORE_SPLITRW: ApsaraDB for Redis of the read/write splitting architecture</para>
            /// </description></item>
            /// <item><description><para>KVSTORE_STANDARD: ApsaraDB for Redis of the standard architecture</para>
            /// </description></item>
            /// <item><description><para>MEMCACHE: ApsaraDB for Memcache</para>
            /// </description></item>
            /// <item><description><para>MNS: Message Service (MNS)</para>
            /// </description></item>
            /// <item><description><para>MONGODB: ApsaraDB for MongoDB of the replica set architecture</para>
            /// </description></item>
            /// <item><description><para>MONGODB_CLUSTER: ApsaraDB for MongoDB of the cluster architecture</para>
            /// </description></item>
            /// <item><description><para>MONGODB_SHARDING: ApsaraDB for MongoDB of the sharded cluster architecture</para>
            /// </description></item>
            /// <item><description><para>MQ_TOPIC: MNS topics</para>
            /// </description></item>
            /// <item><description><para>OCS: ApsaraDB for Memcache of earlier versions</para>
            /// </description></item>
            /// <item><description><para>OPENSEARCH: Open Search</para>
            /// </description></item>
            /// <item><description><para>OSS: Object Storage Service (OSS)</para>
            /// </description></item>
            /// <item><description><para>POLARDB: PolarDB</para>
            /// </description></item>
            /// <item><description><para>PETADATA: HybridDB for MySQL</para>
            /// </description></item>
            /// <item><description><para>SCDN: Secure Content Delivery Network (SCDN)</para>
            /// </description></item>
            /// <item><description><para>SHAREBANDWIDTHPACKAGES: EIP Bandwidth Plan</para>
            /// </description></item>
            /// <item><description><para>SLS: Log Service</para>
            /// </description></item>
            /// <item><description><para>VPN: VPN Gateway</para>
            /// <para>Valid values of N: 1 to 2000.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The ID of the instance. Valid values of N: 1 to 2000.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-a2d5q7pm12****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance. Valid values of N: 1 to 2000.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HostName</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The ID of the region where the instance resides. Valid values of N: 1 to 2000.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
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
