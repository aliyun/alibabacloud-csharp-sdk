// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetAKSPlanStatesResponseBody : TeaModel {
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
        public List<GetAKSPlanStatesResponseBodyData> Data { get; set; }
        public class GetAKSPlanStatesResponseBodyData : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public GetAKSPlanStatesResponseBodyDataValue Value { get; set; }
            public class GetAKSPlanStatesResponseBodyDataValue : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }
            };

        }

    }

}
