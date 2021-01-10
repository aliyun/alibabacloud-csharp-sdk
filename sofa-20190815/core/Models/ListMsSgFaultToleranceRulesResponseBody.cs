// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMsSgFaultToleranceRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("RuleModels")]
        [Validation(Required=false)]
        public List<ListMsSgFaultToleranceRulesResponseBodyRuleModels> RuleModels { get; set; }
        public class ListMsSgFaultToleranceRulesResponseBodyRuleModels : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public long? Enabled { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Orders")]
            [Validation(Required=false)]
            public List<ListMsSgFaultToleranceRulesResponseBodyRuleModelsOrders> Orders { get; set; }
            public class ListMsSgFaultToleranceRulesResponseBodyRuleModelsOrders : TeaModel {
                [NameInMap("Dir")]
                [Validation(Required=false)]
                public string Dir { get; set; }

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            [NameInMap("RuleItemList")]
            [Validation(Required=false)]
            public List<ListMsSgFaultToleranceRulesResponseBodyRuleModelsRuleItemList> RuleItemList { get; set; }
            public class ListMsSgFaultToleranceRulesResponseBodyRuleModelsRuleItemList : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                [NameInMap("Scopes")]
                [Validation(Required=false)]
                public List<string> Scopes { get; set; }

                [NameInMap("Actions")]
                [Validation(Required=false)]
                public List<ListMsSgFaultToleranceRulesResponseBodyRuleModelsRuleItemListActions> Actions { get; set; }
                public class ListMsSgFaultToleranceRulesResponseBodyRuleModelsRuleItemListActions : TeaModel {
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<ListMsSgFaultToleranceRulesResponseBodyRuleModelsRuleItemListConditions> Conditions { get; set; }
                public class ListMsSgFaultToleranceRulesResponseBodyRuleModelsRuleItemListConditions : TeaModel {
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public List<string> Value { get; set; }

                }

                [NameInMap("Configs")]
                [Validation(Required=false)]
                public ListMsSgFaultToleranceRulesResponseBodyRuleModelsRuleItemListConfigs Configs { get; set; }
                public class ListMsSgFaultToleranceRulesResponseBodyRuleModelsRuleItemListConfigs : TeaModel {
                    [NameInMap("ExceptionRateMultiple")]
                    [Validation(Required=false)]
                    public long? ExceptionRateMultiple { get; set; }
                    [NameInMap("LeastExceptionRate")]
                    [Validation(Required=false)]
                    public long? LeastExceptionRate { get; set; }
                    [NameInMap("LeastWindowCount")]
                    [Validation(Required=false)]
                    public long? LeastWindowCount { get; set; }
                    [NameInMap("MaxIpCount")]
                    [Validation(Required=false)]
                    public long? MaxIpCount { get; set; }
                    [NameInMap("TimeWindow")]
                    [Validation(Required=false)]
                    public long? TimeWindow { get; set; }
                    [NameInMap("ExceptionTypes")]
                    [Validation(Required=false)]
                    public List<string> ExceptionTypes { get; set; }
                };

            }

        }

    }

}
