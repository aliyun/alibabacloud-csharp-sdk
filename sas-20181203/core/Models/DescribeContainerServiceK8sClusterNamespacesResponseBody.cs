// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerServiceK8sClusterNamespacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The namespaces.</para>
        /// </summary>
        [NameInMap("K8sClusterNamespaces")]
        [Validation(Required=false)]
        public List<DescribeContainerServiceK8sClusterNamespacesResponseBodyK8sClusterNamespaces> K8sClusterNamespaces { get; set; }
        public class DescribeContainerServiceK8sClusterNamespacesResponseBodyK8sClusterNamespaces : TeaModel {
            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C8487EF-50C2-54BB-8634-10F8C35D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
