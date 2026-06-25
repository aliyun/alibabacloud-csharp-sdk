// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetConsumerResponseBody : TeaModel {
        /// <summary>
        /// <para>O código de resposta.</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Os dados de resposta.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetConsumerResponseBodyData Data { get; set; }
        public class GetConsumerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>As configurações de autenticação por par de AccessKey.</para>
            /// </summary>
            [NameInMap("akSkIdentityConfigs")]
            [Validation(Required=false)]
            public List<AkSkIdentityConfig> AkSkIdentityConfigs { get; set; }

            /// <summary>
            /// <para>A configuração de autenticação de chave de API.</para>
            /// </summary>
            [NameInMap("apiKeyIdentityConfig")]
            [Validation(Required=false)]
            public ApiKeyIdentityConfig ApiKeyIdentityConfig { get; set; }

            /// <summary>
            /// <para>O ID do consumidor de API.</para>
            /// </summary>
            [NameInMap("consumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            /// <summary>
            /// <para>O carimbo de data/hora de criação.</para>
            /// </summary>
            [NameInMap("createTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>O status de publicação da API no ambiente atual.</para>
            /// </summary>
            [NameInMap("deployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            /// <summary>
            /// <para>A descrição.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indica se o consumidor de API está habilitado.</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>A configuração de autenticação JWT.</para>
            /// </summary>
            [NameInMap("jwtIdentityConfig")]
            [Validation(Required=false)]
            public JwtIdentityConfig JwtIdentityConfig { get; set; }

            /// <summary>
            /// <para>O nome do consumidor de API.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>O carimbo de data/hora de atualização.</para>
            /// </summary>
            [NameInMap("updateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

        }

        /// <summary>
        /// <para>A mensagem de resposta.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>O ID da solicitação.</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
