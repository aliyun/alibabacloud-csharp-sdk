// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetUserCertificateDetailRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter certificate content. If set to <b>true</b>, the Cert, Key, EncryptCert, EncryptPrivateKey, SignCert, and SignPrivateKey fields are not returned. If set to <b>false</b>, these fields are returned. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CertFilter")]
        [Validation(Required=false)]
        public bool? CertFilter { get; set; }

        /// <summary>
        /// <para>The certificate ID.</para>
        /// <remarks>
        /// <para>You can obtain this ID by calling <a href="https://help.aliyun.com/document_detail/455804.html">ListUserCertificateOrder</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6055048</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public long? CertId { get; set; }

    }

}
