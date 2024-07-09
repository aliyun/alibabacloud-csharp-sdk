// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListChangeRequestWorkflowExecutionsRequest : TeaModel {
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("perPage")]
        [Validation(Required=false)]
        public long? PerPage { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("releaseStageSn")]
        [Validation(Required=false)]
        public string ReleaseStageSn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("releaseWorkflowSn")]
        [Validation(Required=false)]
        public string ReleaseWorkflowSn { get; set; }

        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}
