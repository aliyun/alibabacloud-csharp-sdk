// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotAlarmEventsResponseBody : TeaModel {
        [NameInMap("HoneypotAlarmEvents")]
        [Validation(Required=false)]
        public List<ListHoneypotAlarmEventsResponseBodyHoneypotAlarmEvents> HoneypotAlarmEvents { get; set; }
        public class ListHoneypotAlarmEventsResponseBodyHoneypotAlarmEvents : TeaModel {
            [NameInMap("AlarmEventId")]
            [Validation(Required=false)]
            public long? AlarmEventId { get; set; }

            [NameInMap("AlarmEventName")]
            [Validation(Required=false)]
            public string AlarmEventName { get; set; }

            [NameInMap("AlarmEventType")]
            [Validation(Required=false)]
            public string AlarmEventType { get; set; }

            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            [NameInMap("MergeFieldList")]
            [Validation(Required=false)]
            public List<ListHoneypotAlarmEventsResponseBodyHoneypotAlarmEventsMergeFieldList> MergeFieldList { get; set; }
            public class ListHoneypotAlarmEventsResponseBodyHoneypotAlarmEventsMergeFieldList : TeaModel {
                [NameInMap("FieldExtInfo")]
                [Validation(Required=false)]
                public string FieldExtInfo { get; set; }

                [NameInMap("FieldKey")]
                [Validation(Required=false)]
                public string FieldKey { get; set; }

                [NameInMap("FieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("FieldValue")]
                [Validation(Required=false)]
                public string FieldValue { get; set; }

            }

            [NameInMap("OperateStatus")]
            [Validation(Required=false)]
            public int? OperateStatus { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotAlarmEventsResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotAlarmEventsResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("LastRowKey")]
            [Validation(Required=false)]
            public string LastRowKey { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

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
