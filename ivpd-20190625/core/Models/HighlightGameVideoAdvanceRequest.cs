// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class HighlightGameVideoAdvanceRequest : TeaModel {
        [NameInMap("VideoUrlObject")]
        [Validation(Required=true)]
        public Stream VideoUrlObject { get; set; }

        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

    }

}
