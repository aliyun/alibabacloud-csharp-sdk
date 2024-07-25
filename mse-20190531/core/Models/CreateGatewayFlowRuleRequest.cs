// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateGatewayFlowRuleRequest : TeaModel {
        /// <summary>
        /// The language in which you want to display the results. Valid values: zh and en. zh indicates Chinese, which is the default value. en indicates English.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The type of the web fallback behavior.
        /// 
        /// 0: returns the specified content.
        /// 
        /// 1: redirects to the specified page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BehaviorType")]
        [Validation(Required=false)]
        public int? BehaviorType { get; set; }

        /// <summary>
        /// The encoding format.
        /// 
        /// 0: normal text
        /// 
        /// 1: JSON
        /// </summary>
        [NameInMap("BodyEncoding")]
        [Validation(Required=false)]
        public int? BodyEncoding { get; set; }

        /// <summary>
        /// Specifies whether to enable the throttling rule.
        /// 
        /// 0: disables the throttling rule.
        /// 
        /// 1: enables the throttling rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// The ID of the gateway.
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The HTTP text to be returned.
        /// </summary>
        [NameInMap("ResponseContentBody")]
        [Validation(Required=false)]
        public string ResponseContentBody { get; set; }

        /// <summary>
        /// The address to be redirected to.
        /// </summary>
        [NameInMap("ResponseRedirectUrl")]
        [Validation(Required=false)]
        public string ResponseRedirectUrl { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public int? ResponseStatusCode { get; set; }

        /// <summary>
        /// The ID of the route.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteId")]
        [Validation(Required=false)]
        public long? RouteId { get; set; }

        /// <summary>
        /// The name of the routing rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteName")]
        [Validation(Required=false)]
        public string RouteName { get; set; }

        /// <summary>
        /// The overall queries per second (QPS) threshold.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public int? Threshold { get; set; }

    }

}
