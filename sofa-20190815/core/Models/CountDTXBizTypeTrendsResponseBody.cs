// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CountDTXBizTypeTrendsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CountDTXBizTypeTrendsResponseBodyData Data { get; set; }
        public class CountDTXBizTypeTrendsResponseBodyData : TeaModel {
            [NameInMap("ExceptionTrend")]
            [Validation(Required=false)]
            public List<CountDTXBizTypeTrendsResponseBodyDataExceptionTrend> ExceptionTrend { get; set; }
            public class CountDTXBizTypeTrendsResponseBodyDataExceptionTrend : TeaModel {
                public long? Time { get; set; }
                public long? Total { get; set; }
            }
            [NameInMap("ActivityTrend")]
            [Validation(Required=false)]
            public List<CountDTXBizTypeTrendsResponseBodyDataActivityTrend> ActivityTrend { get; set; }
            public class CountDTXBizTypeTrendsResponseBodyDataActivityTrend : TeaModel {
                public long? Rollback { get; set; }
                public long? Time { get; set; }
                public long? Success { get; set; }
                public long? Total { get; set; }
            }
            [NameInMap("ActionTrend")]
            [Validation(Required=false)]
            public List<CountDTXBizTypeTrendsResponseBodyDataActionTrend> ActionTrend { get; set; }
            public class CountDTXBizTypeTrendsResponseBodyDataActionTrend : TeaModel {
                public long? Rollback { get; set; }
                public long? Time { get; set; }
                public long? Success { get; set; }
                public long? Total { get; set; }
            }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
