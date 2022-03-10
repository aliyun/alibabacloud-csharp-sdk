// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksByWorkspaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorksByWorkspaceResponseBodyResult Result { get; set; }
        public class QueryWorksByWorkspaceResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryWorksByWorkspaceResponseBodyResultData> Data { get; set; }
            public class QueryWorksByWorkspaceResponseBodyResultData : TeaModel {
                public int? Auth3rdFlag { get; set; }
                public string Description { get; set; }
                public QueryWorksByWorkspaceResponseBodyResultDataDirectory Directory { get; set; }
                public class QueryWorksByWorkspaceResponseBodyResultDataDirectory : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("PathId")]
                    [Validation(Required=false)]
                    public string PathId { get; set; }

                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                }
                public string GmtCreate { get; set; }
                public string GmtModify { get; set; }
                public string ModifyName { get; set; }
                public string OwnerId { get; set; }
                public string OwnerName { get; set; }
                public string SecurityLevel { get; set; }
                public int? Status { get; set; }
                public string WorkName { get; set; }
                public string WorkType { get; set; }
                public string WorksId { get; set; }
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
