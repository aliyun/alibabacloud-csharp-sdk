// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGuestClusterNamespacesRequest : TeaModel {
        /// <summary>
        /// The ID of the Kubernetes cluster that is added to the ASM instance.
        /// </summary>
        [NameInMap("GuestClusterID")]
        [Validation(Required=false)]
        public string GuestClusterID { get; set; }

        /// <summary>
        /// The ASM instance ID.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// Specifies whether to return the labels of the namespaces.
        /// </summary>
        [NameInMap("ShowNsLabels")]
        [Validation(Required=false)]
        public bool? ShowNsLabels { get; set; }

    }

}
