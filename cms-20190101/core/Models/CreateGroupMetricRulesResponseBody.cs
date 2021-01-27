// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateGroupMetricRulesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public CreateGroupMetricRulesResponseBodyResources Resources { get; set; }
        public class CreateGroupMetricRulesResponseBodyResources : TeaModel {
            [NameInMap("AlertResult")]
            [Validation(Required=false)]
            public List<CreateGroupMetricRulesResponseBodyResourcesAlertResult> AlertResult { get; set; }
            public class CreateGroupMetricRulesResponseBodyResourcesAlertResult : TeaModel {
                public bool? Success { get; set; }
                public int? Code { get; set; }
                public string Message { get; set; }
                public string RuleName { get; set; }
                public string RuleId { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
