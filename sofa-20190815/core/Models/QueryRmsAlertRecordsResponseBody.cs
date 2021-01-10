// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAlertRecordsResponseBody : TeaModel {
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
        public QueryRmsAlertRecordsResponseBodyResponse Response { get; set; }
        public class QueryRmsAlertRecordsResponseBodyResponse : TeaModel {
            [NameInMap("Entity")]
            [Validation(Required=false)]
            public QueryRmsAlertRecordsResponseBodyResponseEntity Entity { get; set; }
            public class QueryRmsAlertRecordsResponseBodyResponseEntity : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<QueryRmsAlertRecordsResponseBodyResponseEntityData> Data { get; set; }
                public class QueryRmsAlertRecordsResponseBodyResponseEntityData : TeaModel {
                    [NameInMap("AlertRuleId")]
                    [Validation(Required=false)]
                    public long? AlertRuleId { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MonitorItemType")]
                    [Validation(Required=false)]
                    public string MonitorItemType { get; set; }

                    [NameInMap("MonitorOpotionKey")]
                    [Validation(Required=false)]
                    public string MonitorOpotionKey { get; set; }

                    [NameInMap("MonitorOptionKey")]
                    [Validation(Required=false)]
                    public string MonitorOptionKey { get; set; }

                    [NameInMap("MonitorPort")]
                    [Validation(Required=false)]
                    public long? MonitorPort { get; set; }

                    [NameInMap("MonitorTargetId")]
                    [Validation(Required=false)]
                    public string MonitorTargetId { get; set; }

                    [NameInMap("MonitorTargetName")]
                    [Validation(Required=false)]
                    public string MonitorTargetName { get; set; }

                    [NameInMap("MonitorTargetType")]
                    [Validation(Required=false)]
                    public string MonitorTargetType { get; set; }

                    [NameInMap("NotificationState")]
                    [Validation(Required=false)]
                    public string NotificationState { get; set; }

                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public string ProjectId { get; set; }

                    [NameInMap("RuleType")]
                    [Validation(Required=false)]
                    public string RuleType { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("TriggerState")]
                    [Validation(Required=false)]
                    public string TriggerState { get; set; }

                    [NameInMap("TriggerValue")]
                    [Validation(Required=false)]
                    public long? TriggerValue { get; set; }

                    [NameInMap("TriggerValueThreshold")]
                    [Validation(Required=false)]
                    public string TriggerValueThreshold { get; set; }

                    [NameInMap("UtcCreated")]
                    [Validation(Required=false)]
                    public string UtcCreated { get; set; }

                    [NameInMap("UtcModified")]
                    [Validation(Required=false)]
                    public string UtcModified { get; set; }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                    [NameInMap("NotificationResults")]
                    [Validation(Required=false)]
                    public List<QueryRmsAlertRecordsResponseBodyResponseEntityDataNotificationResults> NotificationResults { get; set; }
                    public class QueryRmsAlertRecordsResponseBodyResponseEntityDataNotificationResults : TeaModel {
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

            }
        };

    }

}
