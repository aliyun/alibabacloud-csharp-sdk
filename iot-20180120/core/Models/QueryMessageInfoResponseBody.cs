// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryMessageInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public QueryMessageInfoResponseBodyMessage Message { get; set; }
        public class QueryMessageInfoResponseBodyMessage : TeaModel {
            [NameInMap("GenerateTime")]
            [Validation(Required=false)]
            public long? GenerateTime { get; set; }
            [NameInMap("MessageContent")]
            [Validation(Required=false)]
            public string MessageContent { get; set; }
            [NameInMap("TopicFullName")]
            [Validation(Required=false)]
            public string TopicFullName { get; set; }
            [NameInMap("UniMsgId")]
            [Validation(Required=false)]
            public string UniMsgId { get; set; }
            [NameInMap("UserProperties")]
            [Validation(Required=false)]
            public List<QueryMessageInfoResponseBodyMessageUserProperties> UserProperties { get; set; }
            public class QueryMessageInfoResponseBodyMessageUserProperties : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
