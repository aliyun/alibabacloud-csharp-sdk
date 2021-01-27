// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogCountResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AlertLogCount")]
        [Validation(Required=false)]
        public List<DescribeAlertLogCountResponseBodyAlertLogCount> AlertLogCount { get; set; }
        public class DescribeAlertLogCountResponseBodyAlertLogCount : TeaModel {
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribeAlertLogCountResponseBodyAlertLogCountLogs> Logs { get; set; }
            public class DescribeAlertLogCountResponseBodyAlertLogCountLogs : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
