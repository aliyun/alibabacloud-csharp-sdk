// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sClusterRequest : TeaModel {
        /// <summary>
        /// <para>The type of the Kubernetes cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: ACK cluster</description></item>
        /// <item><description>7: self-managed Kubernetes cluster</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public int? ClusterType { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionTag")]
        [Validation(Required=false)]
        public string RegionTag { get; set; }

        /// <summary>
        /// <para>The subtype of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Ask: Serverless Kubernetes cluster</description></item>
        /// <item><description>ManagedKubernetes: ACK cluster</description></item>
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
