// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchCreateDcdnWafRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public BatchCreateDcdnWafRulesResponseBodyRuleIds RuleIds { get; set; }
        public class BatchCreateDcdnWafRulesResponseBodyRuleIds : TeaModel {
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public List<string> RuleId { get; set; }

        }

    }

}
