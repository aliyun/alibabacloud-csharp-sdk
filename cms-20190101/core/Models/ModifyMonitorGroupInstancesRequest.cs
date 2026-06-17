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
        /// <para>The list of instances. You can specify up to 2,000 instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ModifyMonitorGroupInstancesRequestInstances> Instances { get; set; }
        public class ModifyMonitorGroupInstancesRequestInstances : TeaModel {
            /// <summary>
            /// <para>The cloud service to which the resource instance belongs. The following cloud services are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>ECS (including Alibaba Cloud and third-party hosts)</para>
            /// </description></item>
            /// <item><description><para>ApsaraDB RDS</para>
            /// </description></item>
            /// <item><description><para>AnalyticDB</para>
            /// </description></item>
            /// <item><description><para>SLB</para>
            /// </description></item>
            /// <item><description><para>VPC (Elastic IP)</para>
            /// </description></item>
            /// <item><description><para>API Gateway</para>
            /// </description></item>
            /// <item><description><para>Alibaba Cloud CDN</para>
            /// </description></item>
            /// <item><description><para>Container Service for Swarm</para>
            /// </description></item>
            /// <item><description><para>DCDN</para>
            /// </description></item>
            /// <item><description><para>Anti-DDoS</para>
            /// </description></item>
            /// <item><description><para>EIP</para>
            /// </description></item>
            /// <item><description><para>Elasticsearch</para>
            /// </description></item>
            /// <item><description><para>E-MapReduce</para>
            /// </description></item>
            /// <item><description><para>Auto Scaling</para>
            /// </description></item>
            /// <item><description><para>ApsaraDB for HBase</para>
            /// </description></item>
            /// <item><description><para>IoT Edge</para>
            /// </description></item>
            /// <item><description><para>Kubernetes pod</para>
            /// </description></item>
            /// <item><description><para>ApsaraDB for Redis (sharded cluster)</para>
            /// </description></item>
            /// <item><description><para>ApsaraDB for Redis (read/write splitting)</para>
            /// </description></item>
            /// <item><description><para>ApsaraDB for Redis (Standard Edition)</para>
            /// </description></item>
            /// <item><description><para>ApsaraDB for Memcache</para>
            /// </description></item>
            /// <item><description><para>MNS</para>
            /// </description></item>
            /// <item><description><para>ApsaraDB for MongoDB (replica set)</para>
            /// </description></item>
            /// <item><description><para>ApsaraDB for MongoDB (sharded cluster)</para>
            /// </description></item>
            /// <item><description><para>ApsaraDB for MongoDB (sharded cluster)</para>
            /// </description></item>
            /// <item><description><para>MNS topic</para>
            /// </description></item>
            /// <item><description><para>OCS (ApsaraDB for Memcache of earlier versions)</para>
            /// </description></item>
            /// <item><description><para>OpenSearch</para>
            /// </description></item>
            /// <item><description><para>OSS</para>
            /// </description></item>
            /// <item><description><para>PolarDB</para>
            /// </description></item>
            /// <item><description><para>HybridDB for MySQL</para>
            /// </description></item>
            /// <item><description><para>Internet Shared Bandwidth</para>
            /// </description></item>
            /// <item><description><para>SLS</para>
            /// </description></item>
            /// <item><description><para>VPN Gateway</para>
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
            /// <para>The ID of the resource instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-a2d5q7pm12****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HostName</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
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
