// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateKeyPairResponseBody : TeaModel {
        /// <summary>
        /// <para>The fingerprint of the key pair. The message-digest algorithm 5 (MD5) is used based on the public key fingerprint format defined in RFC 4716. For more information, see <a href="https://tools.ietf.org/html/rfc4716">RFC 4716</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7880c1ad4687fdbf7a6da2131****</para>
        /// </summary>
        [NameInMap("KeyPairFingerPrint")]
        [Validation(Required=false)]
        public string KeyPairFingerPrint { get; set; }

        /// <summary>
        /// <para>The ID of the SSH key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ssh-5lywanlkih1zo9yl8eg****</para>
        /// </summary>
        [NameInMap("KeyPairId")]
        [Validation(Required=false)]
        public string KeyPairId { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The private key of the key pair. The private key is encoded with PEM in the PKCS#8 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN RSA PRIVATE KEY-----\nMIIEogIBAAKCAQE****</para>
        /// </summary>
        [NameInMap("PrivateKeyBody")]
        [Validation(Required=false)]
        public string PrivateKeyBody { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
