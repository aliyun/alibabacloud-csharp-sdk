// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateSecretRequest : TeaModel {
        /// <summary>
        /// <para>The description of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The gateway type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The KMS key configuration. This parameter is required when secretSource is set to KMS. If this parameter is omitted, the API returns InvalidParameter.IsEmpty(400) with the message &quot;Parameter kmsConfig should not be empty.&quot;. This parameter contains two sub-fields: kmsInstanceId (the KMS instance ID) and kmsKeyId (the KMS key ID).</para>
        /// </summary>
        [NameInMap("kmsConfig")]
        [Validation(Required=false)]
        public KMSConfig KmsConfig { get; set; }

        /// <summary>
        /// <para>The name of the secret. The name can contain letters, digits, and underscores (_) and can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_secret</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The KMS secret value. This parameter is required. If this parameter is omitted, the API returns InvalidParameter.IsEmpty(400). Because secretSource only supports KMS, you must always provide this parameter in actual calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apikey-123456xxxxxxxx</para>
        /// </summary>
        [NameInMap("secretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        /// <summary>
        /// <para>The source of the secret. Currently, only KMS is supported. If you specify other values such as MANUAL, the API returns InvalidParameter.WithValue(400). This parameter is required. If this parameter is not provided, the API also returns InvalidParameter.WithValue(400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>KMS</para>
        /// </summary>
        [NameInMap("secretSource")]
        [Validation(Required=false)]
        public string SecretSource { get; set; }

    }

}
