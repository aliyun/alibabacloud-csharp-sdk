// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class GetLabelDetailResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLabelDetailResponseBodyData Data { get; set; }
        public class GetLabelDetailResponseBodyData : TeaModel {
            [NameInMap("LabelInfo")]
            [Validation(Required=false)]
            public string LabelInfo { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
