// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ChangeDomainOfDnsProductResponseBody : TeaModel {
        /// <summary>
        /// The original domain name that was bound to the instance. If the value of this parameter is empty, the instance is bound with a domain name for the first time.
        /// </summary>
        [NameInMap("OriginalDomain")]
        [Validation(Required=false)]
        public string OriginalDomain { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
