// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventResultListResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeEventResultListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeEventResultListResponseBodyResultObject : TeaModel {
            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("passNum")]
            [Validation(Required=false)]
            public long? PassNum { get; set; }

            [NameInMap("pendingNum")]
            [Validation(Required=false)]
            public long? PendingNum { get; set; }

            [NameInMap("rejectNum")]
            [Validation(Required=false)]
            public long? RejectNum { get; set; }

            [NameInMap("totalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public long? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
