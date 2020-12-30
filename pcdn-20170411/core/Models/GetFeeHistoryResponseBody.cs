// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetFeeHistoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FeeList")]
        [Validation(Required=false)]
        public GetFeeHistoryResponseBodyFeeList FeeList { get; set; }
        public class GetFeeHistoryResponseBodyFeeList : TeaModel {
            [NameInMap("Fee")]
            [Validation(Required=false)]
            public List<GetFeeHistoryResponseBodyFeeListFee> Fee { get; set; }
            public class GetFeeHistoryResponseBodyFeeListFee : TeaModel {
                public string EndDate { get; set; }
                public string TimeSpan { get; set; }
                public string Date { get; set; }
                public string StartDate { get; set; }
                public int? LevelThreeTraffic { get; set; }
                public string Mode { get; set; }
                public int? TotalTraffic { get; set; }
                public string BusinessType { get; set; }
                public int? LevelTwoTraffic { get; set; }
                public int? LevelThreeBandwidth { get; set; }
                public int? LevelTwoBandwidth { get; set; }
                public int? FlowOut { get; set; }
                public string ResourceId { get; set; }
                public int? TotalBandwidth { get; set; }
            }
        };

        [NameInMap("Pager")]
        [Validation(Required=false)]
        public GetFeeHistoryResponseBodyPager Pager { get; set; }
        public class GetFeeHistoryResponseBodyPager : TeaModel {
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
