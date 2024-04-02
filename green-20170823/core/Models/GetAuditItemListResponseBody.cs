// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class GetAuditItemListResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<GetAuditItemListResponseBodyItems> Items { get; set; }
        public class GetAuditItemListResponseBodyItems : TeaModel {
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Create")]
            [Validation(Required=false)]
            public string Create { get; set; }

            [NameInMap("CustomResult")]
            [Validation(Required=false)]
            public string CustomResult { get; set; }

            [NameInMap("CustomRiskType")]
            [Validation(Required=false)]
            public string CustomRiskType { get; set; }

            [NameInMap("CustomTs")]
            [Validation(Required=false)]
            public string CustomTs { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("RcpResult")]
            [Validation(Required=false)]
            public string RcpResult { get; set; }

            [NameInMap("RcpRiskType")]
            [Validation(Required=false)]
            public string RcpRiskType { get; set; }

            [NameInMap("RcpTs")]
            [Validation(Required=false)]
            public string RcpTs { get; set; }

            [NameInMap("SubUid")]
            [Validation(Required=false)]
            public string SubUid { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Thumbnail")]
            [Validation(Required=false)]
            public string Thumbnail { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
