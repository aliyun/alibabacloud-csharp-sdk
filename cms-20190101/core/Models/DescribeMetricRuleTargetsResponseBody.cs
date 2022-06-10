// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTargetsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Targets")]
        [Validation(Required=false)]
        public DescribeMetricRuleTargetsResponseBodyTargets Targets { get; set; }
        public class DescribeMetricRuleTargetsResponseBodyTargets : TeaModel {
            [NameInMap("Target")]
            [Validation(Required=false)]
            public List<DescribeMetricRuleTargetsResponseBodyTargetsTarget> Target { get; set; }
            public class DescribeMetricRuleTargetsResponseBodyTargetsTarget : TeaModel {
                public string Arn { get; set; }
                public string Id { get; set; }
                public string JsonParams { get; set; }
                public string Level { get; set; }
            }
        };

    }

}
