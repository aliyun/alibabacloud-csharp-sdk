// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDTXGlobalStatsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDTXGlobalStatsResponseBodyData Data { get; set; }
        public class GetDTXGlobalStatsResponseBodyData : TeaModel {
            [NameInMap("Activity")]
            [Validation(Required=false)]
            public long? Activity { get; set; }
            [NameInMap("Exception")]
            [Validation(Required=false)]
            public long? Exception { get; set; }
            [NameInMap("Today")]
            [Validation(Required=false)]
            public long? Today { get; set; }
        };

    }

}
