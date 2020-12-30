// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeCcResSummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FullNodesSummary")]
        [Validation(Required=false)]
        public DescribeCcResSummaryResponseBodyFullNodesSummary FullNodesSummary { get; set; }
        public class DescribeCcResSummaryResponseBodyFullNodesSummary : TeaModel {
            [NameInMap("UnUsedQps")]
            [Validation(Required=false)]
            public int? UnUsedQps { get; set; }
            [NameInMap("UsedQps")]
            [Validation(Required=false)]
            public int? UsedQps { get; set; }
            [NameInMap("TotalQps")]
            [Validation(Required=false)]
            public int? TotalQps { get; set; }
            [NameInMap("NGResInfoList")]
            [Validation(Required=false)]
            public List<DescribeCcResSummaryResponseBodyFullNodesSummaryNGResInfoList> NGResInfoList { get; set; }
            public class DescribeCcResSummaryResponseBodyFullNodesSummaryNGResInfoList : TeaModel {
                public string AppName { get; set; }
                public string AppId { get; set; }
                public int? UsedQps { get; set; }
                public string BizName { get; set; }
                public string BizId { get; set; }
            }
        };

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
