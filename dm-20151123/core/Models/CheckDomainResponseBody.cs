// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class CheckDomainResponseBody : TeaModel {
        /// <summary>
        /// The status of the domain name. Indicates whether the domain name is verified and available.
        /// 
        /// *   0: indicates that the domain name is verified and available.
        /// *   1: indicates that the domain name fails to be verified and is unavailable.
        /// *   2: indicates that the domain name is available, but not filed or configured with a CNAME record.
        /// *   3: indicates that the domain name is available but not filed.
        /// *   4: indicates that the domain name is available but not configured with a CNAME record.
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public int? DomainStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
