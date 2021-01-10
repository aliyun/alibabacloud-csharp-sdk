// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeLinklogHitspercentageRequest : TeaModel {
        [NameInMap("Begin")]
        [Validation(Required=false)]
        public long? Begin { get; set; }

        [NameInMap("BeginText")]
        [Validation(Required=false)]
        public string BeginText { get; set; }

        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        [NameInMap("EndText")]
        [Validation(Required=false)]
        public string EndText { get; set; }

        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public long? FailCount { get; set; }

        [NameInMap("FailPercent")]
        [Validation(Required=false)]
        public string FailPercent { get; set; }

        [NameInMap("FailPercentText")]
        [Validation(Required=false)]
        public string FailPercentText { get; set; }

        [NameInMap("HitCount")]
        [Validation(Required=false)]
        public long? HitCount { get; set; }

        [NameInMap("HitPercent")]
        [Validation(Required=false)]
        public string HitPercent { get; set; }

        [NameInMap("HitPercentText")]
        [Validation(Required=false)]
        public string HitPercentText { get; set; }

        [NameInMap("KnowledgeHitsPercentageListRepeatList")]
        [Validation(Required=false)]
        public List<string> KnowledgeHitsPercentageListRepeatList { get; set; }

        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public long? StoreId { get; set; }

        [NameInMap("StoreIdsRepeatList")]
        [Validation(Required=false)]
        public List<long?> StoreIdsRepeatList { get; set; }

        [NameInMap("StoreName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
