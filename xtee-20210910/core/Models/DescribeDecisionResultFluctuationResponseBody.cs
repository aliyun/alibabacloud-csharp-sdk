// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeDecisionResultFluctuationResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeDecisionResultFluctuationResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeDecisionResultFluctuationResponseBodyResultObject : TeaModel {
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("todayNum")]
            [Validation(Required=false)]
            public long? TodayNum { get; set; }

            [NameInMap("withinSevenDayNum")]
            [Validation(Required=false)]
            public string WithinSevenDayNum { get; set; }

            [NameInMap("withinThirtyDayNum")]
            [Validation(Required=false)]
            public string WithinThirtyDayNum { get; set; }

            [NameInMap("withinThreeDayNum")]
            [Validation(Required=false)]
            public string WithinThreeDayNum { get; set; }

            [NameInMap("yesterdayNum")]
            [Validation(Required=false)]
            public long? YesterdayNum { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
