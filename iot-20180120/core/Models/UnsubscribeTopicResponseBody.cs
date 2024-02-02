// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UnsubscribeTopicResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("FailureTopics")]
        [Validation(Required=false)]
        public UnsubscribeTopicResponseBodyFailureTopics FailureTopics { get; set; }
        public class UnsubscribeTopicResponseBodyFailureTopics : TeaModel {
            [NameInMap("topic")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Topic { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
