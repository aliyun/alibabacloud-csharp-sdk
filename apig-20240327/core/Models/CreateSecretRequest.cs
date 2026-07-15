// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateSecretRequest : TeaModel {
        /// <summary>
        /// <para>The description of the key.</para>
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
        /// <para>The KMS key configuration.</para>
        /// </summary>
        [NameInMap("kmsConfig")]
        [Validation(Required=false)]
        public KMSConfig KmsConfig { get; set; }

        /// <summary>
        /// <para>The key name. The name can contain letters, digits, and underscores (_) and can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_secret</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The KMS credential value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apikey-123456xxxxxxxx</para>
        /// </summary>
        [NameInMap("secretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        /// <summary>
        /// <para>The source of the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KMS</para>
        /// </summary>
        [NameInMap("secretSource")]
        [Validation(Required=false)]
        public string SecretSource { get; set; }

    }

}
