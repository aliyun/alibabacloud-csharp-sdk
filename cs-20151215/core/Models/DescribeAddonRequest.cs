// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAddonRequest : TeaModel {
        /// <summary>
        /// <para>Cluster ID.
        /// When a cluster ID is specified, the list of available components for the cluster is queried, and other parameters are ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c02b3e03be10643e8a644a843ffcb****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Cluster specification.
        /// If cluster_id is specified, this parameter is ignored.
        /// The five parameters region_id, cluster_type, profile, cluster_spec, and cluster_version must be specified together.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>Cluster type.
        /// If cluster_id is specified, this parameter is ignored.
        /// The five parameters region_id, cluster_type, profile, cluster_spec, and cluster_version must be specified together.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ManagedKubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>Cluster version.
        /// If cluster_id is specified, this parameter is ignored.
        /// The five parameters region_id, cluster_type, profile, cluster_spec, and cluster_version must be specified together.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.26.3-aliyun.1</para>
        /// </summary>
        [NameInMap("cluster_version")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// <para>Cluster subtype.
        /// If cluster_id is specified, this parameter is ignored.
        /// The five parameters region_id, cluster_type, profile, cluster_spec, and cluster_version must be specified together.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>Region.
        /// If cluster_id is specified, this parameter is ignored.
        /// The five parameters region_id, cluster_type, profile, cluster_spec, and cluster_version must be specified together.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Component version. If not specified, the latest available version of the component is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.9.3.10-7dfca203-aliyun</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
