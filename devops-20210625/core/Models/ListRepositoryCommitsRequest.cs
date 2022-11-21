// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListRepositoryCommitsRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("end")]
        [Validation(Required=false)]
        public string End { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("refName")]
        [Validation(Required=false)]
        public string RefName { get; set; }

        [NameInMap("search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        [NameInMap("showCommentsCount")]
        [Validation(Required=false)]
        public bool? ShowCommentsCount { get; set; }

        [NameInMap("showSignature")]
        [Validation(Required=false)]
        public bool? ShowSignature { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public string Start { get; set; }

    }

}
