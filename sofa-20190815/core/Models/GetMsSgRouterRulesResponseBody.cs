// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetMsSgRouterRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("RouterRuleGroupModel")]
        [Validation(Required=false)]
        public GetMsSgRouterRulesResponseBodyRouterRuleGroupModel RouterRuleGroupModel { get; set; }
        public class GetMsSgRouterRulesResponseBodyRouterRuleGroupModel : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }
            [NameInMap("DispatchVersion")]
            [Validation(Required=false)]
            public long? DispatchVersion { get; set; }
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
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<GetMsSgRouterRulesResponseBodyRouterRuleGroupModelRules> Rules { get; set; }
            public class GetMsSgRouterRulesResponseBodyRouterRuleGroupModelRules : TeaModel {
                public long? Enabled { get; set; }
                public long? Fallback { get; set; }
                public long? FaultProtection { get; set; }
                public long? GmtModified { get; set; }
                public string Name { get; set; }
                public long? OrderNum { get; set; }
                public List<GetMsSgRouterRulesResponseBodyRouterRuleGroupModelRulesConditions> Conditions { get; set; }
                public class GetMsSgRouterRulesResponseBodyRouterRuleGroupModelRulesConditions : TeaModel {
                    public string Field { get; set; }
                    public string Operation { get; set; }
                    public string Type { get; set; }
                    public List<string> Value { get; set; }
                }
                public List<GetMsSgRouterRulesResponseBodyRouterRuleGroupModelRulesDestinations> Destinations { get; set; }
                public class GetMsSgRouterRulesResponseBodyRouterRuleGroupModelRulesDestinations : TeaModel {
                    public long? Weight { get; set; }
                    public List<GetMsSgRouterRulesResponseBodyRouterRuleGroupModelRulesDestinationsDestination> Destination { get; set; }
                    public class GetMsSgRouterRulesResponseBodyRouterRuleGroupModelRulesDestinationsDestination : TeaModel {
                        public string Field { get; set; }
                        public string Operation { get; set; }
                        public string Type { get; set; }
                        public List<string> Value { get; set; }
                    }
                }
                public List<GetMsSgRouterRulesResponseBodyRouterRuleGroupModelRulesGrays> Grays { get; set; }
                public class GetMsSgRouterRulesResponseBodyRouterRuleGroupModelRulesGrays : TeaModel {
                    public string Field { get; set; }
                    public string Operation { get; set; }
                    public string Type { get; set; }
                    public List<string> Value { get; set; }
                }
            }
        };

    }

}
