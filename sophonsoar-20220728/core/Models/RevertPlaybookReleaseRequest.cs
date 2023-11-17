// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class RevertPlaybookReleaseRequest : TeaModel {
        [NameInMap("IsPublish")]
        [Validation(Required=false)]
        public bool? IsPublish { get; set; }

        [NameInMap("PlayReleaseId")]
        [Validation(Required=false)]
        public int? PlayReleaseId { get; set; }

        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

    }

}
