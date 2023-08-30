// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayRouteRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Specifies whether to enable sorting. This parameter is unavailable.
        /// </summary>
        [NameInMap("DescSort")]
        [Validation(Required=false)]
        public bool? DescSort { get; set; }

        /// <summary>
        /// The parameters that specify filter conditions. The parameters are in the format of {"key1":"value1"}.
        /// </summary>
        [NameInMap("FilterParams")]
        [Validation(Required=false)]
        public ListGatewayRouteRequestFilterParams FilterParams { get; set; }
        public class ListGatewayRouteRequestFilterParams : TeaModel {
            /// <summary>
            /// The default service ID.
            /// </summary>
            [NameInMap("DefaultServiceId")]
            [Validation(Required=false)]
            public long? DefaultServiceId { get; set; }

            /// <summary>
            /// The domain ID.
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public long? DomainId { get; set; }

            /// <summary>
            /// The associated domain name.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

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
            /// The name of the gateway.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The order.
            /// </summary>
            [NameInMap("RouteOrder")]
            [Validation(Required=false)]
            public int? RouteOrder { get; set; }

            /// <summary>
            /// The status.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The item based on which entries are sorted.
        /// </summary>
        [NameInMap("OrderItem")]
        [Validation(Required=false)]
        public string OrderItem { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
