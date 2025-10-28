// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sIngressRulesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b2b4ab4-efbc-4a81-9c45-xxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The filter conditions. Set the value to a JSON string in the format of {&quot;field&quot;:&quot;Name&quot;, &quot;pattern&quot;:&quot;my-&quot;}, where:</para>
        /// <list type="bullet">
        /// <item><description>field: the parameter to be matched. Valid values: Name and ClusterName.</description></item>
        /// <item><description>pattern: the content to be matched.</description></item>
        /// </list>
        /// <para>For example, a value of {&quot;field&quot;:&quot;Name&quot;, &quot;pattern&quot;:&quot;my-&quot;} indicates that the specified filter conditions match the routing rules whose names start with my-.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;field&quot;:&quot;Name&quot;, &quot;pattern&quot;:&quot;my-&quot;}</para>
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
        /// <para>The ID of the region where the cluster resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
