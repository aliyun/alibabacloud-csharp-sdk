// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class GetDiffCountLabelsetAndDatasetResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDiffCountLabelsetAndDatasetResponseBodyData Data { get; set; }
        public class GetDiffCountLabelsetAndDatasetResponseBodyData : TeaModel {
            [NameInMap("DiffCount")]
            [Validation(Required=false)]
            public long? DiffCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
