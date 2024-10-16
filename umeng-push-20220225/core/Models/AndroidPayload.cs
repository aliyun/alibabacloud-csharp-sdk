// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class AndroidPayload : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public Body Body { get; set; }

        [NameInMap("displayType")]
        [Validation(Required=false)]
        public string DisplayType { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

        [NameInMap("message2ThirdChannel")]
        [Validation(Required=false)]
        public Message2ThirdChannel Message2ThirdChannel { get; set; }

    }

}
