// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetUserCertificateDetailRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter the certificate content from the response. Valid values: <b>true</b>: The Cert, Key, EncryptCert, EncryptPrivateKey, SignCert, and SignPrivateKey parameters are not returned. <b>false</b> (default): All parameters are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CertFilter")]
        [Validation(Required=false)]
        public bool? CertFilter { get; set; }

        /// <summary>
        /// <para>The ID of the certificate. To get this ID, call the <a href="https://help.aliyun.com/document_detail/455804.html">ListUserCertificateOrder</a> operation.</para>
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
