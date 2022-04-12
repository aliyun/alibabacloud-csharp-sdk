// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class CreateK8sSecretRequest : TeaModel {
        [NameInMap("Base64Encoded")]
        [Validation(Required=false)]
        public bool? Base64Encoded { get; set; }

        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        [NameInMap("CertRegionId")]
        [Validation(Required=false)]
        public string CertRegionId { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
