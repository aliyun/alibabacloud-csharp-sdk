// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeUpgradeVersionResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The version information.
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public DescribeUpgradeVersionResponseBodyVersion Version { get; set; }
        public class DescribeUpgradeVersionResponseBodyVersion : TeaModel {
            /// <summary>
            /// The version of the ASM instance.
            /// </summary>
            [NameInMap("IstioOperatorVersion")]
            [Validation(Required=false)]
            public string IstioOperatorVersion { get; set; }

            /// <summary>
            /// The Istio version.
            /// </summary>
            [NameInMap("IstioVersion")]
            [Validation(Required=false)]
            public string IstioVersion { get; set; }

            /// <summary>
            /// The Kubernetes version.
            /// </summary>
            [NameInMap("KubernetesVersion")]
            [Validation(Required=false)]
            public string KubernetesVersion { get; set; }

        }

    }

}
