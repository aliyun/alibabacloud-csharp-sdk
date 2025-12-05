// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateClientKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KAAP.66abf237-63f6-4625-b8cf-47e1086e****</para>
        /// </summary>
        [NameInMap("ClientKeyId")]
        [Validation(Required=false)]
        public string ClientKeyId { get; set; }

        /// <summary>
        /// <para>The ID of the client key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("KeyAlgorithm")]
        [Validation(Required=false)]
        public string KeyAlgorithm { get; set; }

        /// <summary>
        /// <para>The beginning of the validity period of the client key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2028-08-31T17:14:33Z</para>
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public string NotAfter { get; set; }

        /// <summary>
        /// <para>The private key of the client key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-31T17:14:33Z</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        /// <summary>
        /// <para>The algorithm that is used to encrypt the private key of the client key. Currently, only RSA_2048 is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MIIJqwIBAzCCCXcGCSqGSIb3DQEHAaCCCWgEgglkMIIJYDCCBBcGCSqGSIb3DQEHBqCCBAgwgg******</para>
        /// </summary>
        [NameInMap("PrivateKeyData")]
        [Validation(Required=false)]
        public string PrivateKeyData { get; set; }

        /// <summary>
        /// <para>The beginning of the validity period of the client key.</para>
        /// <para>Specify the time in the ISO 8601 standard. The time must be in UTC. The time must be in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you do not configure NotBefore, the default value is the time when the client key was created.</description></item>
        /// <item><description>If you configure NotBefore, you must configure NotAfter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2312e45f-b2fa-4c34-ad94-3eca50932916</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
