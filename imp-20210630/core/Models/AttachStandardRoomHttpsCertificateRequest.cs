// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class AttachStandardRoomHttpsCertificateRequest : TeaModel {
        /// <summary>
        /// 应用唯一标识
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// NGINX格式证书私钥
        /// </summary>
        [NameInMap("CertificatePrivateKey")]
        [Validation(Required=false)]
        public string CertificatePrivateKey { get; set; }

        /// <summary>
        /// NGINX格式证书公钥
        /// </summary>
        [NameInMap("CertificatePublicKey")]
        [Validation(Required=false)]
        public string CertificatePublicKey { get; set; }

        /// <summary>
        /// 使用证书的确切域名
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

    }

}
