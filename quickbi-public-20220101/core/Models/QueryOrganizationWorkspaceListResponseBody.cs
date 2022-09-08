// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryOrganizationWorkspaceListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryOrganizationWorkspaceListResponseBodyResult Result { get; set; }
        public class QueryOrganizationWorkspaceListResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryOrganizationWorkspaceListResponseBodyResultData> Data { get; set; }
            public class QueryOrganizationWorkspaceListResponseBodyResultData : TeaModel {
                [NameInMap("AllowPublishOperation")]
                [Validation(Required=false)]
                public bool? AllowPublishOperation { get; set; }

                [NameInMap("AllowShareOperation")]
                [Validation(Required=false)]
                public bool? AllowShareOperation { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                [NameInMap("CreateUserAccountName")]
                [Validation(Required=false)]
                public string CreateUserAccountName { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                [NameInMap("ModifyUserAccountName")]
                [Validation(Required=false)]
                public string ModifyUserAccountName { get; set; }

                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("OwnerAccountName")]
                [Validation(Required=false)]
                public string OwnerAccountName { get; set; }

                [NameInMap("WorkspaceDescription")]
                [Validation(Required=false)]
                public string WorkspaceDescription { get; set; }

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
