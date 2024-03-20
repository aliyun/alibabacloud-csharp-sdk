// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetTopicSubscribeStatusResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The subscription details.
        /// </summary>
        [NameInMap("TopicSubscribeStatus")]
        [Validation(Required=false)]
        public GetTopicSubscribeStatusResponseBodyTopicSubscribeStatus TopicSubscribeStatus { get; set; }
        public class GetTopicSubscribeStatusResponseBodyTopicSubscribeStatus : TeaModel {
            /// <summary>
            /// The groups that subscribe to the topic.
            /// </summary>
            [NameInMap("ConsumerGroups")]
            [Validation(Required=false)]
            public List<string> ConsumerGroups { get; set; }

            /// <summary>
            /// The topic name.
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

    }

}
