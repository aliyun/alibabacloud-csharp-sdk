// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Content : TeaModel {
        [NameInMap("MessageAttachments")]
        [Validation(Required=false)]
        public List<AguiMessage> MessageAttachments { get; set; }

        [NameInMap("QueryAttachments")]
        [Validation(Required=false)]
        public List<QueryAttachment> QueryAttachments { get; set; }

        [NameInMap("TextAttachments")]
        [Validation(Required=false)]
        public List<string> TextAttachments { get; set; }

    }

}
