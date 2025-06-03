// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class RetrieveRunResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("run")]
        [Validation(Required=false)]
        public RetrieveRunResponseBodyRun Run { get; set; }
        public class RetrieveRunResponseBodyRun : TeaModel {
            [NameInMap("cancelledAt")]
            [Validation(Required=false)]
            public long? CancelledAt { get; set; }

            [NameInMap("completedAt")]
            [Validation(Required=false)]
            public long? CompletedAt { get; set; }

            [NameInMap("createAt")]
            [Validation(Required=false)]
            public long? CreateAt { get; set; }

            [NameInMap("expiresAt")]
            [Validation(Required=false)]
            public long? ExpiresAt { get; set; }

            [NameInMap("failedAt")]
            [Validation(Required=false)]
            public long? FailedAt { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("lastErrorMsg")]
            [Validation(Required=false)]
            public string LastErrorMsg { get; set; }

            [NameInMap("startedAt")]
            [Validation(Required=false)]
            public long? StartedAt { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("threadId")]
            [Validation(Required=false)]
            public string ThreadId { get; set; }

        }

    }

}
