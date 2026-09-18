// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class UpdateCsrRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the CSR. The CsrId is generated when you upload the CSR. You can obtain this value by querying the CSR list. For more information, see <a href="https://help.aliyun.com/document_detail/2709717.html">ListCsr</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5209</para>
        /// </summary>
        [NameInMap("CsrId")]
        [Validation(Required=false)]
        public long? CsrId { get; set; }

        /// <summary>
        /// <para>The certificate private key content in PEM format. This private key must match the public key cryptography contained in the CSR referenced by CsrId. Otherwise, the API returns the NotMatch.CsrAndPrivateKey error.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN RSA PRIVATE KEY----- MII.... -----END RSA PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

    }

}
