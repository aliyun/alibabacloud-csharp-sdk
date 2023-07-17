// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
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
                [NameInMap("AlarmContext")]
                [Validation(Required=false)]
                public SearchAlertRulesResponseBodyPageBeanAlertRulesAlarmContext AlarmContext { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesAlarmContext : TeaModel {
                    [NameInMap("AlarmContentSubTitle")]
                    [Validation(Required=false)]
                    public string AlarmContentSubTitle { get; set; }

                    [NameInMap("AlarmContentTemplate")]
                    [Validation(Required=false)]
                    public string AlarmContentTemplate { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("SubTitle")]
                    [Validation(Required=false)]
                    public string SubTitle { get; set; }

                }

                [NameInMap("AlertLevel")]
                [Validation(Required=false)]
                public string AlertLevel { get; set; }

                [NameInMap("AlertRule")]
                [Validation(Required=false)]
                public SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRule AlertRule { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRule : TeaModel {
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public List<SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRuleRules> Rules { get; set; }
                    public class SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRuleRules : TeaModel {
                        [NameInMap("Aggregates")]
                        [Validation(Required=false)]
                        public string Aggregates { get; set; }

                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                        [NameInMap("Measure")]
                        [Validation(Required=false)]
                        public string Measure { get; set; }

                        [NameInMap("NValue")]
                        [Validation(Required=false)]
                        public int? NValue { get; set; }

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public float? Value { get; set; }

                    }

                }

                [NameInMap("AlertTitle")]
                [Validation(Required=false)]
                public string AlertTitle { get; set; }

                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public int? AlertType { get; set; }

                [NameInMap("AlertVersion")]
                [Validation(Required=false)]
                public int? AlertVersion { get; set; }

                [NameInMap("AlertWay")]
                [Validation(Required=false)]
                public List<string> AlertWay { get; set; }

                [NameInMap("AlertWays")]
                [Validation(Required=false)]
                public List<string> AlertWays { get; set; }

                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                [NameInMap("ContactGroupIdList")]
                [Validation(Required=false)]
                public string ContactGroupIdList { get; set; }

                [NameInMap("ContactGroupIds")]
                [Validation(Required=false)]
                public string ContactGroupIds { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("MetricParam")]
                [Validation(Required=false)]
                public SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParam MetricParam { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParam : TeaModel {
                    [NameInMap("AppGroupId")]
                    [Validation(Required=false)]
                    public string AppGroupId { get; set; }

                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

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

                    [NameInMap("Pid")]
                    [Validation(Required=false)]
                    public string Pid { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Notice")]
                [Validation(Required=false)]
                public SearchAlertRulesResponseBodyPageBeanAlertRulesNotice Notice { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesNotice : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("NoticeEndTime")]
                    [Validation(Required=false)]
                    public long? NoticeEndTime { get; set; }

                    [NameInMap("NoticeStartTime")]
                    [Validation(Required=false)]
                    public long? NoticeStartTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

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
