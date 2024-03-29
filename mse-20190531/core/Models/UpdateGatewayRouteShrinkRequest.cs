// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteShrinkRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The destination service type.
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// The information about service mocking.
        /// </summary>
        [NameInMap("DirectResponseJSON")]
        [Validation(Required=false)]
        public string DirectResponseJSONShrink { get; set; }

        /// <summary>
        /// The associated domain name.
        /// </summary>
        [NameInMap("DomainIdListJSON")]
        [Validation(Required=false)]
        public string DomainIdListJSON { get; set; }

        /// <summary>
        /// Specifies whether to activate Web Application Firewall (WAF).
        /// </summary>
        [NameInMap("EnableWaf")]
        [Validation(Required=false)]
        public bool? EnableWaf { get; set; }

        /// <summary>
        /// Specifies whether to enable the Fallback service.
        /// </summary>
        [NameInMap("Fallback")]
        [Validation(Required=false)]
        public bool? Fallback { get; set; }

        /// <summary>
        /// The information about the Fallback service.
        /// </summary>
        [NameInMap("FallbackServices")]
        [Validation(Required=false)]
        public string FallbackServicesShrink { get; set; }

        /// <summary>
        /// The ID of the gateway.
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The ID of the route.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The name of the route.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        [Obsolete]
        public string Name { get; set; }

        /// <summary>
        /// The route matching conditions.
        /// </summary>
        [NameInMap("Predicates")]
        [Validation(Required=false)]
        public string PredicatesShrink { get; set; }

        /// <summary>
        /// The information about redirection.
        /// </summary>
        [NameInMap("RedirectJSON")]
        [Validation(Required=false)]
        public string RedirectJSONShrink { get; set; }

        /// <summary>
        /// The sequence number of the route.
        /// </summary>
        [NameInMap("RouteOrder")]
        [Validation(Required=false)]
        public int? RouteOrder { get; set; }

        /// <summary>
        /// The information about destination services.
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public string ServicesShrink { get; set; }

    }

}
