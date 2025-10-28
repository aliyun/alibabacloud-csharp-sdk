// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The clusters.</para>
        /// </summary>
        [NameInMap("ClusterList")]
        [Validation(Required=false)]
        public ListClusterResponseBodyClusterList ClusterList { get; set; }
        public class ListClusterResponseBodyClusterList : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public List<ListClusterResponseBodyClusterListCluster> Cluster { get; set; }
            public class ListClusterResponseBodyClusterListCluster : TeaModel {
                /// <summary>
                /// <para>The ID of the cluster in EDAS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b98b5919-c111-4dad-9f74-7233********</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The name of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cluster-test</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// <para>The type of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: regular Docker cluster</description></item>
                /// <item><description>1: Swarm cluster</description></item>
                /// <item><description>2: Elastic Compute Service (ECS) cluster</description></item>
                /// <item><description>3: self-managed Kubernetes cluster in Enterprise Distributed Application Service (EDAS)</description></item>
                /// <item><description>4: cluster in which Pandora automatically registers applications</description></item>
                /// <item><description>5: ACK cluster</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public int? ClusterType { get; set; }

                /// <summary>
                /// <para>The total number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The number of used CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CpuUsed")]
                [Validation(Required=false)]
                public int? CpuUsed { get; set; }

                /// <summary>
                /// <para>The timestamp when the cluster was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1502888064561</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the cluster in Container Service for Kubernetes (ACK).</para>
                /// 
                /// <b>Example:</b>
                /// <para>c2ce************b9203a9</para>
                /// </summary>
                [NameInMap("CsClusterId")]
                [Validation(Required=false)]
                public string CsClusterId { get; set; }

                /// <summary>
                /// <para>The description of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The provider of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN</para>
                /// </summary>
                [NameInMap("IaasProvider")]
                [Validation(Required=false)]
                public string IaasProvider { get; set; }

                /// <summary>
                /// <para>The total size of memory. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3072</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                /// <summary>
                /// <para>The size of used memory. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("MemUsed")]
                [Validation(Required=false)]
                public int? MemUsed { get; set; }

                /// <summary>
                /// <para>The network type of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: classic network</description></item>
                /// <item><description>2: virtual private cloud (VPC)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NetworkMode")]
                [Validation(Required=false)]
                public int? NetworkMode { get; set; }

                /// <summary>
                /// <para>The number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NodeNum")]
                [Validation(Required=false)]
                public int? NodeNum { get; set; }

                /// <summary>
                /// <para>The CPU overcommit ratio that is supported by a Docker cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: 1:1, which means that CPU resources are not overcommitted.</description></item>
                /// <item><description>2: 1:2, which means that CPU resources are overcommitted by 1:2.</description></item>
                /// <item><description>4: 1:4, which means that CPU resources are overcommitted by 1:4.</description></item>
                /// <item><description>8: 1:8, which means that CPU resources are overcommitted by 1:8.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OversoldFactor")]
                [Validation(Required=false)]
                public int? OversoldFactor { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>461</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The timestamp when the cluster was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1533820823203</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>VPC ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-23727****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1053-08e4-47a5-b2ab-5c0323de****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
