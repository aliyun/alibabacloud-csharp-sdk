// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayAuthConsumerResourceRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public long? ConsumerId { get; set; }

        /// <summary>
        /// UpdateGatewayAuthConsumerResource
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public List<UpdateGatewayAuthConsumerResourceRequestResourceList> ResourceList { get; set; }
        public class UpdateGatewayAuthConsumerResourceRequestResourceList : TeaModel {
            [NameInMap("RouteId")]
            [Validation(Required=false)]
            public long? RouteId { get; set; }

            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

        }

    }

}
