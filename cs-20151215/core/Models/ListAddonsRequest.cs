// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListAddonsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.
        /// If you specify a cluster ID, the system queries the list of available components for the specified cluster, and all other parameters are ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c02b3e03be10643e8a644a843ffcb****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster specification.
        /// If cluster_id is specified, this parameter is ignored.
        /// The region_id, cluster_type, profile, cluster_spec, and cluster_version parameters must be specified together.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>The cluster type.
        /// If cluster_id is specified, this parameter is ignored.
        /// The region_id, cluster_type, profile, cluster_spec, and cluster_version parameters must be specified together.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ManagedKubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The cluster version.
        /// If cluster_id is specified, this parameter is ignored.
        /// The region_id, cluster_type, profile, cluster_spec, and cluster_version parameters must be specified together.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("cluster_version")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// <para>The cluster subtype.
        /// If cluster_id is specified, this parameter is ignored.
        /// The region_id, cluster_type, profile, cluster_spec, and cluster_version parameters must be specified together.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>The region.
        /// If cluster_id is specified, this parameter is ignored.
        /// The region_id, cluster_type, profile, cluster_spec, and cluster_version parameters must be specified together.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
