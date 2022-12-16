// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddServiceSourceRequest : TeaModel {
        /// <summary>
        /// The language in which the returned information is displayed. Valid values:
        /// 
        /// - zh-CN: Chinese. This is the default value.
        /// - en-US: English.
        /// - ja: Japanese.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The address of the service.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// GroupList.
        /// </summary>
        [NameInMap("GroupList")]
        [Validation(Required=false)]
        public List<string> GroupList { get; set; }

        /// <summary>
        /// The Ingress configuration.
        /// </summary>
        [NameInMap("IngressOptionsRequest")]
        [Validation(Required=false)]
        public AddServiceSourceRequestIngressOptionsRequest IngressOptionsRequest { get; set; }
        public class AddServiceSourceRequestIngressOptionsRequest : TeaModel {
            /// <summary>
            /// Specifies whether to enable Ingress.
            /// </summary>
            [NameInMap("EnableIngress")]
            [Validation(Required=false)]
            public bool? EnableIngress { get; set; }

            /// <summary>
            /// Update the Ingress Status.
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
            /// The namespace that you want to monitor.
            /// </summary>
            [NameInMap("WatchNamespace")]
            [Validation(Required=false)]
            public string WatchNamespace { get; set; }

        }

        /// <summary>
        /// The name of the service.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// Service root path array.
        /// </summary>
        [NameInMap("PathList")]
        [Validation(Required=false)]
        public List<string> PathList { get; set; }

        /// <summary>
        /// The type of the service source.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The service type.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
