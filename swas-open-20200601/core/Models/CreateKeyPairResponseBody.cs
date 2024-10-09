// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateKeyPairResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the key pair. The name must be 2 to 64 characters in length and can contain letters, digits, colons (.), underscores (_), and hyphens (-). It must start with a letter but cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The private key of the key pair. The PEM-encoded private key is in PKCS#8 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MIIEpAIBAAKCAQEAtReyMzLIcBH78EV2zj****</para>
        /// </summary>
        [NameInMap("PrivateKeyBody")]
        [Validation(Required=false)]
        public string PrivateKeyBody { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
