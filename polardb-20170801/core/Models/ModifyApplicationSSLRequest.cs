// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyApplicationSSLRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-xxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The server certificate chain in PEM format. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIICa
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("CaPem")]
        [Validation(Required=false)]
        public string CaPem { get; set; }

        /// <summary>
        /// <para>The server certificate in PEM format. This parameter is provided when you use a bring-your-own (BYO) certificate. It must match KeyPem and override the instance connection domain name. This parameter is allowed only when CA SSL is enabled for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIICert
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("CertPem")]
        [Validation(Required=false)]
        public string CertPem { get; set; }

        /// <summary>
        /// <para>The server private key in PEM format. PKCS#1, PKCS#8, and EC SEC1 formats are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----
        /// MIIKey
        /// -----END PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("KeyPem")]
        [Validation(Required=false)]
        public string KeyPem { get; set; }

        /// <summary>
        /// <para>Specifies whether SSL is enabled.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SslEnabled")]
        [Validation(Required=false)]
        public bool? SslEnabled { get; set; }

    }

}
