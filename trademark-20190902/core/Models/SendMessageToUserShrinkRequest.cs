// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class SendMessageToUserShrinkRequest : TeaModel {
        [NameInMap("ReceiverNickName")]
        [Validation(Required=false)]
        public string ReceiverNickName { get; set; }

        [NameInMap("SenderNickName")]
        [Validation(Required=false)]
        public string SenderNickName { get; set; }

        [NameInMap("TemplateData")]
        [Validation(Required=false)]
        public string TemplateDataShrink { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
