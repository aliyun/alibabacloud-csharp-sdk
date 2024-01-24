// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListQueueConsumersResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQueueConsumersResponseBodyData Data { get; set; }
        public class ListQueueConsumersResponseBodyData : TeaModel {
            /// <summary>
            /// The consumers.
            /// </summary>
            [NameInMap("Consumers")]
            [Validation(Required=false)]
            public List<ListQueueConsumersResponseBodyDataConsumers> Consumers { get; set; }
            public class ListQueueConsumersResponseBodyDataConsumers : TeaModel {
                /// <summary>
                /// The consumer tag.
                /// </summary>
                [NameInMap("ConsumerTag")]
                [Validation(Required=false)]
                public string ConsumerTag { get; set; }

            }

            /// <summary>
            /// The maximum number of entries returned.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The token that marks the end of the current returned page. If this parameter is empty, all data is retrieved.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
