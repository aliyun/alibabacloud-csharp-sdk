// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListQuotaReviewTasksResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListQuotaReviewTasksResponseBodyResult> Result { get; set; }
        public class ListQuotaReviewTasksResponseBodyResult : TeaModel {
            [NameInMap("appGroupId")]
            [Validation(Required=false)]
            public int? AppGroupId { get; set; }

            [NameInMap("appGroupName")]
            [Validation(Required=false)]
            public string AppGroupName { get; set; }

            [NameInMap("appGroupType")]
            [Validation(Required=false)]
            public string AppGroupType { get; set; }

            [NameInMap("approved")]
            [Validation(Required=false)]
            public bool? Approved { get; set; }

            [NameInMap("available")]
            [Validation(Required=false)]
            public bool? Available { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            [NameInMap("newComputeResource")]
            [Validation(Required=false)]
            public int? NewComputeResource { get; set; }

            [NameInMap("newSocSize")]
            [Validation(Required=false)]
            public int? NewSocSize { get; set; }

            [NameInMap("newSpec")]
            [Validation(Required=false)]
            public string NewSpec { get; set; }

            [NameInMap("oldComputeResource")]
            [Validation(Required=false)]
            public int? OldComputeResource { get; set; }

            [NameInMap("oldDocSize")]
            [Validation(Required=false)]
            public int? OldDocSize { get; set; }

            [NameInMap("oldSpec")]
            [Validation(Required=false)]
            public string OldSpec { get; set; }

            [NameInMap("pending")]
            [Validation(Required=false)]
            public bool? Pending { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
