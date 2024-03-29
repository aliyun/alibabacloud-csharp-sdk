// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DeleteConfigRulesResponseBody : TeaModel {
        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public DeleteConfigRulesResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class DeleteConfigRulesResponseBodyOperateRuleResult : TeaModel {
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<DeleteConfigRulesResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class DeleteConfigRulesResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                public string ConfigRuleId { get; set; }
                public string ErrorCode { get; set; }
                public bool? Success { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
