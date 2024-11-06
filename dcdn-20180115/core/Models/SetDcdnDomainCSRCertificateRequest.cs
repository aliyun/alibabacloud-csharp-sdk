// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnDomainCSRCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The domain name that is secured by the certificate. The domain name uses HTTPS acceleration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The content of the certificate. The certificate must match the certificate signing request (CSR) created by calling the <a href="https://help.aliyun.com/document_detail/144478.html">CreateDcdnCertificateSigningRequest</a> operation. Make sure that the certificate is in PEM format and its content is Base64-encoded and then encoded by encodeURIComponent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ServerCertificate")]
        [Validation(Required=false)]
        public string ServerCertificate { get; set; }

    }

}
