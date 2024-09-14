// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class ConfigClusterCertificateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterCertificate")]
        [Validation(Required=false)]
        public string ClusterCertificate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IssuerCertificate")]
        [Validation(Required=false)]
        public string IssuerCertificate { get; set; }

    }

}
