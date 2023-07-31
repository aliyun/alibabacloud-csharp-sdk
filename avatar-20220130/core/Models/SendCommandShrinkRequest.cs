// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class SendCommandShrinkRequest : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public bool? Feedback { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("UniqueCode")]
        [Validation(Required=false)]
        public string UniqueCode { get; set; }

    }

}
