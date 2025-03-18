// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersForRegionRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c8155823d057948c69a****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The specification of the clusters to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ack.pro.small: ACK Pro clusters.</description></item>
        /// <item><description>ack.standard: ACK Basic clusters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ack.standard</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>The type of the clusters to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Kubernetes: ACK dedicated clusters.</description></item>
        /// <item><description>ManagedKubernetes: ACK managed clusters. ACK managed clusters include ACK Basic clusters, ACK Pro clusters, ACK Serverless Basic clusters, ACK Serverless Pro clusters, ACK Edge Basic clusters, ACK Edge Pro clusters, and ACK Lingjun Pro clusters.</description></item>
        /// <item><description>ExternalKubernetes: registered clusters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>Perform a fuzzy search by using the cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-cluster</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The subtype of the clusters to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Default: ACK managed clusters. ACK managed clusters include ACK Basic clusters and ACK Pro clusters.</description></item>
        /// <item><description>Edge: ACK Edge clusters. ACK Edge clusters include ACK Edge Basic clusters and ACK Edge Pro clusters.</description></item>
        /// <item><description>Serverless: ACK Serverless clusters. ACK Serverless clusters include ACK Serverless Basic clusters and ACK Serverless Pro clusters.</description></item>
        /// <item><description>Lingjun: ACK Lingjun Pro clusters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Serverless</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

    }

}
