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
                [NameInMap("Favorite")]
                [Validation(Required=false)]
                public bool? Favorite { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("HasEditAuth")]
                [Validation(Required=false)]
                public bool? HasEditAuth { get; set; }

                [NameInMap("HasViewAuth")]
                [Validation(Required=false)]
                public bool? HasViewAuth { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                [NameInMap("OwnerNum")]
                [Validation(Required=false)]
                public string OwnerNum { get; set; }

                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public int? PublishStatus { get; set; }

                [NameInMap("TreeId")]
                [Validation(Required=false)]
                public string TreeId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
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

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
