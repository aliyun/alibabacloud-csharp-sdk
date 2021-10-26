// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiStageResponseBody : TeaModel {
        [NameInMap("StageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Variables")]
        [Validation(Required=false)]
        public DescribeApiStageResponseBodyVariables Variables { get; set; }
        public class DescribeApiStageResponseBodyVariables : TeaModel {
            [NameInMap("VariableItem")]
            [Validation(Required=false)]
            public List<DescribeApiStageResponseBodyVariablesVariableItem> VariableItem { get; set; }
            public class DescribeApiStageResponseBodyVariablesVariableItem : TeaModel {
                public string VariableValue { get; set; }
                public string VariableName { get; set; }
                public bool? SupportRoute { get; set; }
                public DescribeApiStageResponseBodyVariablesVariableItemStageRouteModel StageRouteModel { get; set; }
                public class DescribeApiStageResponseBodyVariablesVariableItemStageRouteModel : TeaModel {
                    [NameInMap("RouteMatchSymbol")]
                    [Validation(Required=false)]
                    public string RouteMatchSymbol { get; set; }

                    [NameInMap("ParameterType")]
                    [Validation(Required=false)]
                    public string ParameterType { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("ParameterCatalog")]
                    [Validation(Required=false)]
                    public string ParameterCatalog { get; set; }

                    [NameInMap("ServiceParameterName")]
                    [Validation(Required=false)]
                    public string ServiceParameterName { get; set; }

                    [NameInMap("RouteRules")]
                    [Validation(Required=false)]
                    public DescribeApiStageResponseBodyVariablesVariableItemStageRouteModelRouteRules RouteRules { get; set; }
                    public class DescribeApiStageResponseBodyVariablesVariableItemStageRouteModelRouteRules : TeaModel {
                        [NameInMap("RouteRuleItem")]
                        [Validation(Required=false)]
                        public List<DescribeApiStageResponseBodyVariablesVariableItemStageRouteModelRouteRulesRouteRuleItem> RouteRuleItem { get; set; }
                        public class DescribeApiStageResponseBodyVariablesVariableItemStageRouteModelRouteRulesRouteRuleItem : TeaModel {
                            public string ResultValue { get; set; }
                            public long? MinValue { get; set; }
                            public string ConditionValue { get; set; }
                            public long? MaxValue { get; set; }
                        }
                    };

                }
            }
        };

    }

}
