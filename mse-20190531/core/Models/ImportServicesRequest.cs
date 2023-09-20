// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ImportServicesRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("FcAlias")]
        [Validation(Required=false)]
        public string FcAlias { get; set; }

        [NameInMap("FcServiceName")]
        [Validation(Required=false)]
        public string FcServiceName { get; set; }

        [NameInMap("FcVersion")]
        [Validation(Required=false)]
        public string FcVersion { get; set; }

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
        public List<ImportServicesRequestServiceList> ServiceList { get; set; }
        public class ImportServicesRequestServiceList : TeaModel {
            /// <summary>
            /// The group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The IP addresses of the service.
            /// </summary>
            [NameInMap("Ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }

            /// <summary>
            /// The name of the service.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The port of the service.
            /// </summary>
            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public long? ServicePort { get; set; }

            /// <summary>
            /// The protocol of the service.
            /// </summary>
            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

        }

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
