// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAlarmMetricResponseBody : TeaModel {
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
        public List<QueryRmsAlarmMetricResponseBodyResponse> Response { get; set; }
        public class QueryRmsAlarmMetricResponseBodyResponse : TeaModel {
            [NameInMap("AlertLevel")]
            [Validation(Required=false)]
            public long? AlertLevel { get; set; }

            [NameInMap("HasOne")]
            [Validation(Required=false)]
            public bool? HasOne { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("MagName")]
            [Validation(Required=false)]
            public string MagName { get; set; }

            [NameInMap("Open")]
            [Validation(Required=false)]
            public bool? Open { get; set; }

            [NameInMap("Mas")]
            [Validation(Required=false)]
            public List<QueryRmsAlarmMetricResponseBodyResponseMas> Mas { get; set; }
            public class QueryRmsAlarmMetricResponseBodyResponseMas : TeaModel {
                [NameInMap("HasOne")]
                [Validation(Required=false)]
                public bool? HasOne { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("MaName")]
                [Validation(Required=false)]
                public string MaName { get; set; }

                [NameInMap("Triggers")]
                [Validation(Required=false)]
                public List<QueryRmsAlarmMetricResponseBodyResponseMasTriggers> Triggers { get; set; }
                public class QueryRmsAlarmMetricResponseBodyResponseMasTriggers : TeaModel {
                    [NameInMap("Aggregator")]
                    [Validation(Required=false)]
                    public string Aggregator { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public string N { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("TriggerOperator")]
                    [Validation(Required=false)]
                    public string TriggerOperator { get; set; }

                    [NameInMap("TriggerType")]
                    [Validation(Required=false)]
                    public string TriggerType { get; set; }

                    [NameInMap("Downsample")]
                    [Validation(Required=false)]
                    public QueryRmsAlarmMetricResponseBodyResponseMasTriggersDownsample Downsample { get; set; }
                    public class QueryRmsAlarmMetricResponseBodyResponseMasTriggersDownsample : TeaModel {
                        [NameInMap("Aggregator")]
                        [Validation(Required=false)]
                        public string Aggregator { get; set; }
                        [NameInMap("Interval")]
                        [Validation(Required=false)]
                        public string Interval { get; set; }
                        [NameInMap("Units")]
                        [Validation(Required=false)]
                        public string Units { get; set; }
                    };

                }

                [NameInMap("Am")]
                [Validation(Required=false)]
                public QueryRmsAlarmMetricResponseBodyResponseMasAm Am { get; set; }
                public class QueryRmsAlarmMetricResponseBodyResponseMasAm : TeaModel {
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }
                    [NameInMap("BlackLists")]
                    [Validation(Required=false)]
                    public List<QueryRmsAlarmMetricResponseBodyResponseMasAmBlackLists> BlackLists { get; set; }
                    public class QueryRmsAlarmMetricResponseBodyResponseMasAmBlackLists : TeaModel {
                        public string Key { get; set; }
                        public List<string> Values { get; set; }
                    }
                    [NameInMap("WhiteLists")]
                    [Validation(Required=false)]
                    public List<QueryRmsAlarmMetricResponseBodyResponseMasAmWhiteLists> WhiteLists { get; set; }
                    public class QueryRmsAlarmMetricResponseBodyResponseMasAmWhiteLists : TeaModel {
                        public string Key { get; set; }
                        public List<string> Values { get; set; }
                    }
                };

            }

            [NameInMap("Subers")]
            [Validation(Required=false)]
            public List<QueryRmsAlarmMetricResponseBodyResponseSubers> Subers { get; set; }
            public class QueryRmsAlarmMetricResponseBodyResponseSubers : TeaModel {
                [NameInMap("SuberId")]
                [Validation(Required=false)]
                public string SuberId { get; set; }

                [NameInMap("SuberType")]
                [Validation(Required=false)]
                public string SuberType { get; set; }

            }

            [NameInMap("At")]
            [Validation(Required=false)]
            public QueryRmsAlarmMetricResponseBodyResponseAt At { get; set; }
            public class QueryRmsAlarmMetricResponseBodyResponseAt : TeaModel {
                [NameInMap("CheckMinute")]
                [Validation(Required=false)]
                public long? CheckMinute { get; set; }
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }
                [NameInMap("PauseEndTime")]
                [Validation(Required=false)]
                public long? PauseEndTime { get; set; }
                [NameInMap("PauseStartTime")]
                [Validation(Required=false)]
                public long? PauseStartTime { get; set; }
                [NameInMap("SilentPeriod")]
                [Validation(Required=false)]
                public long? SilentPeriod { get; set; }
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }
            };

            [NameInMap("Status")]
            [Validation(Required=false)]
            public QueryRmsAlarmMetricResponseBodyResponseStatus Status { get; set; }
            public class QueryRmsAlarmMetricResponseBodyResponseStatus : TeaModel {
                [NameInMap("LastCheckResult")]
                [Validation(Required=false)]
                public bool? LastCheckResult { get; set; }
                [NameInMap("LastCheckSuccess")]
                [Validation(Required=false)]
                public bool? LastCheckSuccess { get; set; }
                [NameInMap("LastCheckTime")]
                [Validation(Required=false)]
                public long? LastCheckTime { get; set; }
                [NameInMap("LastNotifyTime")]
                [Validation(Required=false)]
                public long? LastNotifyTime { get; set; }
            };

        }

    }

}
