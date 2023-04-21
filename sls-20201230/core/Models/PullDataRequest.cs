// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PullDataRequest : TeaModel {
        [NameInMap("count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        [NameInMap("endCursor")]
        [Validation(Required=false)]
        public string EndCursor { get; set; }

    }

}
