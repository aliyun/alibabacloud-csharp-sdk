// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class RequestParamsUserConversationsValue : TeaModel {
        [NameInMap("Top")]
        [Validation(Required=false)]
        public bool? Top { get; set; }

        [NameInMap("RedPoint")]
        [Validation(Required=false)]
        public long? RedPoint { get; set; }

        [NameInMap("Mute")]
        [Validation(Required=false)]
        public bool? Mute { get; set; }

        [NameInMap("Visible")]
        [Validation(Required=false)]
        public bool? Visible { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        [NameInMap("UserExtensions")]
        [Validation(Required=false)]
        public Dictionary<string, string> UserExtensions { get; set; }

    }

}
