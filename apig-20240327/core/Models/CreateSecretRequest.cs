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
        /// <para>The type of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The key configuration information of KMS.</para>
        /// </summary>
        [NameInMap("kmsConfig")]
        [Validation(Required=false)]
        public KMSConfig KmsConfig { get; set; }

        /// <summary>
        /// <para>The key name. It can be up to 64 characters in length and can contain letters, digits, and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_secret</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The value of the KMS credential.</para>
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
