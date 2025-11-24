// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGuestClusterNamespacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The labels of the namespaces. Labels are returned only when <c>ShowNsLabels</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;default&quot;:{&quot;istio-injection&quot;:&quot;enabled&quot;}}</para>
        /// </summary>
        [NameInMap("NsLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> NsLabels { get; set; }

        /// <summary>
        /// <para>The names of the namespaces.</para>
        /// </summary>
        [NameInMap("NsList")]
        [Validation(Required=false)]
        public List<string> NsList { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31d3a0f0-07ed-4f6e-9004-1804498c****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
