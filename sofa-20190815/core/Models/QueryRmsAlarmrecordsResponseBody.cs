// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAlarmrecordsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsAlarmrecordsResponseBodyResponse Response { get; set; }
        public class QueryRmsAlarmrecordsResponseBodyResponse : TeaModel {
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<QueryRmsAlarmrecordsResponseBodyResponseEntities> Entities { get; set; }
            public class QueryRmsAlarmrecordsResponseBodyResponseEntities : TeaModel {
                [NameInMap("AlarmTime")]
                [Validation(Required=false)]
                public string AlarmTime { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("MonitorItemType")]
                [Validation(Required=false)]
                public string MonitorItemType { get; set; }

                [NameInMap("MonitorPort")]
                [Validation(Required=false)]
                public long? MonitorPort { get; set; }

                [NameInMap("MonitorTargetType")]
                [Validation(Required=false)]
                public string MonitorTargetType { get; set; }

                [NameInMap("NotificationState")]
                [Validation(Required=false)]
                public string NotificationState { get; set; }

                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                [NameInMap("TriggerState")]
                [Validation(Required=false)]
                public string TriggerState { get; set; }

                [NameInMap("TriggerValue")]
                [Validation(Required=false)]
                public long? TriggerValue { get; set; }

                [NameInMap("NotificationResultVos")]
                [Validation(Required=false)]
                public List<QueryRmsAlarmrecordsResponseBodyResponseEntitiesNotificationResultVos> NotificationResultVos { get; set; }
                public class QueryRmsAlarmrecordsResponseBodyResponseEntitiesNotificationResultVos : TeaModel {
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("RequestId")]
                    [Validation(Required=false)]
                    public string RequestId { get; set; }

                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                    [NameInMap("TargetLoginName")]
                    [Validation(Required=false)]
                    public string TargetLoginName { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public QueryRmsAlarmrecordsResponseBodyResponseMeta Meta { get; set; }
            public class QueryRmsAlarmrecordsResponseBodyResponseMeta : TeaModel {
                [NameInMap("Page")]
                [Validation(Required=false)]
                public QueryRmsAlarmrecordsResponseBodyResponseMetaPage Page { get; set; }
                public class QueryRmsAlarmrecordsResponseBodyResponseMetaPage : TeaModel {
                    [NameInMap("Limit")]
                    [Validation(Required=false)]
                    public long? Limit { get; set; }
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public long? Offset { get; set; }
                    [NameInMap("TotalSize")]
                    [Validation(Required=false)]
                    public long? TotalSize { get; set; }
                };

            }
        };

    }

}
