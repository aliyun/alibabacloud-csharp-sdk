// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListClriskIssueTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListClriskIssueTaskResponseBodyDataList> DataList { get; set; }
        public class ListClriskIssueTaskResponseBodyDataList : TeaModel {
            [NameInMap("Cycle")]
            [Validation(Required=false)]
            public string Cycle { get; set; }

            [NameInMap("DiffSize")]
            [Validation(Required=false)]
            public long? DiffSize { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("IssueDataId")]
            [Validation(Required=false)]
            public long? IssueDataId { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

    }

}
