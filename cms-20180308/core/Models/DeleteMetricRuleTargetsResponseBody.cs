// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class DeleteMetricRuleTargetsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FailIds")]
        [Validation(Required=false)]
        public DeleteMetricRuleTargetsResponseBodyFailIds FailIds { get; set; }
        public class DeleteMetricRuleTargetsResponseBodyFailIds : TeaModel {
            [NameInMap("TargetIds")]
            [Validation(Required=false)]
            public DeleteMetricRuleTargetsResponseBodyFailIdsTargetIds TargetIds { get; set; }
            public class DeleteMetricRuleTargetsResponseBodyFailIdsTargetIds : TeaModel {
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public List<string> TargetId { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
