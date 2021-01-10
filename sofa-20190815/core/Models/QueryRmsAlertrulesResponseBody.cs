// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAlertrulesResponseBody : TeaModel {
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
        public QueryRmsAlertrulesResponseBodyResponse Response { get; set; }
        public class QueryRmsAlertrulesResponseBodyResponse : TeaModel {
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<QueryRmsAlertrulesResponseBodyResponseEntities> Entities { get; set; }
            public class QueryRmsAlertrulesResponseBodyResponseEntities : TeaModel {
                public string Layer { get; set; }
                public QueryRmsAlertrulesResponseBodyResponseEntitiesEntity Entity { get; set; }
                public class QueryRmsAlertrulesResponseBodyResponseEntitiesEntity : TeaModel {
                    [NameInMap("AlertLevel")]
                    [Validation(Required=false)]
                    public long? AlertLevel { get; set; }

                    [NameInMap("AlertShutEndDateTime")]
                    [Validation(Required=false)]
                    public string AlertShutEndDateTime { get; set; }

                    [NameInMap("AlertShutReason")]
                    [Validation(Required=false)]
                    public string AlertShutReason { get; set; }

                    [NameInMap("AlertShutStartDateTime")]
                    [Validation(Required=false)]
                    public string AlertShutStartDateTime { get; set; }

                    [NameInMap("AlertValidEndTime")]
                    [Validation(Required=false)]
                    public string AlertValidEndTime { get; set; }

                    [NameInMap("AlertValidStartTime")]
                    [Validation(Required=false)]
                    public string AlertValidStartTime { get; set; }

                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("RuleType")]
                    [Validation(Required=false)]
                    public string RuleType { get; set; }

                    [NameInMap("SilencePeriodMinute")]
                    [Validation(Required=false)]
                    public long? SilencePeriodMinute { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("UtcCreated")]
                    [Validation(Required=false)]
                    public string UtcCreated { get; set; }

                    [NameInMap("UtcModified")]
                    [Validation(Required=false)]
                    public string UtcModified { get; set; }

                    [NameInMap("Definition")]
                    [Validation(Required=false)]
                    public QueryRmsAlertrulesResponseBodyResponseEntitiesEntityDefinition Definition { get; set; }
                    public class QueryRmsAlertrulesResponseBodyResponseEntitiesEntityDefinition : TeaModel {
                        [NameInMap("MonitorItemType")]
                        [Validation(Required=false)]
                        public string MonitorItemType { get; set; }
                        [NameInMap("MonitorOptionKey")]
                        [Validation(Required=false)]
                        public string MonitorOptionKey { get; set; }
                        [NameInMap("MonitorPort")]
                        [Validation(Required=false)]
                        public long? MonitorPort { get; set; }
                        [NameInMap("StatisticalMethod")]
                        [Validation(Required=false)]
                        public string StatisticalMethod { get; set; }
                        [NameInMap("StatisticalPeriod")]
                        [Validation(Required=false)]
                        public long? StatisticalPeriod { get; set; }
                        [NameInMap("TriggerCountThreshold")]
                        [Validation(Required=false)]
                        public string TriggerCountThreshold { get; set; }
                        [NameInMap("TriggerOperator")]
                        [Validation(Required=false)]
                        public string TriggerOperator { get; set; }
                        [NameInMap("TriggerValueThreshold")]
                        [Validation(Required=false)]
                        public long? TriggerValueThreshold { get; set; }
                    };

                    [NameInMap("MonitorTarget")]
                    [Validation(Required=false)]
                    public QueryRmsAlertrulesResponseBodyResponseEntitiesEntityMonitorTarget MonitorTarget { get; set; }
                    public class QueryRmsAlertrulesResponseBodyResponseEntitiesEntityMonitorTarget : TeaModel {
                        [NameInMap("MonitorTargetId")]
                        [Validation(Required=false)]
                        public string MonitorTargetId { get; set; }
                        [NameInMap("MonitorTargetName")]
                        [Validation(Required=false)]
                        public string MonitorTargetName { get; set; }
                        [NameInMap("MonitorTargetType")]
                        [Validation(Required=false)]
                        public string MonitorTargetType { get; set; }
                        [NameInMap("TenantId")]
                        [Validation(Required=false)]
                        public string TenantId { get; set; }
                        [NameInMap("WorkspaceId")]
                        [Validation(Required=false)]
                        public string WorkspaceId { get; set; }
                    };

                }
            }
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public QueryRmsAlertrulesResponseBodyResponseMeta Meta { get; set; }
            public class QueryRmsAlertrulesResponseBodyResponseMeta : TeaModel {
                [NameInMap("Page")]
                [Validation(Required=false)]
                public QueryRmsAlertrulesResponseBodyResponseMetaPage Page { get; set; }
                public class QueryRmsAlertrulesResponseBodyResponseMetaPage : TeaModel {
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
