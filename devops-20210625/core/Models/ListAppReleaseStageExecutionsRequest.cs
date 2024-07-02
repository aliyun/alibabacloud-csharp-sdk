// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListAppReleaseStageExecutionsRequest : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("pagination")]
        [Validation(Required=false)]
        public string Pagination { get; set; }

        [NameInMap("perPage")]
        [Validation(Required=false)]
        public int? PerPage { get; set; }

        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}
