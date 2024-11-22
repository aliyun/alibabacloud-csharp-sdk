// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DecryptRequest : TeaModel {
        /// <summary>
        /// <para>The encryption algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RSAES_OAEP_SHA_1</b></description></item>
        /// <item><description><b>RSAES_OAEP_SHA_256</b></description></item>
        /// <item><description><b>SM2PKE</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSAESOAEPSHA_1</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The unique identifier of the certificate. You can call the <a href="https://help.aliyun.com/document_detail/455806.html">ListCert</a> operation to query the identifier.</para>
        /// <list type="bullet">
        /// <item><description>If the certificate is an SSL certificate, the value of this parameter must be in the {Certificate ID}-cn-hangzhou format.</description></item>
        /// <item><description>If the certificate is a private certificate, the value of this parameter must be the value of the Identifier field for the private certificate.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-12345678****</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The data that you want to decrypt. The value is encoded in Base64.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZOyIygCyaOW6Gj****MlNKiuyjfzw=</para>
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// <para>The value type of the Message parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RAW: The returned result is raw data encoded in UTF-8.</description></item>
        /// <item><description>Base64: The returned result is Base64-encoded data. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

    }

}
