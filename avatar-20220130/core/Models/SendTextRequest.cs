// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class SendTextRequest : TeaModel {
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
        public SendTextRequestStreamExtension StreamExtension { get; set; }
        public class SendTextRequestStreamExtension : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("IsStream")]
            [Validation(Required=false)]
            public bool? IsStream { get; set; }

            [NameInMap("Position")]
            [Validation(Required=false)]
            public string Position { get; set; }

        }

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
