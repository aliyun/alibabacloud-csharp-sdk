// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnCertificateDetailByIdRequest : TeaModel {
        /// <summary>
        /// The ID of the certificate.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// The region of the certificate. Valid values:
        /// 
        /// *   **ap-southeast-1**: Singapore
        /// *   **cn-hangzhou**: China (Hangzhou)
        /// 
        /// Default value: **cn-hangzhou**
        /// </summary>
        [NameInMap("CertRegion")]
        [Validation(Required=false)]
        public string CertRegion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
