// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class SendMessageShrinkRequest : TeaModel {
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("TextRequest")]
        [Validation(Required=false)]
        public string TextRequestShrink { get; set; }

        [NameInMap("VAMLRequest")]
        [Validation(Required=false)]
        public string VAMLRequestShrink { get; set; }

    }

}
