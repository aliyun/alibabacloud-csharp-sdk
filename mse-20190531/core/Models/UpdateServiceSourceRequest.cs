// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateServiceSourceRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese.
        /// *   en: English.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The address.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

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
        /// The ID of the service source.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The configurations of Ingress resources.
        /// </summary>
        [NameInMap("IngressOptionsRequest")]
        [Validation(Required=false)]
        public UpdateServiceSourceRequestIngressOptionsRequest IngressOptionsRequest { get; set; }
        public class UpdateServiceSourceRequestIngressOptionsRequest : TeaModel {
            /// <summary>
            /// Specifies whether to enable Ingress.
            /// </summary>
            [NameInMap("EnableIngress")]
            [Validation(Required=false)]
            public bool? EnableIngress { get; set; }

            /// <summary>
            /// Specifies whether to update the Ingress status.
            /// </summary>
            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public bool? EnableStatus { get; set; }

            /// <summary>
            /// Specifies whether to monitor Ingress classes.
            /// </summary>
            [NameInMap("IngressClass")]
            [Validation(Required=false)]
            public string IngressClass { get; set; }

            /// <summary>
            /// The namespace whose resources you want to monitor.
            /// </summary>
            [NameInMap("WatchNamespace")]
            [Validation(Required=false)]
            public string WatchNamespace { get; set; }

        }

        /// <summary>
        /// The name.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// An array of service root paths.
        /// </summary>
        [NameInMap("PathList")]
        [Validation(Required=false)]
        public List<string> PathList { get; set; }

        /// <summary>
        /// The service source. Valid values:
        /// 
        /// *   K8s: ACK cluster.
        /// *   MSE: Nacos instance.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The type of the service source. Valid values:
        /// 
        /// *   K8s: ACK cluster.
        /// *   NACOS: Nacos instance.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
