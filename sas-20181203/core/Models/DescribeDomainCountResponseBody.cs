// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainCountResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of root domains.
        /// </summary>
        [NameInMap("RootDomainsCount")]
        [Validation(Required=false)]
        public int? RootDomainsCount { get; set; }

        /// <summary>
        /// The number of subdomains.
        /// </summary>
        [NameInMap("SubDomainsCount")]
        [Validation(Required=false)]
        public int? SubDomainsCount { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalDomainsCount")]
        [Validation(Required=false)]
        public int? TotalDomainsCount { get; set; }

    }

}
