// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCertificatePrivateKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the encrypted private key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN ENCRYPTED PRIVATE KEY----- …… -----END ENCRYPTED PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("EncryptedData")]
        [Validation(Required=false)]
        public string EncryptedData { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09470F19-CEE8-5C63-BF2C-02B5E3F07A17</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
