// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertHistoriesResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchAlertHistoriesResponseBodyPageBean PageBean { get; set; }
        public class SearchAlertHistoriesResponseBodyPageBean : TeaModel {
            [NameInMap("AlarmHistories")]
            [Validation(Required=false)]
            public List<SearchAlertHistoriesResponseBodyPageBeanAlarmHistories> AlarmHistories { get; set; }
            public class SearchAlertHistoriesResponseBodyPageBeanAlarmHistories : TeaModel {
                public long? AlarmTime { get; set; }
                public string StrategyId { get; set; }
                public int? AlarmResponseCode { get; set; }
                public string Emails { get; set; }
                public string UserId { get; set; }
                public string AlarmSources { get; set; }
                public string AlarmContent { get; set; }
                public string Phones { get; set; }
                public int? AlarmType { get; set; }
                public string Target { get; set; }
                public long? Id { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
