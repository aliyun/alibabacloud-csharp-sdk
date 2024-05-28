// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListMergeRequestsRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("authorIds")]
        [Validation(Required=false)]
        public string AuthorIds { get; set; }

        [NameInMap("createdAfter")]
        [Validation(Required=false)]
        public string CreatedAfter { get; set; }

        [NameInMap("createdBefore")]
        [Validation(Required=false)]
        public string CreatedBefore { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        [NameInMap("groupIds")]
        [Validation(Required=false)]
        public string GroupIds { get; set; }

        [NameInMap("labelIds")]
        [Validation(Required=false)]
        public string LabelIds { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("projectIds")]
        [Validation(Required=false)]
        public string ProjectIds { get; set; }

        [NameInMap("reviewerIds")]
        [Validation(Required=false)]
        public string ReviewerIds { get; set; }

        [NameInMap("search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
