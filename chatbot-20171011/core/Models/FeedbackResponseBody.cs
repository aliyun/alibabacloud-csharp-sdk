// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class FeedbackResponseBody : TeaModel {
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        [NameInMap("HttpStatus")]
        [Validation(Required=false)]
        public long? HttpStatus { get; set; }

        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
