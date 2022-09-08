// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QuerySharesToUserListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QuerySharesToUserListResponseBodyResult> Result { get; set; }
        public class QuerySharesToUserListResponseBodyResult : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QuerySharesToUserListResponseBodyResultDirectory Directory { get; set; }
            public class QuerySharesToUserListResponseBodyResultDirectory : TeaModel {
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

            [NameInMap("ModifyName")]
            [Validation(Required=false)]
            public string ModifyName { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public string SecurityLevel { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("ThirdPartAuthFlag")]
            [Validation(Required=false)]
            public int? ThirdPartAuthFlag { get; set; }

            [NameInMap("WorkName")]
            [Validation(Required=false)]
            public string WorkName { get; set; }

            [NameInMap("WorkType")]
            [Validation(Required=false)]
            public string WorkType { get; set; }

            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
