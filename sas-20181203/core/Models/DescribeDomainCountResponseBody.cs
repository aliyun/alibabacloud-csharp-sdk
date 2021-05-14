// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainCountResponseBody : TeaModel {
        [NameInMap("RootDomainsCount")]
        [Validation(Required=false)]
        public int? RootDomainsCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubDomainsCount")]
        [Validation(Required=false)]
        public int? SubDomainsCount { get; set; }

        [NameInMap("TotalDomainsCount")]
        [Validation(Required=false)]
        public int? TotalDomainsCount { get; set; }

    }

}
