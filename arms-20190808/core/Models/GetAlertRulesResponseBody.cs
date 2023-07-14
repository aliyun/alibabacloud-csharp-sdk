// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAlertRulesResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public GetAlertRulesResponseBodyPageBean PageBean { get; set; }
        public class GetAlertRulesResponseBodyPageBean : TeaModel {
            [NameInMap("AlertRules")]
            [Validation(Required=false)]
            public List<GetAlertRulesResponseBodyPageBeanAlertRules> AlertRules { get; set; }
            public class GetAlertRulesResponseBodyPageBeanAlertRules : TeaModel {
                [NameInMap("AlertCheckType")]
                [Validation(Required=false)]
                public string AlertCheckType { get; set; }

                [NameInMap("AlertGroup")]
                [Validation(Required=false)]
                public long? AlertGroup { get; set; }

                [NameInMap("AlertId")]
                [Validation(Required=false)]
                public float? AlertId { get; set; }

                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                [NameInMap("AlertRuleContent")]
                [Validation(Required=false)]
                public GetAlertRulesResponseBodyPageBeanAlertRulesAlertRuleContent AlertRuleContent { get; set; }
                public class GetAlertRulesResponseBodyPageBeanAlertRulesAlertRuleContent : TeaModel {
                    [NameInMap("AlertRuleItems")]
                    [Validation(Required=false)]
                    public List<GetAlertRulesResponseBodyPageBeanAlertRulesAlertRuleContentAlertRuleItems> AlertRuleItems { get; set; }
                    public class GetAlertRulesResponseBodyPageBeanAlertRulesAlertRuleContentAlertRuleItems : TeaModel {
                        [NameInMap("Aggregate")]
                        [Validation(Required=false)]
                        public string Aggregate { get; set; }

                        [NameInMap("MetricKey")]
                        [Validation(Required=false)]
                        public string MetricKey { get; set; }

                        [NameInMap("N")]
                        [Validation(Required=false)]
                        public float? N { get; set; }

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                }

                [NameInMap("AlertStatus")]
                [Validation(Required=false)]
                public string AlertStatus { get; set; }

                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                [NameInMap("Annotations")]
                [Validation(Required=false)]
                public List<GetAlertRulesResponseBodyPageBeanAlertRulesAnnotations> Annotations { get; set; }
                public class GetAlertRulesResponseBodyPageBeanAlertRulesAnnotations : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("AutoAddNewApplication")]
                [Validation(Required=false)]
                public bool? AutoAddNewApplication { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

                [NameInMap("Filters")]
                [Validation(Required=false)]
                public GetAlertRulesResponseBodyPageBeanAlertRulesFilters Filters { get; set; }
                public class GetAlertRulesResponseBodyPageBeanAlertRulesFilters : TeaModel {
                    [NameInMap("CustomSLSFilters")]
                    [Validation(Required=false)]
                    public List<GetAlertRulesResponseBodyPageBeanAlertRulesFiltersCustomSLSFilters> CustomSLSFilters { get; set; }
                    public class GetAlertRulesResponseBodyPageBeanAlertRulesFiltersCustomSLSFilters : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Opt")]
                        [Validation(Required=false)]
                        public string Opt { get; set; }

                        [NameInMap("Show")]
                        [Validation(Required=false)]
                        public bool? Show { get; set; }

                        [NameInMap("T")]
                        [Validation(Required=false)]
                        public string T { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("CustomSLSGroupByDimensions")]
                    [Validation(Required=false)]
                    public List<string> CustomSLSGroupByDimensions { get; set; }

                    [NameInMap("CustomSLSWheres")]
                    [Validation(Required=false)]
                    public List<string> CustomSLSWheres { get; set; }

                    [NameInMap("DimFilters")]
                    [Validation(Required=false)]
                    public List<GetAlertRulesResponseBodyPageBeanAlertRulesFiltersDimFilters> DimFilters { get; set; }
                    public class GetAlertRulesResponseBodyPageBeanAlertRulesFiltersDimFilters : TeaModel {
                        [NameInMap("FilterKey")]
                        [Validation(Required=false)]
                        public string FilterKey { get; set; }

                        [NameInMap("FilterOpt")]
                        [Validation(Required=false)]
                        public string FilterOpt { get; set; }

                        [NameInMap("FilterValues")]
                        [Validation(Required=false)]
                        public List<string> FilterValues { get; set; }

                    }

                }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<GetAlertRulesResponseBodyPageBeanAlertRulesLabels> Labels { get; set; }
                public class GetAlertRulesResponseBodyPageBeanAlertRulesLabels : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("MetricsType")]
                [Validation(Required=false)]
                public string MetricsType { get; set; }

                [NameInMap("NotifyStrategy")]
                [Validation(Required=false)]
                public string NotifyStrategy { get; set; }

                [NameInMap("Pids")]
                [Validation(Required=false)]
                public List<string> Pids { get; set; }

                [NameInMap("PromQL")]
                [Validation(Required=false)]
                public string PromQL { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<GetAlertRulesResponseBodyPageBeanAlertRulesTags> Tags { get; set; }
                public class GetAlertRulesResponseBodyPageBeanAlertRulesTags : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
