// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class RemoveExternalSAMLIdPCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/341629.html">ListExternalSAMLIdPCertificates</a> operation to query the IDs of certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp-c-00dt9gnl7fmjaw9c****</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

    }

}
