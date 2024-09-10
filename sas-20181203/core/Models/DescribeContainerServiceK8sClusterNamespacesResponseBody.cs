// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerServiceK8sClusterNamespacesResponseBody : TeaModel {
        /// <summary>
        /// The namespaces.
        /// </summary>
        [NameInMap("K8sClusterNamespaces")]
        [Validation(Required=false)]
        public List<DescribeContainerServiceK8sClusterNamespacesResponseBodyK8sClusterNamespaces> K8sClusterNamespaces { get; set; }
        public class DescribeContainerServiceK8sClusterNamespacesResponseBodyK8sClusterNamespaces : TeaModel {
            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
