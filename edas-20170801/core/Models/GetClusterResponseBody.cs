// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the cluster.</para>
        /// </summary>
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public GetClusterResponseBodyCluster Cluster { get; set; }
        public class GetClusterResponseBodyCluster : TeaModel {
            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5439271a-015b-433d-befb-d76d****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The import status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The cluster is imported.</description></item>
            /// <item><description>2: The cluster fails to be imported.</description></item>
            /// <item><description>3: The cluster is being imported.</description></item>
            /// <item><description>4: The cluster is deleted.</description></item>
            /// <item><description>0: The cluster is not imported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ClusterImportStatus")]
            [Validation(Required=false)]
            public int? ClusterImportStatus { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClusterTest</para>
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
            /// <item><description>3: self-managed Kubernetes cluster in EDAS</description></item>
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
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The number of used CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CpuUsed")]
            [Validation(Required=false)]
            public int? CpuUsed { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570708232145</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the Container Service for Kubernetes (ACK) cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c2ce62869f4d4466b920312315f05****</para>
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
            /// <para>The provider of Infrastructure as a Service (IaaS) resources used in the cluster.</para>
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
            /// <para>2048</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// <para>The size of used memory. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
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
            /// <para>2</para>
            /// </summary>
            [NameInMap("NetworkMode")]
            [Validation(Required=false)]
            public int? NetworkMode { get; set; }

            /// <summary>
            /// <para>The number of ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            /// <summary>
            /// <para>The overcommit ratio supported by a Docker cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: 1:1, which means that resources are not overcommitted.</description></item>
            /// <item><description>2: 1:2, which means that resources are overcommitted by 1:2.</description></item>
            /// <item><description>4: 1:4, which means that resources are overcommitted by 1:4.</description></item>
            /// <item><description>8: 1:8, which means that resources are overcommitted by 1:8.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OversoldFactor")]
            [Validation(Required=false)]
            public int? OversoldFactor { get; set; }

            /// <summary>
            /// <para>The ID of the region where the cluster resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The subtype of the Kubernetes cluster. Valid values: ManagedKubernetes, Ask, and ExternalKubernetes. ManagedKubernetes refers to the ACK cluster. Ask refers to the Serverless Kubernetes (ASK) cluster. ExternalKubernetes refers to the external cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes</para>
            /// </summary>
            [NameInMap("SubClusterType")]
            [Validation(Required=false)]
            public string SubClusterType { get; set; }

            /// <summary>
            /// <para>The time when the cluster was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570708232145</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxxxz1mlwpb****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

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
        /// <para>The detailed information that is returned.</para>
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
        /// <para>d76db491</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
