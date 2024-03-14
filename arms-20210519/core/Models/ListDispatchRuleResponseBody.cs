// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210519.Models
{
    public class ListDispatchRuleResponseBody : TeaModel {
        [NameInMap("DispatchRules")]
        [Validation(Required=false)]
        public List<ListDispatchRuleResponseBodyDispatchRules> DispatchRules { get; set; }
        public class ListDispatchRuleResponseBodyDispatchRules : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
