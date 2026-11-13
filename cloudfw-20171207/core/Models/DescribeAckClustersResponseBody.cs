// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAckClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ACK clusters.</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeAckClustersResponseBodyClusters> Clusters { get; set; }
        public class DescribeAckClustersResponseBodyClusters : TeaModel {
            /// <summary>
            /// <para>The ID of the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cb0f5640b1b2d404cad6ba21509d7847b</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-cluster-name</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The specifications of the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack.pro.small</para>
            /// </summary>
            [NameInMap("ClusterSpec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }

            /// <summary>
            /// <para>The type of the ACK cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ManagedKubernetes</b>: ACK managed clusters, including ACK managed clusters (Pro Edition and Basic Edition), ACK Serverless clusters (Pro Edition and Basic Edition), ACK Edge clusters (Pro Edition and Basic Edition), and ACK Lingjun clusters (Pro Edition).</description></item>
            /// <item><description><b>ExternalKubernetes</b>: registered cluster</description></item>
            /// <item><description><b>Kubernetes</b>: ACK dedicated cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the account to which the ACK cluster resources belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135809047715****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The network plug-in of the ACK cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>terway-eniip</b>: terway-eniip network plug-in</description></item>
            /// <item><description><b>Flannel</b>: flannel network plug-in</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>terway-eniip</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <para>The subtype of the cluster. This parameter is valid only when ClusterType is set to ManagedKubernetes (ACK managed clusters). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Default</b>: ACK managed cluster, including ACK managed cluster Pro Edition and Basic Edition</description></item>
            /// <item><description><b>Serverless</b>: ACK Serverless cluster, including ACK Serverless cluster Pro Edition and Basic Edition</description></item>
            /// <item><description><b>Edge</b>: ACK Edge cluster, including ACK Edge cluster Pro Edition and Basic Edition</description></item>
            /// <item><description><b>Lingjun</b>: ACK Lingjun cluster, which provides only the Pro Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("Profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

            /// <summary>
            /// <para>The region ID of the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The running status of the ACK cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>initial</b>: The cluster is being created.</description></item>
            /// <item><description><b>running</b>: The cluster is running.</description></item>
            /// <item><description><b>scaling</b>: The cluster is being scaled.</description></item>
            /// <item><description><b>stopped</b>: The cluster is stopped.</description></item>
            /// <item><description><b>upgrading</b>: The cluster is being upgraded.</description></item>
            /// <item><description><b>updating</b>: The cluster configurations are being updated.</description></item>
            /// <item><description><b>deleting</b>: The cluster is being deleted.</description></item>
            /// <item><description><b>deleted</b>: The cluster is deleted.</description></item>
            /// <item><description><b>draining</b>: Nodes are being drained.</description></item>
            /// <item><description><b>removing</b>: Nodes are being removed.</description></item>
            /// <item><description><b>failed</b>: The cluster failed to be created.</description></item>
            /// <item><description><b>delete_failed</b>: The cluster failed to be deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the ACK cluster belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2vcg932hsxsxuqbgl****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5DDD596-1191-5F36-A504-8733045A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
