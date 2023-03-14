// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class SplitVideoPartsAdvanceRequest : TeaModel {
        [NameInMap("MaxTime")]
        [Validation(Required=false)]
        public int? MaxTime { get; set; }

        [NameInMap("MinTime")]
        [Validation(Required=false)]
        public int? MinTime { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public Stream VideoUrlObject { get; set; }

    }

}
