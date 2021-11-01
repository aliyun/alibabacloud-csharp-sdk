// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateOIDCProviderRequest : TeaModel {
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public string ClientIds { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Fingerprints")]
        [Validation(Required=false)]
        public string Fingerprints { get; set; }

        [NameInMap("IssuerUrl")]
        [Validation(Required=false)]
        public string IssuerUrl { get; set; }

        [NameInMap("OIDCProviderName")]
        [Validation(Required=false)]
        public string OIDCProviderName { get; set; }

    }

}
