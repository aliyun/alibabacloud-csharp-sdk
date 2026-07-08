// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DeleteUserCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The certificate ID.</para>
        /// <remarks>
        /// <para>To obtain the certificate ID, call the <a href="https://help.aliyun.com/document_detail/455804.html">ListUserCertificateOrder</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7562353</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public long? CertId { get; set; }

    }

}
