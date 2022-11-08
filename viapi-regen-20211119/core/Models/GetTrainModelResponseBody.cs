// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class GetTrainModelResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTrainModelResponseBodyData Data { get; set; }
        public class GetTrainModelResponseBodyData : TeaModel {
            [NameInMap("SimpleEvaluate")]
            [Validation(Required=false)]
            public long? SimpleEvaluate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
