// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class GetTrainTaskEstimatedTimeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTrainTaskEstimatedTimeResponseBodyData Data { get; set; }
        public class GetTrainTaskEstimatedTimeResponseBodyData : TeaModel {
            [NameInMap("EstimatedTime")]
            [Validation(Required=false)]
            public string EstimatedTime { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
