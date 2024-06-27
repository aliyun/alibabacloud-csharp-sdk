// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventCountResponseBody : TeaModel {
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
        public DescribeEventCountResponseBodyResultObject ResultObject { get; set; }
        public class DescribeEventCountResponseBodyResultObject : TeaModel {
            [NameInMap("limit")]
            [Validation(Required=false)]
            public bool? Limit { get; set; }

            [NameInMap("maxTotalItem")]
            [Validation(Required=false)]
            public int? MaxTotalItem { get; set; }

            [NameInMap("totalItem")]
            [Validation(Required=false)]
            public int? TotalItem { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
