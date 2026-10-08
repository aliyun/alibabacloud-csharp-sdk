// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sClusterRequest : TeaModel {
        /// <summary>
        /// <para>The type of the Kubernetes cluster:</para>
        /// <list type="bullet">
        /// <item><description><para>5: an ACK cluster.</para>
        /// </description></item>
        /// <item><description><para>7: a self-managed Kubernetes cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public int? ClusterType { get; set; }

        /// <summary>
        /// <para>The number of the page to return for a paged query. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. The default value is 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionTag")]
        [Validation(Required=false)]
        public string RegionTag { get; set; }

        /// <summary>
        /// <para>The subtype of the cluster:</para>
        /// <list type="bullet">
        /// <item><description><para>Ask: an ASK cluster.</para>
        /// </description></item>
        /// <item><description><para>ManagedKubernetes: an ACK cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ask</para>
        /// </summary>
        [NameInMap("SubClusterType")]
        [Validation(Required=false)]
        public string SubClusterType { get; set; }

    }

}
