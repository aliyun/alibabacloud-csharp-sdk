// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class SearchBodyResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchBodyResponseBodyData Data { get; set; }
        public class SearchBodyResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<SearchBodyResponseBodyDataRecords> Records { get; set; }
            public class SearchBodyResponseBodyDataRecords : TeaModel {
                public string GbId { get; set; }
                public string TargetImageUrl { get; set; }
                public float? RightBottomY { get; set; }
                public string ImageUrl { get; set; }
                public float? LeftTopY { get; set; }
                public float? Score { get; set; }
                public float? LeftTopX { get; set; }
                public float? RightBottomX { get; set; }
            }
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }
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
