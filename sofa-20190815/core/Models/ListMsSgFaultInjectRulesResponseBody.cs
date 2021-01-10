// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMsSgFaultInjectRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("StartIndex")]
        [Validation(Required=false)]
        public long? StartIndex { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("RuleModels")]
        [Validation(Required=false)]
        public List<ListMsSgFaultInjectRulesResponseBodyRuleModels> RuleModels { get; set; }
        public class ListMsSgFaultInjectRulesResponseBodyRuleModels : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("RuleConfig")]
            [Validation(Required=false)]
            public ListMsSgFaultInjectRulesResponseBodyRuleModelsRuleConfig RuleConfig { get; set; }
            public class ListMsSgFaultInjectRulesResponseBodyRuleModelsRuleConfig : TeaModel {
                [NameInMap("HttpMethod")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }
                [NameInMap("HttpPath")]
                [Validation(Required=false)]
                public string HttpPath { get; set; }
                [NameInMap("MethodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }
                [NameInMap("TrafficType")]
                [Validation(Required=false)]
                public string TrafficType { get; set; }
                [NameInMap("FaultInjectRuleItems")]
                [Validation(Required=false)]
                public List<ListMsSgFaultInjectRulesResponseBodyRuleModelsRuleConfigFaultInjectRuleItems> FaultInjectRuleItems { get; set; }
                public class ListMsSgFaultInjectRulesResponseBodyRuleModelsRuleConfigFaultInjectRuleItems : TeaModel {
                    public string RuleType { get; set; }
                    public List<ListMsSgFaultInjectRulesResponseBodyRuleModelsRuleConfigFaultInjectRuleItemsTrafficConditions> TrafficConditions { get; set; }
                    public class ListMsSgFaultInjectRulesResponseBodyRuleModelsRuleConfigFaultInjectRuleItemsTrafficConditions : TeaModel {
                        public string Field { get; set; }
                        public string Operation { get; set; }
                        public string Type { get; set; }
                        public List<string> Value { get; set; }
                    }
                    public ListMsSgFaultInjectRulesResponseBodyRuleModelsRuleConfigFaultInjectRuleItemsAction Action { get; set; }
                    public class ListMsSgFaultInjectRulesResponseBodyRuleModelsRuleConfigFaultInjectRuleItemsAction : TeaModel {
                        [NameInMap("Extension")]
                        [Validation(Required=false)]
                        public string Extension { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }
                    public ListMsSgFaultInjectRulesResponseBodyRuleModelsRuleConfigFaultInjectRuleItemsConfigs Configs { get; set; }
                    public class ListMsSgFaultInjectRulesResponseBodyRuleModelsRuleConfigFaultInjectRuleItemsConfigs : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("FaultPercent")]
                        [Validation(Required=false)]
                        public string FaultPercent { get; set; }

                        [NameInMap("FixedDelay")]
                        [Validation(Required=false)]
                        public string FixedDelay { get; set; }

                    }
                }
            };

        }

    }

}
