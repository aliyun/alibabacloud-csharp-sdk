// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterKubeconfigStatesRequest : TeaModel {
        /// <summary>
        /// <para>Whether to query the KubeConfig list of service roles for cloud products within the cluster.  </para>
        /// <list type="bullet">
        /// <item><description>true: Query the KubeConfig list of service roles for cloud products within the cluster.  </description></item>
        /// <item><description>false: Query the KubeConfig list of Resource Access Management (RAM) users or roles within the cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("cloudServiceKubeConfig")]
        [Validation(Required=false)]
        public bool? CloudServiceKubeConfig { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: ≥ 1.</description></item>
        /// <item><description>Default value: 1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 10 to 50.</description></item>
        /// <item><description>Default value: 10</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
