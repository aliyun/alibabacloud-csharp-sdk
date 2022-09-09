// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListAuthorizationsResponseBody : TeaModel {
        [NameInMap("authorizations")]
        [Validation(Required=false)]
        public List<ListAuthorizationsResponseBodyAuthorizations> Authorizations { get; set; }
        public class ListAuthorizationsResponseBodyAuthorizations : TeaModel {
            [NameInMap("authorizationId")]
            [Validation(Required=false)]
            public string AuthorizationId { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("dueTime")]
            [Validation(Required=false)]
            public string DueTime { get; set; }

            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ownerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
