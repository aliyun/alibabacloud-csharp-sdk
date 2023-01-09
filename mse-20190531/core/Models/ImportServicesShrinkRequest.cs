// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ImportServicesShrinkRequest : TeaModel {
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
        /// The information about services.
        /// </summary>
        [NameInMap("ServiceList")]
        [Validation(Required=false)]
        public string ServiceListShrink { get; set; }

        /// <summary>
        /// The service source. Valid values:
        /// 
        /// *   MSE: MSE Nacos instance
        /// *   K8s: ACK cluster
        /// *   VIP: fixed address
        /// *   DNS: DNS domain
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// The Transport Layer Security (TLS) settings. Valid values:
        /// 
        /// *   mode: TLS mode
        /// *   certId: certificate ID
        /// *   caCertId: CA certificate ID
        /// *   caCertContent: CA certificate public key
        /// *   sni: service name identification
        /// </summary>
        [NameInMap("TlsSetting")]
        [Validation(Required=false)]
        public string TlsSetting { get; set; }

    }

}
