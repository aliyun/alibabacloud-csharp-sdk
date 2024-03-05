// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class CheckSelectedDomainStatusResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public CheckSelectedDomainStatusResponseBodyModule Module { get; set; }
        public class CheckSelectedDomainStatusResponseBodyModule : TeaModel {
            [NameInMap("DeadDate")]
            [Validation(Required=false)]
            public long? DeadDate { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Premium")]
            [Validation(Required=false)]
            public bool? Premium { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public double? Price { get; set; }

            [NameInMap("RegDate")]
            [Validation(Required=false)]
            public long? RegDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
