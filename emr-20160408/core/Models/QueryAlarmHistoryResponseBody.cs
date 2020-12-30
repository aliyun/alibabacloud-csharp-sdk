// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class QueryAlarmHistoryResponseBody : TeaModel {
        [NameInMap("AlarmHistoryList")]
        [Validation(Required=false)]
        public QueryAlarmHistoryResponseBodyAlarmHistoryList AlarmHistoryList { get; set; }
        public class QueryAlarmHistoryResponseBodyAlarmHistoryList : TeaModel {
            [NameInMap("EmrAlarmHistory")]
            [Validation(Required=false)]
            public List<QueryAlarmHistoryResponseBodyAlarmHistoryListEmrAlarmHistory> EmrAlarmHistory { get; set; }
            public class QueryAlarmHistoryResponseBodyAlarmHistoryListEmrAlarmHistory : TeaModel {
                public int? Status { get; set; }
                public long? LastTime { get; set; }
                public string MetricName { get; set; }
                public long? AlarmTime { get; set; }
                public string State { get; set; }
                public string ContactGroups { get; set; }
                public string InstanceId { get; set; }
                public string Name { get; set; }
                public string Role { get; set; }
                public string ClusterId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

        [NameInMap("Cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

    }

}
