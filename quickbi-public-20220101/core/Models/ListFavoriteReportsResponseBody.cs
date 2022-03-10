// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListFavoriteReportsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListFavoriteReportsResponseBodyResult Result { get; set; }
        public class ListFavoriteReportsResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListFavoriteReportsResponseBodyResultData> Data { get; set; }
            public class ListFavoriteReportsResponseBodyResultData : TeaModel {
                public bool? Favorite { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public bool? HasEditAuth { get; set; }
                public bool? HasViewAuth { get; set; }
                public string Name { get; set; }
                public string OwnerName { get; set; }
                public string OwnerNum { get; set; }
                public int? PublishStatus { get; set; }
                public string TreeId { get; set; }
                public string Type { get; set; }
                public string WorkspaceId { get; set; }
                public string WorkspaceName { get; set; }
            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
