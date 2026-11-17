// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateConsumerRequest : TeaModel {
        /// <summary>
        /// <para>The list of AK/SK identity authentication configurations.</para>
        /// </summary>
        [NameInMap("akSkIdentityConfigs")]
        [Validation(Required=false)]
        public List<AkSkIdentityConfig> AkSkIdentityConfigs { get; set; }

        /// <summary>
        /// <para>The API key identity authentication configuration.</para>
        /// </summary>
        [NameInMap("apikeyIdentityConfig")]
        [Validation(Required=false)]
        public ApiKeyIdentityConfig ApikeyIdentityConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to clear the expiration time and restore permanent validity. If this parameter is set to true, expireAt cannot be specified at the same time. The default value is false, which indicates that the expiration time is not cleared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("clearExpireAt")]
        [Validation(Required=false)]
        public bool? ClearExpireAt { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test consumer</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the consumer after renewal. This parameter can be set to true only when renew=true. The default value is false, which retains the current enabled or disabled state and does not implicitly enable a manually disabled consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableAfterRenewal")]
        [Validation(Required=false)]
        public bool? EnableAfterRenewal { get; set; }

        /// <summary>
        /// <para>The expiration time of the consumer, in UTC UNIX seconds. It must be a positive integer and later than the current time. If this parameter is not specified, the original value is retained. This parameter cannot be set at the same time as clearExpireAt=true. If renew=true, the value must be later than the original unexpired expiration time. If the configuration is saved but fails to be delivered, a retry with the original expiration time is allowed, but shortening the expiration time is still prohibited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1893456000</para>
        /// </summary>
        [NameInMap("expireAt")]
        [Validation(Required=false)]
        public long? ExpireAt { get; set; }

        /// <summary>
        /// <para>The JWT identity authentication configuration.</para>
        /// </summary>
        [NameInMap("jwtIdentityConfig")]
        [Validation(Required=false)]
        public JwtIdentityConfig JwtIdentityConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to only renew the consumer. If this parameter is set to true, only the validity period is updated and the consumer is explicitly enabled at the same time. The latest credentials, description, and authorizations on the server are retained. You must set expireAt or clearExpireAt=true, and you cannot specify identity configurations or description. The default value is false, which retains the original consumer update semantics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("renew")]
        [Validation(Required=false)]
        public bool? Renew { get; set; }

    }

}
