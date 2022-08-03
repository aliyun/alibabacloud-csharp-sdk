// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20161111.Models
{
    public class ListAccountRecordsForParentResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public ListAccountRecordsForParentResponseBodyRecords Records { get; set; }
        public class ListAccountRecordsForParentResponseBodyRecords : TeaModel {
            [NameInMap("Record")]
            [Validation(Required=false)]
            public List<ListAccountRecordsForParentResponseBodyRecordsRecord> Record { get; set; }
            public class ListAccountRecordsForParentResponseBodyRecordsRecord : TeaModel {
                public string AccountId { get; set; }
                public string AccountName { get; set; }
                public string DisplayName { get; set; }
                public string FolderId { get; set; }
                public string JoinMethod { get; set; }
                public string JoinTime { get; set; }
                public string ModifyTime { get; set; }
                public string RecordId { get; set; }
                public string ResourceDirectoryId { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
