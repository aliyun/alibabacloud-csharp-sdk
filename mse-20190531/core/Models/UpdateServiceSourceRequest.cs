// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateServiceSourceRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("IngressOptionsRequest")]
        [Validation(Required=false)]
        public UpdateServiceSourceRequestIngressOptionsRequest IngressOptionsRequest { get; set; }
        public class UpdateServiceSourceRequestIngressOptionsRequest : TeaModel {
            [NameInMap("EnableIngress")]
            [Validation(Required=false)]
            public bool? EnableIngress { get; set; }

            [NameInMap("IngressClass")]
            [Validation(Required=false)]
            public string IngressClass { get; set; }

            [NameInMap("WatchNamespace")]
            [Validation(Required=false)]
            public string WatchNamespace { get; set; }

        }

        [NameInMap("MseSessionId")]
        [Validation(Required=false)]
        public string MseSessionId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
