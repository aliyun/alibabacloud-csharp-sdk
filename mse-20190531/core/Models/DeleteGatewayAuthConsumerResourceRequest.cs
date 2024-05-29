// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class DeleteGatewayAuthConsumerResourceRequest : TeaModel {
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
        /// The consumer ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public long? ConsumerId { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The IDs of the authorized resources that you want to delete.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public string IdList { get; set; }

    }

}
