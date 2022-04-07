// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteShrinkRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        [NameInMap("DirectResponseJSON")]
        [Validation(Required=false)]
        public string DirectResponseJSONShrink { get; set; }

        [NameInMap("DomainIdListJSON")]
        [Validation(Required=false)]
        public string DomainIdListJSON { get; set; }

        [NameInMap("EnableWaf")]
        [Validation(Required=false)]
        public bool? EnableWaf { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Predicates")]
        [Validation(Required=false)]
        public string PredicatesShrink { get; set; }

        [NameInMap("RedirectJSON")]
        [Validation(Required=false)]
        public string RedirectJSONShrink { get; set; }

        [NameInMap("RouteOrder")]
        [Validation(Required=false)]
        public int? RouteOrder { get; set; }

        [NameInMap("Services")]
        [Validation(Required=false)]
        public string ServicesShrink { get; set; }

    }

}
