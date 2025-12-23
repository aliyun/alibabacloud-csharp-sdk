// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class VerifyRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the certificate. You can call the <a href="https://help.aliyun.com/document_detail/455806.html">ListCert</a> operation to obtain the unique identifier of a certificate.</para>
        /// <list type="bullet">
        /// <item><description>If the certificate is an SSL certificate, the value of this parameter must be in the {Certificate ID}-cn-hangzhou format.</description></item>
        /// <item><description>If the certificate is a private certificate, the value of this parameter must be the value of the Identifier field for the private certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5870821-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The data for which you want to verify the signature. The value must be encoded in Base64.\
        /// For example, if the hexadecimal data that you want to verify is [0x31, 0x32, 0x33, 0x34], set the parameter to the Base64-encoded value MTIzNA==. If you set MessageType to RAW, the size of the data must be less than 4 KB. If the size of the data is greater than 4 KB, you can set MessageType to DIGEST and set Message to the digest of the data. The digest is also called hash value. You can compute the digest of the data on an on-premises machine. The certificate repository uses your certificate application system to compute the message digest. The message digest algorithm that is used must meet the requirements of the specified signature algorithm. The following signature algorithms require different message digest algorithms:</para>
        /// <list type="bullet">
        /// <item><description>If the signature algorithm is SHA256withRSA, SHA256withRSA/PSS, or SHA256withECDSA, the message digest algorithm must be SHA-256.</description></item>
        /// <item><description>If the signature algorithm is SM3withSM2, the message digest algorithm must be SM3.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNA==</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The value type of the Message parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RAW</b>: the raw data. This is the default value.</description></item>
        /// <item><description><b>DIGEST</b>: the message digest of the raw data.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAW</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// <para>The signature value. The value must be encoded in Base64.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyaC0w3ROK5b3QcHmUtAhMY/sQjKu2t3uBfnf6J/gn7JfZtyxwcCUjzXbw5jmqJQRbj1te670Bshg9kUdanKhtHFhJjU5jX+ZMMBr6pH0gqQDJxR0K0yHXRc0Q5OQoUZ6BfpbI4Wt4jJvJSdCstz1vSg12CfEHS8Kd5qfhItK7Y=</para>
        /// </summary>
        [NameInMap("SignatureValue")]
        [Validation(Required=false)]
        public string SignatureValue { get; set; }

        /// <summary>
        /// <para>The signature algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SHA256withRSA</b></description></item>
        /// <item><description><b>SHA256withRSA/PSS</b></description></item>
        /// <item><description><b>SHA256withECDSA</b></description></item>
        /// <item><description><b>SM3withSM2</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHA256withRSA</para>
        /// </summary>
        [NameInMap("SigningAlgorithm")]
        [Validation(Required=false)]
        public string SigningAlgorithm { get; set; }

    }

}
