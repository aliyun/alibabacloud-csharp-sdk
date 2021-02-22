// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageseg20191230.Models
{
    public class RefineMaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RefineMaskResponseBodyData Data { get; set; }
        public class RefineMaskResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RefineMaskResponseBodyDataElements> Elements { get; set; }
            public class RefineMaskResponseBodyDataElements : TeaModel {
                public string ImageURL { get; set; }
            }
        };

    }

}
