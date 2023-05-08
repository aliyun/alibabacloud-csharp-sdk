// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGuestClusterPodsRequest : TeaModel {
        /// <summary>
        /// The ID of the Kubernetes cluster that is added to the ASM instance.
        /// </summary>
        [NameInMap("GuestClusterID")]
        [Validation(Required=false)]
        public string GuestClusterID { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The ID of the ASM instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
