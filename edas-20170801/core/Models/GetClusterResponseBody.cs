// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster information.</para>
        /// </summary>
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public GetClusterResponseBodyCluster Cluster { get; set; }
        public class GetClusterResponseBodyCluster : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5439271a-015b-433d-befb-d76d****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster import status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Imported.</description></item>
            /// <item><description>2: Import failed.</description></item>
            /// <item><description>3: Importing.</description></item>
            /// <item><description>4: Cluster deleted.</description></item>
            /// <item><description>0: Not imported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ClusterImportStatus")]
            [Validation(Required=false)]
            public int? ClusterImportStatus { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClusterTest</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The cluster type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Common Docker cluster.</description></item>
            /// <item><description>1: Swarm cluster.</description></item>
            /// <item><description>2: ECS cluster.</description></item>
            /// <item><description>3: EDAS self-managed Kubernetes cluster.</description></item>
            /// <item><description>4: Pandora auto-registered application cluster.</description></item>
            /// <item><description>5: Container Service Kubernetes cluster.</description></item>
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
            /// <para>The timestamp when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570708232145</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The Container Service cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c2ce62869f4d4466b920312315f05****</para>
            /// </summary>
            [NameInMap("CsClusterId")]
            [Validation(Required=false)]
            public string CsClusterId { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The IaaS resource provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("IaasProvider")]
            [Validation(Required=false)]
            public string IaasProvider { get; set; }

            /// <summary>
            /// <para>The total memory. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// <para>The amount of used memory. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("MemUsed")]
            [Validation(Required=false)]
            public int? MemUsed { get; set; }

            /// <summary>
            /// <para>The network type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Classic network.</description></item>
            /// <item><description>2: VPC.</description></item>
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
            /// <para>The CPU overselling ratio for Docker clusters. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: 1:1 ratio. No overselling.</description></item>
            /// <item><description>2: 1:2 overselling ratio.</description></item>
            /// <item><description>4: 1:4 overselling ratio.</description></item>
            /// <item><description>8: 1:8 overselling ratio.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OversoldFactor")]
            [Validation(Required=false)]
            public int? OversoldFactor { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The subtype of the Kubernetes cluster. ManagedKubernetes indicates an ACK cluster, Ask indicates an ASK cluster, and ExternalKubernetes indicates an external cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes</para>
            /// </summary>
            [NameInMap("SubClusterType")]
            [Validation(Required=false)]
            public string SubClusterType { get; set; }

            /// <summary>
            /// <para>The timestamp when the cluster was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570708232145</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxxxz1mlwpb****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The detailed message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d76db491</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
