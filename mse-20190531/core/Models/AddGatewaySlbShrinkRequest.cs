// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewaySlbShrinkRequest : TeaModel {
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
        /// The unique ID of the gateway.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The HTTP port number (virtual service group).
        /// </summary>
        [NameInMap("HttpPort")]
        [Validation(Required=false)]
        public int? HttpPort { get; set; }

        /// <summary>
        /// The HTTPS port number (virtual service group).
        /// </summary>
        [NameInMap("HttpsPort")]
        [Validation(Required=false)]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// The ID of the HTTPS virtual service group.
        /// </summary>
        [NameInMap("HttpsVServerGroupId")]
        [Validation(Required=false)]
        public string HttpsVServerGroupId { get; set; }

        /// <summary>
        /// The service weight.
        /// </summary>
        [NameInMap("ServiceWeight")]
        [Validation(Required=false)]
        public int? ServiceWeight { get; set; }

        /// <summary>
        /// The ID of the SLB instance.
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// The type of the service source. Valid values:
        /// 
        /// *   PUB_NET: Internet
        /// *   PRIVATE_NET: VPC
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the HTTP virtual service group.
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        /// <summary>
        /// The SLB monitoring information.
        /// </summary>
        [NameInMap("VServiceList")]
        [Validation(Required=false)]
        public string VServiceListShrink { get; set; }

    }

}
