// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayAuthConsumerRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EncodeType")]
        [Validation(Required=false)]
        public string EncodeType { get; set; }

        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Jwks")]
        [Validation(Required=false)]
        public string Jwks { get; set; }

        [NameInMap("KeyName")]
        [Validation(Required=false)]
        public string KeyName { get; set; }

        [NameInMap("KeyValue")]
        [Validation(Required=false)]
        public string KeyValue { get; set; }

        [NameInMap("TokenName")]
        [Validation(Required=false)]
        public string TokenName { get; set; }

        [NameInMap("TokenPass")]
        [Validation(Required=false)]
        public bool? TokenPass { get; set; }

        [NameInMap("TokenPosition")]
        [Validation(Required=false)]
        public string TokenPosition { get; set; }

        [NameInMap("TokenPrefix")]
        [Validation(Required=false)]
        public string TokenPrefix { get; set; }

    }

}
