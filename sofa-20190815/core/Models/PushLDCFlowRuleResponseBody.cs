// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class PushLDCFlowRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Gray")]
        [Validation(Required=false)]
        public bool? Gray { get; set; }

        [NameInMap("RuleResultList")]
        [Validation(Required=false)]
        public List<PushLDCFlowRuleResponseBodyRuleResultList> RuleResultList { get; set; }
        public class PushLDCFlowRuleResponseBodyRuleResultList : TeaModel {
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("FailedList")]
            [Validation(Required=false)]
            public List<string> FailedList { get; set; }

            [NameInMap("SucceedList")]
            [Validation(Required=false)]
            public List<string> SucceedList { get; set; }

        }

    }

}
