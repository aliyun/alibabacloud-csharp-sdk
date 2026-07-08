// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class UpdateCsrRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the CSR. This ID is generated when you upload a CSR. To obtain the ID, call the <a href="https://help.aliyun.com/document_detail/2709717.html">ListCsr</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5209</para>
        /// </summary>
        [NameInMap("CsrId")]
        [Validation(Required=false)]
        public long? CsrId { get; set; }

        /// <summary>
        /// <para>The content of the certificate private key in PEM format.</para>
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
