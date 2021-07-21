// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleCountResponseBody : TeaModel {
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

        [NameInMap("MetricRuleCount")]
        [Validation(Required=false)]
        public DescribeMetricRuleCountResponseBodyMetricRuleCount MetricRuleCount { get; set; }
        public class DescribeMetricRuleCountResponseBodyMetricRuleCount : TeaModel {
            [NameInMap("Ok")]
            [Validation(Required=false)]
            public int? Ok { get; set; }
            [NameInMap("Nodata")]
            [Validation(Required=false)]
            public int? Nodata { get; set; }
            [NameInMap("Disable")]
            [Validation(Required=false)]
            public int? Disable { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("Alarm")]
            [Validation(Required=false)]
            public int? Alarm { get; set; }
        };

    }

}
