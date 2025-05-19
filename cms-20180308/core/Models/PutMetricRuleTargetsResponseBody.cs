// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class PutMetricRuleTargetsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FailData")]
        [Validation(Required=false)]
        public PutMetricRuleTargetsResponseBodyFailData FailData { get; set; }
        public class PutMetricRuleTargetsResponseBodyFailData : TeaModel {
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public PutMetricRuleTargetsResponseBodyFailDataTargets Targets { get; set; }
            public class PutMetricRuleTargetsResponseBodyFailDataTargets : TeaModel {
                [NameInMap("Target")]
                [Validation(Required=false)]
                public List<PutMetricRuleTargetsResponseBodyFailDataTargetsTarget> Target { get; set; }
                public class PutMetricRuleTargetsResponseBodyFailDataTargetsTarget : TeaModel {
                    [NameInMap("Arn")]
                    [Validation(Required=false)]
                    public string Arn { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                }

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
