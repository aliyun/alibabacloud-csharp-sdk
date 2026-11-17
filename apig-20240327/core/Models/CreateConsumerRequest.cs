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
        /// <para>The identity configuration for API key authentication.</para>
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
        /// <para>Specifies whether to enable the consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The expiration time of the consumer. The value must be a positive integer that represents a UNIX timestamp in seconds and is later than the current time. If this parameter is left empty, the consumer never expires. The API key, JWT, and HMAC of the same consumer share this expiration time. Milliseconds are not automatically converted to seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1893456000</para>
        /// </summary>
        [NameInMap("expireAt")]
        [Validation(Required=false)]
        public long? ExpireAt { get; set; }

        /// <summary>
        /// <para>The gateway type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>API: the consumer of a cloud-native API gateway.</description></item>
        /// <item><description>AI: the consumer of an AI gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The JWT identity configuration.</para>
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

        /// <summary>
        /// <para>The idempotence identity. You can invoke the API with a globally unique value (a UUID is recommended) that does not exceed 64 characters in length. If you invoke a duplicate request with the same ClientToken and identical request parameters within 24 hours after the first request succeeds, the system directly returns the consumer ID created by the first request without creating a new consumer. If you invoke a request with the same ClientToken but different request parameters, the system returns IdempotentParameterMismatch. If the first request is still being processed, the system returns IdempotentProcessing. If this parameter is left empty, idempotence control is disabled, and the behavior is the same as that of the existing version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5f7a2c1e-9b3d-4e8f-a1c6-0d2b8e4f7a13</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. If you set this parameter to true, the system performs the same parameter, permission, IAM, resource policy, resource existence, and business rule checks as a real creation request, but does not create the consumer, write data to the database, create or delete a SecretRef, or generate audit logs. If this parameter is left empty or set to false, the behavior is the same as that of the previous version.</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
