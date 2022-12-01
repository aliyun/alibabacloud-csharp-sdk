// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class Aps : TeaModel {
        [NameInMap("alert")]
        [Validation(Required=false)]
        public Alert Alert { get; set; }

        [NameInMap("badge")]
        [Validation(Required=false)]
        public int? Badge { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("contentAvailable")]
        [Validation(Required=false)]
        public int? ContentAvailable { get; set; }

        [NameInMap("interruptionLevel")]
        [Validation(Required=false)]
        public string InterruptionLevel { get; set; }

        [NameInMap("sound")]
        [Validation(Required=false)]
        public string Sound { get; set; }

    }

}
