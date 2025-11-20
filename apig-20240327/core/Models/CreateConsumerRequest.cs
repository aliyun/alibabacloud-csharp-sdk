// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateConsumerRequest : TeaModel {
        /// <summary>
        /// <para>The list of AK/SK identity configurations.</para>
        /// </summary>
        [NameInMap("akSkIdentityConfigs")]
        [Validation(Required=false)]
        public List<AkSkIdentityConfig> AkSkIdentityConfigs { get; set; }

        /// <summary>
        /// <para>The configuration for the API key authentication method.</para>
        /// </summary>
        [NameInMap("apikeyIdentityConfig")]
        [Validation(Required=false)]
        public ApiKeyIdentityConfig ApikeyIdentityConfig { get; set; }

        /// <summary>
        /// <para>The description of the consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consumer for test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates if enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The type of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The configuration of the JWT identity.</para>
        /// </summary>
        [NameInMap("jwtIdentityConfig")]
        [Validation(Required=false)]
        public JwtIdentityConfig JwtIdentityConfig { get; set; }

        /// <summary>
        /// <para>The name of the consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
