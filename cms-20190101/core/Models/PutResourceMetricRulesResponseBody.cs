// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutResourceMetricRulesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FailedListResult")]
        [Validation(Required=false)]
        public PutResourceMetricRulesResponseBodyFailedListResult FailedListResult { get; set; }
        public class PutResourceMetricRulesResponseBodyFailedListResult : TeaModel {
            [NameInMap("Target")]
            [Validation(Required=false)]
            public List<PutResourceMetricRulesResponseBodyFailedListResultTarget> Target { get; set; }
            public class PutResourceMetricRulesResponseBodyFailedListResultTarget : TeaModel {
                public PutResourceMetricRulesResponseBodyFailedListResultTargetResult Result { get; set; }
                public class PutResourceMetricRulesResponseBodyFailedListResultTargetResult : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                }
                public string RuleId { get; set; }
            }
        };

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
