// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ComparePlaybooksRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("NewPlaybookReleaseId")]
        [Validation(Required=false)]
        public int? NewPlaybookReleaseId { get; set; }

        [NameInMap("OldPlaybookReleaseId")]
        [Validation(Required=false)]
        public int? OldPlaybookReleaseId { get; set; }

        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

    }

}
