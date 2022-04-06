// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateIstioGatewayDomainsRequest : TeaModel {
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public string Credential { get; set; }

        [NameInMap("ForceHttps")]
        [Validation(Required=false)]
        public bool? ForceHttps { get; set; }

        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public string Hosts { get; set; }

        [NameInMap("IstioGatewayName")]
        [Validation(Required=false)]
        public string IstioGatewayName { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("Number")]
        [Validation(Required=false)]
        public int? Number { get; set; }

        [NameInMap("PortName")]
        [Validation(Required=false)]
        public string PortName { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
