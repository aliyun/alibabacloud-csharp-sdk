// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ShareCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The certificate ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23279004</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public long? CertificateId { get; set; }

        /// <summary>
        /// <para>The UID of the user with whom the certificate is shared.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1622883344556677</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public long? TargetUserId { get; set; }

    }

}
