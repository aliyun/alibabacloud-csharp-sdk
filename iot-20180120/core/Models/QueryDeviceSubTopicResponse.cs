// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceSubTopicResponse : TeaModel {
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

        [NameInMap("TopicList")]
        [Validation(Required=true)]
        public List<QueryDeviceSubTopicResponseTopicList> TopicList { get; set; }
        public class QueryDeviceSubTopicResponseTopicList : TeaModel {
            [NameInMap("Timestamp")]
            [Validation(Required=true)]
            public long? Timestamp { get; set; }

            [NameInMap("TopicName")]
            [Validation(Required=true)]
            public string TopicName { get; set; }

        }

    }

}
