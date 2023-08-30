// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayAuthConsumerResourceStatusRequest : TeaModel {
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
        /// The ID of the consumer.
        /// </summary>
        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public long? ConsumerId { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The list of IDs of the authorized resources that a user wants to update.
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public string IdList { get; set; }

        /// <summary>
        /// The resource authorization status. Valid values:
        /// 
        /// *   true: enabled
        /// *   false: disabled
        /// </summary>
        [NameInMap("ResourceStatus")]
        [Validation(Required=false)]
        public bool? ResourceStatus { get; set; }

    }

}
