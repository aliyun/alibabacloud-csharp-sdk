// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetFeeHistoryResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("FeeList")]
        [Validation(Required=true)]
        public GetFeeHistoryResponseFeeList FeeList { get; set; }
        public class GetFeeHistoryResponseFeeList : TeaModel {
            [NameInMap("Fee")]
            [Validation(Required=true)]
            public List<GetFeeHistoryResponseFeeListFee> Fee { get; set; }
            public class GetFeeHistoryResponseFeeListFee : TeaModel {
                public string Date { get; set; }
                public string Mode { get; set; }
                public int? TotalBandwidth { get; set; }
                public int? LevelTwoBandwidth { get; set; }
                public int? LevelThreeBandwidth { get; set; }
                public int? TotalTraffic { get; set; }
                public int? LevelTwoTraffic { get; set; }
                public int? LevelThreeTraffic { get; set; }
                public string TimeSpan { get; set; }
                public string BusinessType { get; set; }
                public string StartDate { get; set; }
                public string EndDate { get; set; }
                public string ResourceId { get; set; }
                public int? FlowOut { get; set; }
            }
        };

        [NameInMap("Pager")]
        [Validation(Required=true)]
        public GetFeeHistoryResponsePager Pager { get; set; }
        public class GetFeeHistoryResponsePager : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=true)]
            public int? Page { get; set; }
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
        };

    }

}
