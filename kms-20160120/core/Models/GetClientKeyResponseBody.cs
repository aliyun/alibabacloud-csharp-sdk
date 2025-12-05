// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetClientKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the application access point (AAP).</para>
        /// 
        /// <b>Example:</b>
        /// <para>aap_test</para>
        /// </summary>
        [NameInMap("AapName")]
        [Validation(Required=false)]
        public string AapName { get; set; }

        /// <summary>
        /// <para>The ID of the client key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KAAP.66abf237-63f6-4625-b8cf-47e1086e****</para>
        /// </summary>
        [NameInMap("ClientKeyId")]
        [Validation(Required=false)]
        public string ClientKeyId { get; set; }

        /// <summary>
        /// <para>The time when the client key was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-31T09:14:38Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The private key algorithm of the client key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("KeyAlgorithm")]
        [Validation(Required=false)]
        public string KeyAlgorithm { get; set; }

        /// <summary>
        /// <para>The provider of the client key.</para>
        /// <para>Currently, only Key Management Service (KMS) is supported. The value is fixed as KMS_PROVIDED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KMS_PROVIDED</para>
        /// </summary>
        [NameInMap("KeyOrigin")]
        [Validation(Required=false)]
        public string KeyOrigin { get; set; }

        /// <summary>
        /// <para>The end of the validity period of the client key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2028-08-31T17:14:33Z</para>
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public string NotAfter { get; set; }

        /// <summary>
        /// <para>The beginning of the validity period of the client key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-31T17:14:33Z</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        /// <summary>
        /// <para>The content of the public key of the client key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----\nMIIDcjCCAlqgAwIBAgIQT/sAVRxwYp54mrw****-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("PublicKeyData")]
        [Validation(Required=false)]
        public string PublicKeyData { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63d849a6-045b-4a57-ad9f-c5f756cea9e9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
