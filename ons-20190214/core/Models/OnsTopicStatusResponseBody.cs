// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicStatusResponseBody : TeaModel {
        /// <summary>
        /// The data structure of the queried topic.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTopicStatusResponseBodyData Data { get; set; }
        public class OnsTopicStatusResponseBodyData : TeaModel {
            /// <summary>
            /// The point in time when the latest message is ready in the topic. If no message exists in the topic, the return value of this parameter is 0.
            /// 
            /// The value of this parameter is a UNIX timestamp in milliseconds.
            /// 
            /// For information about the definition of ready messages and ready time, see [Terms](~~29533~~).
            /// </summary>
            [NameInMap("LastTimeStamp")]
            [Validation(Required=false)]
            public long? LastTimeStamp { get; set; }

            /// <summary>
            /// Indicates the operations that you can perform on the topic. Valid values:
            /// 
            /// *   **2**: You can publish messages to the topic.
            /// *   **4**: You can subscribe to the topic.
            /// *   **6**: You can publish messages to and subscribe to the topic.
            /// </summary>
            [NameInMap("Perm")]
            [Validation(Required=false)]
            public int? Perm { get; set; }

            /// <summary>
            /// The total number of messages in all partitions of the topic.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
