// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CertConfig : TeaModel {
        /// <summary>
        /// <para>The certificate name, which is used to identify the certificate in the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-example-com</para>
        /// </summary>
        [NameInMap("certName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The certificate public key content in PEM format, including the complete certificate chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIIDdzCCAl+gAwIBAgIEbGVzc29u
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <para>The certificate private key content in PEM format. The private key is encrypted and stored on the server side, and is not returned in plaintext when queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN RSA PRIVATE KEY-----</para>
        /// <hr>
        /// <para>-----END RSA PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("privateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

    }

}
