// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchAddConsumerGroupConsumersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchAddConsumerGroupConsumersResponseBodyData Data { get; set; }
        public class BatchAddConsumerGroupConsumersResponseBodyData : TeaModel {
            [NameInMap("failedConsumerIds")]
            [Validation(Required=false)]
            public List<string> FailedConsumerIds { get; set; }

            [NameInMap("skippedConsumerIds")]
            [Validation(Required=false)]
            public List<string> SkippedConsumerIds { get; set; }

            [NameInMap("successConsumerIds")]
            [Validation(Required=false)]
            public List<string> SuccessConsumerIds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
