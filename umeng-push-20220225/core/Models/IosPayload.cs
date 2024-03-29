// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class IosPayload : TeaModel {
        [NameInMap("aps")]
        [Validation(Required=false)]
        public Aps Aps { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

    }

}
