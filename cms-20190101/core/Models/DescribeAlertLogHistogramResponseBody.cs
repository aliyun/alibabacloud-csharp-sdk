// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogHistogramResponseBody : TeaModel {
        [NameInMap("AlertLogHistogramList")]
        [Validation(Required=false)]
        public List<DescribeAlertLogHistogramResponseBodyAlertLogHistogramList> AlertLogHistogramList { get; set; }
        public class DescribeAlertLogHistogramResponseBodyAlertLogHistogramList : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("From")]
            [Validation(Required=false)]
            public long? From { get; set; }

            [NameInMap("To")]
            [Validation(Required=false)]
            public long? To { get; set; }

        }

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

    }

}
