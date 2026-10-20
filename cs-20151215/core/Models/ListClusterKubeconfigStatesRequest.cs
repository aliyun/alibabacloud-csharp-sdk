// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterKubeconfigStatesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the list of KubeConfigs for cloud service roles in the cluster.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Queries the list of KubeConfigs for cloud service roles in the cluster.</description></item>
        /// <item><description>false: Queries the list of KubeConfigs for Resource Access Management (RAM) users or roles in the cluster.</description></item>
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
        /// <para>Valid values: integers greater than or equal to 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
