// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayAuthConsumerRequest : TeaModel {
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
        /// The description of the consumer.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The encryption type. Valid values:
        /// 
        /// *   RSA
        /// *   OCT
        /// </summary>
        [NameInMap("EncodeType")]
        [Validation(Required=false)]
        public string EncodeType { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The JWT public key. The JSON format is supported.
        /// </summary>
        [NameInMap("Jwks")]
        [Validation(Required=false)]
        public string Jwks { get; set; }

        /// <summary>
        /// The name of the key used for JWT-based identity authentication.
        /// </summary>
        [NameInMap("KeyName")]
        [Validation(Required=false)]
        public string KeyName { get; set; }

        /// <summary>
        /// The value of the key used for JWT-based identity authentication.
        /// </summary>
        [NameInMap("KeyValue")]
        [Validation(Required=false)]
        public string KeyValue { get; set; }

        /// <summary>
        /// The name of the consumer.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The names of the parameters that are required to verify each token. By default, each token is prefixed with Bearer and stored in the Authorization header, such as `Authorization: Bearer <Content of a token>`.
        /// </summary>
        [NameInMap("TokenName")]
        [Validation(Required=false)]
        public string TokenName { get; set; }

        /// <summary>
        /// Specifies whether to enable pass-through.
        /// </summary>
        [NameInMap("TokenPass")]
        [Validation(Required=false)]
        public bool? TokenPass { get; set; }

        /// <summary>
        /// The positions of the parameters that are required to verify each token. By default, each token is prefixed with Bearer and stored in the Authorization header, such as `Authorization: Bearer <Content of a token>`.
        /// </summary>
        [NameInMap("TokenPosition")]
        [Validation(Required=false)]
        public string TokenPosition { get; set; }

        /// <summary>
        /// The prefixes of the parameters that are required to verify each token. By default, each token is prefixed with Bearer and stored in the Authorization header, such as `Authorization: Bearer <Content of a token>`.
        /// </summary>
        [NameInMap("TokenPrefix")]
        [Validation(Required=false)]
        public string TokenPrefix { get; set; }

        /// <summary>
        /// The authentication type. Valid values:
        /// 
        /// *   JWT
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
