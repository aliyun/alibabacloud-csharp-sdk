// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ConversationCreateCmd : TeaModel {
        [NameInMap("chatData")]
        [Validation(Required=false)]
        public string ChatData { get; set; }

        [NameInMap("modelIds")]
        [Validation(Required=false)]
        public string ModelIds { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
