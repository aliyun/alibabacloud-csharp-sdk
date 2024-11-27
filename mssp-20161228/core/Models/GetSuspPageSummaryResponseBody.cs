// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetSuspPageSummaryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSuspPageSummaryResponseBodyData Data { get; set; }
        public class GetSuspPageSummaryResponseBodyData : TeaModel {
            [NameInMap("CompletedCount")]
            [Validation(Required=false)]
            public long? CompletedCount { get; set; }

            [NameInMap("HandingCount")]
            [Validation(Required=false)]
            public long? HandingCount { get; set; }

            [NameInMap("HighCount")]
            [Validation(Required=false)]
            public long? HighCount { get; set; }

            [NameInMap("LowCount")]
            [Validation(Required=false)]
            public long? LowCount { get; set; }

            [NameInMap("MediumCount")]
            [Validation(Required=false)]
            public long? MediumCount { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("WaitHandleCount")]
            [Validation(Required=false)]
            public long? WaitHandleCount { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
