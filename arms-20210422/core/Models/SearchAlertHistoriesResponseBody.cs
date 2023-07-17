// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
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
                [NameInMap("AlarmContent")]
                [Validation(Required=false)]
                public string AlarmContent { get; set; }

                [NameInMap("AlarmResponseCode")]
                [Validation(Required=false)]
                public int? AlarmResponseCode { get; set; }

                [NameInMap("AlarmSources")]
                [Validation(Required=false)]
                public string AlarmSources { get; set; }

                [NameInMap("AlarmTime")]
                [Validation(Required=false)]
                public long? AlarmTime { get; set; }

                [NameInMap("AlarmType")]
                [Validation(Required=false)]
                public int? AlarmType { get; set; }

                [NameInMap("Emails")]
                [Validation(Required=false)]
                public string Emails { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Phones")]
                [Validation(Required=false)]
                public string Phones { get; set; }

                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
