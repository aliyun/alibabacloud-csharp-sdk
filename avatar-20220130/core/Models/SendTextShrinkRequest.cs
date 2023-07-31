// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class SendTextShrinkRequest : TeaModel {
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public bool? Feedback { get; set; }

        [NameInMap("Interrupt")]
        [Validation(Required=false)]
        public bool? Interrupt { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("StreamExtension")]
        [Validation(Required=false)]
        public string StreamExtensionShrink { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("UniqueCode")]
        [Validation(Required=false)]
        public string UniqueCode { get; set; }

    }

}
