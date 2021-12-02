// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class SwapFacialFeaturesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SwapFacialFeaturesResponseBodyData Data { get; set; }
        public class SwapFacialFeaturesResponseBodyData : TeaModel {
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
