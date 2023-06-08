// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnHttpsDomainListRequest : TeaModel {
        /// <summary>
        /// The status of the certificate. Valid values:
        /// 
        /// *   **ok**: The certificate is working as expected.
        /// *   **mismatch**: The certificate does not match the specified domain name.
        /// *   **expired**: The certificate has expired.
        /// *   **expire_soon**: The certificate is about to expire.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The type of the certificate. Valid values:
        /// 
        /// *   **free**: A free certificate.
        /// *   **cas**: A certificate that is purchased through Alibaba Cloud SSL Certificates Service.
        /// *   **upload**: A user-uploaded certificate.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
