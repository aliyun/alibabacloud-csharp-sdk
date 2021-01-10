// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSPartitionsStoreLatencyHisResponseBody : TeaModel {
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
        public GetDWSPartitionsStoreLatencyHisResponseBodyData Data { get; set; }
        public class GetDWSPartitionsStoreLatencyHisResponseBodyData : TeaModel {
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }
            [NameInMap("Start")]
            [Validation(Required=false)]
            public long? Start { get; set; }
            [NameInMap("Dps")]
            [Validation(Required=false)]
            public List<GetDWSPartitionsStoreLatencyHisResponseBodyDataDps> Dps { get; set; }
            public class GetDWSPartitionsStoreLatencyHisResponseBodyDataDps : TeaModel {
                public long? Timestamp { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
