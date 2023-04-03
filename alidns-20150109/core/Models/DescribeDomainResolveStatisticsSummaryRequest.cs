// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainResolveStatisticsSummaryRequest : TeaModel {
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public long? Threshold { get; set; }

    }

}
