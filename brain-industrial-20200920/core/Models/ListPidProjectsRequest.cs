// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListPidProjectsRequest : TeaModel {
        [NameInMap("PidProjectName")]
        [Validation(Required=false)]
        public string PidProjectName { get; set; }

        [NameInMap("PidOrganisationId")]
        [Validation(Required=false)]
        public string PidOrganisationId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

    }

}
