// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorkspaceUserListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorkspaceUserListResponseBodyResult Result { get; set; }
        public class QueryWorkspaceUserListResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryWorkspaceUserListResponseBodyResultData> Data { get; set; }
            public class QueryWorkspaceUserListResponseBodyResultData : TeaModel {
                public string AccountId { get; set; }
                public string AccountName { get; set; }
                public string NickName { get; set; }
                public QueryWorkspaceUserListResponseBodyResultDataRole Role { get; set; }
                public class QueryWorkspaceUserListResponseBodyResultDataRole : TeaModel {
                    [NameInMap("RoleCode")]
                    [Validation(Required=false)]
                    public string RoleCode { get; set; }

                    [NameInMap("RoleId")]
                    [Validation(Required=false)]
                    public long? RoleId { get; set; }

                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }
                public string UserId { get; set; }
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
