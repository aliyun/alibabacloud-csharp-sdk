// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class EnableClusterMeshRequest : TeaModel {
        [NameInMap("CertificateAuthorityData")]
        [Validation(Required=false)]
        public string CertificateAuthorityData { get; set; }

        [NameInMap("ClientCertificateData")]
        [Validation(Required=false)]
        public string ClientCertificateData { get; set; }

        [NameInMap("ClientKeyData")]
        [Validation(Required=false)]
        public string ClientKeyData { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("Server")]
        [Validation(Required=false)]
        public string Server { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
