// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class DissociateAdditionalCertificatesFromListenerRequest : TeaModel {
        /// <summary>
        /// 证书列表
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<DissociateAdditionalCertificatesFromListenerRequestCertificates> Certificates { get; set; }
        public class DissociateAdditionalCertificatesFromListenerRequestCertificates : TeaModel {
            /// <summary>
            /// 证书Id
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// 幂等Token
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// dryRun
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 监听Id
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

    }

}
