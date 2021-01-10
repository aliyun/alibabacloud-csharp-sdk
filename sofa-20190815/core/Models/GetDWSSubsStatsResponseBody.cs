// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSSubsStatsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDWSSubsStatsResponseBodyData Data { get; set; }
        public class GetDWSSubsStatsResponseBodyData : TeaModel {
            [NameInMap("Exception")]
            [Validation(Required=false)]
            public long? Exception { get; set; }
            [NameInMap("Initializing")]
            [Validation(Required=false)]
            public long? Initializing { get; set; }
            [NameInMap("Running")]
            [Validation(Required=false)]
            public long? Running { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Unsubscribe")]
            [Validation(Required=false)]
            public long? Unsubscribe { get; set; }
            [NameInMap("Waiting")]
            [Validation(Required=false)]
            public long? Waiting { get; set; }
        };

    }

}
