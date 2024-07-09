// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListChangeRequestsShrinkRequest : TeaModel {
        [NameInMap("appNameList")]
        [Validation(Required=false)]
        public string AppNameListShrink { get; set; }

        [NameInMap("displayNameKeyword")]
        [Validation(Required=false)]
        public string DisplayNameKeyword { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("ownerIdList")]
        [Validation(Required=false)]
        public string OwnerIdListShrink { get; set; }

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

        [NameInMap("stateList")]
        [Validation(Required=false)]
        public string StateListShrink { get; set; }

    }

}
