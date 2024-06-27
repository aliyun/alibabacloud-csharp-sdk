// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeOperationLogPageListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeOperationLogPageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeOperationLogPageListResponseBodyResultObject : TeaModel {
            [NameInMap("clientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("newContent")]
            [Validation(Required=false)]
            public string NewContent { get; set; }

            [NameInMap("oldContent")]
            [Validation(Required=false)]
            public string OldContent { get; set; }

            [NameInMap("operationSummary")]
            [Validation(Required=false)]
            public string OperationSummary { get; set; }

            [NameInMap("operationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
