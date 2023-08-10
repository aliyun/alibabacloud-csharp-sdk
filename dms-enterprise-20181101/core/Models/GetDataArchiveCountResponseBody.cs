// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataArchiveCountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataArchiveCountResponseBodyData Data { get; set; }
        public class GetDataArchiveCountResponseBodyData : TeaModel {
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            [NameInMap("ProcessingCount")]
            [Validation(Required=false)]
            public long? ProcessingCount { get; set; }

            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
