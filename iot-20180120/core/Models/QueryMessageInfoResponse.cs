// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryMessageInfoResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public QueryMessageInfoResponseMessage Message { get; set; }
        public class QueryMessageInfoResponseMessage : TeaModel {
            [NameInMap("GenerateTime")]
            [Validation(Required=true)]
            public long? GenerateTime { get; set; }

            [NameInMap("MessageContent")]
            [Validation(Required=true)]
            public string MessageContent { get; set; }

            [NameInMap("TopicFullName")]
            [Validation(Required=true)]
            public string TopicFullName { get; set; }

            [NameInMap("UniMsgId")]
            [Validation(Required=true)]
            public string UniMsgId { get; set; }

            [NameInMap("UserProperties")]
            [Validation(Required=true)]
            public List<QueryMessageInfoResponseMessageUserProperties> UserProperties { get; set; }
            public class QueryMessageInfoResponseMessageUserProperties : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=true)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=true)]
                public string Value { get; set; }

            }

        }

    }

}
