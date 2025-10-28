// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sSecretsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7a953f9a-2946-4c7a-9d82-9939db******</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The filter conditions. Set this parameter to a JSON string in the format of {&quot;field&quot;:&quot;Name&quot;, &quot;pattern&quot;:&quot;configmap-&quot;}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;field\&quot;:\&quot;Name\&quot;,\&quot;pattern\&quot;:\&quot;product\&quot;}</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>The namespace of the Kubernetes cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from Page 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The value 0 indicates that all entries are returned on one page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return a list of applications that use a Secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowRelatedApps")]
        [Validation(Required=false)]
        public bool? ShowRelatedApps { get; set; }

    }

}
