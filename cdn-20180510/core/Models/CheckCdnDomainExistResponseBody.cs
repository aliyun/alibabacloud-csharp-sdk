// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class CheckCdnDomainExistResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the domain name. Valid values:
        /// 
        /// *   **DomainNotExist**: The domain name is not added.
        /// *   **DomainExistOtherUser**: The domain name has been added by another account.
        /// *   **DomainExistCdnProduct**: The domain name has been added to Alibaba Cloud CDN.
        /// *   **DomainExistDcdnProduct**: The domain name has been added to Dynamic Content Delivery Network (DCDN).
        /// *   **DomainExistScdnProduct**: The domain name has been added to Secure CDN (SCDN).
        /// *   **DomainExistVodProduct**: The domain name has been added to ApsaraVideo VOD.
        /// *   **DomainExistLiveProduct**: The domain name has been added to ApsaraVideo Live.
        /// *   **DomainExistDcdnipaProduct**: The domain name has been added to DCDN IP Application Accelerator (IPA).
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
