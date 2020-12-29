// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertRulesResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchAlertRulesResponseBodyPageBean PageBean { get; set; }
        public class SearchAlertRulesResponseBodyPageBean : TeaModel {
            [NameInMap("AlertRules")]
            [Validation(Required=false)]
            public List<SearchAlertRulesResponseBodyPageBeanAlertRules> AlertRules { get; set; }
            public class SearchAlertRulesResponseBodyPageBeanAlertRules : TeaModel {
                public string Status { get; set; }
                public SearchAlertRulesResponseBodyPageBeanAlertRulesAlarmContext AlarmContext { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesAlarmContext : TeaModel {
                    [NameInMap("AlarmContentSubTitle")]
                    [Validation(Required=false)]
                    public string AlarmContentSubTitle { get; set; }

                    [NameInMap("AlarmContentTemplate")]
                    [Validation(Required=false)]
                    public string AlarmContentTemplate { get; set; }

                    [NameInMap("SubTitle")]
                    [Validation(Required=false)]
                    public string SubTitle { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                }
                public long? UpdateTime { get; set; }
                public string ContactGroupIdList { get; set; }
                public SearchAlertRulesResponseBodyPageBeanAlertRulesNotice Notice { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesNotice : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("NoticeEndTime")]
                    [Validation(Required=false)]
                    public long? NoticeEndTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("NoticeStartTime")]
                    [Validation(Required=false)]
                    public long? NoticeStartTime { get; set; }

                }
                public long? CreateTime { get; set; }
                public string AlertTitle { get; set; }
                public string UserId { get; set; }
                public int? AlertVersion { get; set; }
                public SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRule AlertRule { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRule : TeaModel {
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public List<SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRuleRules> Rules { get; set; }
                    public class SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRuleRules : TeaModel {
                        [NameInMap("Measure")]
                        [Validation(Required=false)]
                        public string Measure { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public float? Value { get; set; }

                        [NameInMap("Aggregates")]
                        [Validation(Required=false)]
                        public string Aggregates { get; set; }

                        [NameInMap("NValue")]
                        [Validation(Required=false)]
                        public int? NValue { get; set; }

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                    }

                }
                public SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParam MetricParam { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParam : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("AppGroupId")]
                    [Validation(Required=false)]
                    public string AppGroupId { get; set; }

                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("Pid")]
                    [Validation(Required=false)]
                    public string Pid { get; set; }

                    [NameInMap("Dimensions")]
                    [Validation(Required=false)]
                    public List<SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParamDimensions> Dimensions { get; set; }
                    public class SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParamDimensions : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public int? AlertType { get; set; }
                public string ContactGroupIds { get; set; }
                public string Config { get; set; }
                public string RegionId { get; set; }
                public string AlertLevel { get; set; }
                public List<string> AlertWay { get; set; }
                public string TaskStatus { get; set; }
                public string Title { get; set; }
                public long? TaskId { get; set; }
                public long? Id { get; set; }
                public List<string> AlertWays { get; set; }
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
