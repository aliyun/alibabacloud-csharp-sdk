// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class AndroidShortPayload : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public AndroidShortPayloadBody Body { get; set; }
        public class AndroidShortPayloadBody : TeaModel {
            [NameInMap("custom")]
            [Validation(Required=false)]
            public string Custom { get; set; }

        }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

    }

}
