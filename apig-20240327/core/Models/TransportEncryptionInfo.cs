// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class TransportEncryptionInfo : TeaModel {
        /// <summary>
        /// <para>The list of transport certificates added by the user.</para>
        /// </summary>
        [NameInMap("certificates")]
        [Validation(Required=false)]
        public List<TransportCertificateInfo> Certificates { get; set; }

        /// <summary>
        /// <para>The reason for the deployment failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("deployError")]
        [Validation(Required=false)]
        public string DeployError { get; set; }

        /// <summary>
        /// <para>The submit status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("deployStatus")]
        [Validation(Required=false)]
        public string DeployStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether HTTP/2 is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("http2Enabled")]
        [Validation(Required=false)]
        public bool? Http2Enabled { get; set; }

        /// <summary>
        /// <para>The TLS cipher suite policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_2</para>
        /// </summary>
        [NameInMap("tlsPolicy")]
        [Validation(Required=false)]
        public string TlsPolicy { get; set; }

    }

}
