// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class QueryTrafficControlTargetItemReportDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficControlTargetItemReportDetail")]
        [Validation(Required=false)]
        public QueryTrafficControlTargetItemReportDetailResponseBodyTrafficControlTargetItemReportDetail TrafficControlTargetItemReportDetail { get; set; }
        public class QueryTrafficControlTargetItemReportDetailResponseBodyTrafficControlTargetItemReportDetail : TeaModel {
            [NameInMap("ItemControlTailReportDetails")]
            [Validation(Required=false)]
            public List<QueryTrafficControlTargetItemReportDetailResponseBodyTrafficControlTargetItemReportDetailItemControlTailReportDetails> ItemControlTailReportDetails { get; set; }
            public class QueryTrafficControlTargetItemReportDetailResponseBodyTrafficControlTargetItemReportDetailItemControlTailReportDetails : TeaModel {
                [NameInMap("Features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("TargetProgress")]
                [Validation(Required=false)]
                public string TargetProgress { get; set; }

                [NameInMap("TargetTraffic")]
                [Validation(Required=false)]
                public long? TargetTraffic { get; set; }

            }

            [NameInMap("ItemControlTopReportDetails")]
            [Validation(Required=false)]
            public List<QueryTrafficControlTargetItemReportDetailResponseBodyTrafficControlTargetItemReportDetailItemControlTopReportDetails> ItemControlTopReportDetails { get; set; }
            public class QueryTrafficControlTargetItemReportDetailResponseBodyTrafficControlTargetItemReportDetailItemControlTopReportDetails : TeaModel {
                [NameInMap("Features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("TargetProgress")]
                [Validation(Required=false)]
                public string TargetProgress { get; set; }

                [NameInMap("TargetTraffic")]
                [Validation(Required=false)]
                public long? TargetTraffic { get; set; }

            }

        }

    }

}
