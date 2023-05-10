// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class SendMessageRequest : TeaModel {
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public bool? Feedback { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("TextRequest")]
        [Validation(Required=false)]
        public SendMessageRequestTextRequest TextRequest { get; set; }
        public class SendMessageRequestTextRequest : TeaModel {
            [NameInMap("CommandType")]
            [Validation(Required=false)]
            public string CommandType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("SpeechText")]
            [Validation(Required=false)]
            public string SpeechText { get; set; }

            [NameInMap("interrupt")]
            [Validation(Required=false)]
            public bool? Interrupt { get; set; }

        }

        [NameInMap("VAMLRequest")]
        [Validation(Required=false)]
        public SendMessageRequestVAMLRequest VAMLRequest { get; set; }
        public class SendMessageRequestVAMLRequest : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Vaml")]
            [Validation(Required=false)]
            public string Vaml { get; set; }

        }

    }

}
