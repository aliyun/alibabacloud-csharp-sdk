// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class AttachConfigRuleToCompliancePackResponseBody : TeaModel {
        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public AttachConfigRuleToCompliancePackResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class AttachConfigRuleToCompliancePackResponseBodyOperateRuleResult : TeaModel {
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<AttachConfigRuleToCompliancePackResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class AttachConfigRuleToCompliancePackResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
