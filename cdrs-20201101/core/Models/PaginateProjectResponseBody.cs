// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class PaginateProjectResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PaginateProjectResponseBodyData Data { get; set; }
        public class PaginateProjectResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<PaginateProjectResponseBodyDataRecords> Records { get; set; }
            public class PaginateProjectResponseBodyDataRecords : TeaModel {
                public string Type { get; set; }
                public string ModifiedTime { get; set; }
                public string Description { get; set; }
                public string AggregateSceneCode { get; set; }
                public string CorpId { get; set; }
                public string UserId { get; set; }
                public string Icon { get; set; }
                public string Name { get; set; }
                public string CreatedTime { get; set; }
            }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
