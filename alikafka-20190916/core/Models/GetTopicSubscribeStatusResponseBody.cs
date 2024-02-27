// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetTopicSubscribeStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TopicSubscribeStatus")]
        [Validation(Required=false)]
        public GetTopicSubscribeStatusResponseBodyTopicSubscribeStatus TopicSubscribeStatus { get; set; }
        public class GetTopicSubscribeStatusResponseBodyTopicSubscribeStatus : TeaModel {
            [NameInMap("ConsumerGroups")]
            [Validation(Required=false)]
            public List<string> ConsumerGroups { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

    }

}
