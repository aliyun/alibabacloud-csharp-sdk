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
        /// - zh: Chinese
        /// - en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The type of the destination service.
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
        /// The IDs of domain names with which the route is associated.
        /// </summary>
        [NameInMap("DomainIdListJSON")]
        [Validation(Required=false)]
        public string DomainIdListJSON { get; set; }

        [NameInMap("EnableWaf")]
        [Validation(Required=false)]
        public bool? EnableWaf { get; set; }

        [NameInMap("Fallback")]
        [Validation(Required=false)]
        public bool? Fallback { get; set; }

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
        public string Name { get; set; }

        /// <summary>
        /// The matching rules of the route.
        /// </summary>
        [NameInMap("Predicates")]
        [Validation(Required=false)]
        public string PredicatesShrink { get; set; }

        /// <summary>
        /// The configuration of the redirect action.
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
        /// The information about services.
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public string ServicesShrink { get; set; }

    }

}
