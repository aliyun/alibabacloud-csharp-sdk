// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sConfigMapsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c0830281-366c-41b6-80fb-542e76******</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The filter conditions. Set this parameter to a JSON string in the format of {&quot;field&quot;:&quot;Name&quot;, &quot;pattern&quot;:&quot;configmap-&quot;}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;field&quot;:&quot;Name&quot;, &quot;pattern&quot;:&quot;configmap-&quot;}</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public Dictionary<string, object> Condition { get; set; }

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
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
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
        /// <para>Specifies whether to return a list of applications that use a ConfigMap. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowRelatedApps")]
        [Validation(Required=false)]
        public bool? ShowRelatedApps { get; set; }

    }

}
