// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMsSgRouterRuleGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListMsSgRouterRuleGroupsResponseBodyList> List { get; set; }
        public class ListMsSgRouterRuleGroupsResponseBodyList : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public long? Enabled { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("GrayCondition")]
            [Validation(Required=false)]
            public string GrayCondition { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListMsSgRouterRuleGroupsResponseBodyListRules> Rules { get; set; }
            public class ListMsSgRouterRuleGroupsResponseBodyListRules : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public long? Enabled { get; set; }

                [NameInMap("Fallback")]
                [Validation(Required=false)]
                public long? Fallback { get; set; }

                [NameInMap("FaultProtection")]
                [Validation(Required=false)]
                public long? FaultProtection { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OrderNum")]
                [Validation(Required=false)]
                public long? OrderNum { get; set; }

                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<ListMsSgRouterRuleGroupsResponseBodyListRulesConditions> Conditions { get; set; }
                public class ListMsSgRouterRuleGroupsResponseBodyListRulesConditions : TeaModel {
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

                [NameInMap("Destinations")]
                [Validation(Required=false)]
                public List<ListMsSgRouterRuleGroupsResponseBodyListRulesDestinations> Destinations { get; set; }
                public class ListMsSgRouterRuleGroupsResponseBodyListRulesDestinations : TeaModel {
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public long? Weight { get; set; }

                    [NameInMap("Destination")]
                    [Validation(Required=false)]
                    public List<ListMsSgRouterRuleGroupsResponseBodyListRulesDestinationsDestination> Destination { get; set; }
                    public class ListMsSgRouterRuleGroupsResponseBodyListRulesDestinationsDestination : TeaModel {
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

                }

                [NameInMap("Grays")]
                [Validation(Required=false)]
                public List<ListMsSgRouterRuleGroupsResponseBodyListRulesGrays> Grays { get; set; }
                public class ListMsSgRouterRuleGroupsResponseBodyListRulesGrays : TeaModel {
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

            }

        }

    }

}
