// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListAuthorizationRulesResponseBody : TeaModel {
        [NameInMap("AuthorizationRules")]
        [Validation(Required=false)]
        public List<ListAuthorizationRulesResponseBodyAuthorizationRules> AuthorizationRules { get; set; }
        public class ListAuthorizationRulesResponseBodyAuthorizationRules : TeaModel {
            [NameInMap("AuthorizationRuleDescription")]
            [Validation(Required=false)]
            public string AuthorizationRuleDescription { get; set; }

            [NameInMap("AuthorizationRuleId")]
            [Validation(Required=false)]
            public string AuthorizationRuleId { get; set; }

            [NameInMap("AuthorizationRuleName")]
            [Validation(Required=false)]
            public string AuthorizationRuleName { get; set; }

            [NameInMap("AuthorizationRuleStatus")]
            [Validation(Required=false)]
            public string AuthorizationRuleStatus { get; set; }

            [NameInMap("AuthorizationRuleType")]
            [Validation(Required=false)]
            public string AuthorizationRuleType { get; set; }

            [NameInMap("Destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            [NameInMap("DestinationType")]
            [Validation(Required=false)]
            public string DestinationType { get; set; }

            [NameInMap("IoTCloudConnectorId")]
            [Validation(Required=false)]
            public string IoTCloudConnectorId { get; set; }

            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            [NameInMap("SourceCidrs")]
            [Validation(Required=false)]
            public List<string> SourceCidrs { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
