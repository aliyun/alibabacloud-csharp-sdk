// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchAddConsumerGroupConsumersResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. Ok is returned if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchAddConsumerGroupConsumersResponseBodyData Data { get; set; }
        public class BatchAddConsumerGroupConsumersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of consumer IDs that failed to be added.</para>
            /// </summary>
            [NameInMap("failedConsumerIds")]
            [Validation(Required=false)]
            public List<string> FailedConsumerIds { get; set; }

            /// <summary>
            /// <para>The list of consumer IDs that already exist in the consumer group and were skipped.</para>
            /// </summary>
            [NameInMap("skippedConsumerIds")]
            [Validation(Required=false)]
            public List<string> SkippedConsumerIds { get; set; }

            /// <summary>
            /// <para>The list of consumer IDs successfully added to the consumer group.</para>
            /// </summary>
            [NameInMap("successConsumerIds")]
            [Validation(Required=false)]
            public List<string> SuccessConsumerIds { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
