// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DebugPlaybookRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        [NameInMap("Record")]
        [Validation(Required=false)]
        public string Record { get; set; }

        [NameInMap("Taskflow")]
        [Validation(Required=false)]
        public string Taskflow { get; set; }

    }

}
