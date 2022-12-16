// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddServiceSourceShrinkRequest : TeaModel {
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
        public string GroupListShrink { get; set; }

        /// <summary>
        /// The Ingress configuration.
        /// </summary>
        [NameInMap("IngressOptionsRequest")]
        [Validation(Required=false)]
        public string IngressOptionsRequestShrink { get; set; }

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
        public string PathListShrink { get; set; }

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
