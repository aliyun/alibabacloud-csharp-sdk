// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
{
    public class DescribeApiStageDetailResponseBody : TeaModel {
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        [NameInMap("Variables")]
        [Validation(Required=false)]
        public DescribeApiStageDetailResponseBodyVariables Variables { get; set; }
        public class DescribeApiStageDetailResponseBodyVariables : TeaModel {
            [NameInMap("VariableItem")]
            [Validation(Required=false)]
            public List<DescribeApiStageDetailResponseBodyVariablesVariableItem> VariableItem { get; set; }
            public class DescribeApiStageDetailResponseBodyVariablesVariableItem : TeaModel {
                [NameInMap("StageRouteModel")]
                [Validation(Required=false)]
                public DescribeApiStageDetailResponseBodyVariablesVariableItemStageRouteModel StageRouteModel { get; set; }
                public class DescribeApiStageDetailResponseBodyVariablesVariableItemStageRouteModel : TeaModel {
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("ParameterCatalog")]
                    [Validation(Required=false)]
                    public string ParameterCatalog { get; set; }

                    [NameInMap("ParameterType")]
                    [Validation(Required=false)]
                    public string ParameterType { get; set; }

                    [NameInMap("RouteMatchSymbol")]
                    [Validation(Required=false)]
                    public string RouteMatchSymbol { get; set; }

                    [NameInMap("RouteRules")]
                    [Validation(Required=false)]
                    public DescribeApiStageDetailResponseBodyVariablesVariableItemStageRouteModelRouteRules RouteRules { get; set; }
                    public class DescribeApiStageDetailResponseBodyVariablesVariableItemStageRouteModelRouteRules : TeaModel {
                        [NameInMap("RouteRuleItem")]
                        [Validation(Required=false)]
                        public List<DescribeApiStageDetailResponseBodyVariablesVariableItemStageRouteModelRouteRulesRouteRuleItem> RouteRuleItem { get; set; }
                        public class DescribeApiStageDetailResponseBodyVariablesVariableItemStageRouteModelRouteRulesRouteRuleItem : TeaModel {
                            [NameInMap("ConditionValue")]
                            [Validation(Required=false)]
                            public string ConditionValue { get; set; }

                            [NameInMap("MaxValue")]
                            [Validation(Required=false)]
                            public long? MaxValue { get; set; }

                            [NameInMap("MinValue")]
                            [Validation(Required=false)]
                            public long? MinValue { get; set; }

                            [NameInMap("ResultValue")]
                            [Validation(Required=false)]
                            public string ResultValue { get; set; }

                        }

                    }

                    [NameInMap("ServiceParameterName")]
                    [Validation(Required=false)]
                    public string ServiceParameterName { get; set; }

                }

                [NameInMap("SupportRoute")]
                [Validation(Required=false)]
                public bool? SupportRoute { get; set; }

                [NameInMap("VariableName")]
                [Validation(Required=false)]
                public string VariableName { get; set; }

                [NameInMap("VariableValue")]
                [Validation(Required=false)]
                public string VariableValue { get; set; }

            }

        }

    }

}
