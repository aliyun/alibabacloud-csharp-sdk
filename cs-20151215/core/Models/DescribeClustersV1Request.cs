// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersV1Request : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca418e5e6fa2849d78301341700axxxxx</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>After you set <c>cluster_type</c> to <c>ManagedKubernetes</c> and configure the <c>profile</c> parameter, you can further specify the edition of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ack.pro.small</c>: ACK Pro cluster.</description></item>
        /// <item><description><c>ack.standard</c>: ACK Basic cluster. If you leave the parameter empty, ACK Basic cluster is selected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>The type of the instance.</para>
        /// <list type="bullet">
        /// <item><description><c>Kubernetes</c>: ACK dedicated cluster.</description></item>
        /// <item><description><c>ManagedKubernetes</c>: ACK managed cluster. ACK managed clusters include ACK Basic clusters, ACK Pro clusters, ACK Serverless Basic clusters, ACK Serverless Pro clusters, ACK Edge Basic clusters, ACK Edge Pro clusters, and ACK Lingjun Pro clusters.</description></item>
        /// <item><description><c>ExternalKubernetes</c>: registered cluster</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster-demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>If you set <c>cluster_type</c> to <c>ManagedKubernetes</c>, an ACK managed cluster is created. In this case, you can further specify the cluster edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Default</c>: ACK managed cluster. ACK managed clusters include ACK Basic clusters and ACK Pro clusters.</description></item>
        /// <item><description><c>Edge</c>: ACK Edge cluster. ACK Edge clusters include ACK Edge Basic clusters and ACK Edge Pro clusters.</description></item>
        /// <item><description><c>Serverless</c>: ACK Serverless cluster. ACK Serverless clusters include ACK Serverless Basic clusters and ACK Serverless Pro clusters.</description></item>
        /// <item><description><c>Lingjun</c>: ACK Lingjun Pro cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>The region ID of the clusters. You can use this parameter to query all clusters in the specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
