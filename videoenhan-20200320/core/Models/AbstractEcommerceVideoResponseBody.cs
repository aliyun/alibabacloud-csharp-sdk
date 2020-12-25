// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class AbstractEcommerceVideoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AbstractEcommerceVideoResponseBodyData Data { get; set; }
        public class AbstractEcommerceVideoResponseBodyData : TeaModel {
            [NameInMap("VideoCoverUrl")]
            [Validation(Required=false)]
            public string VideoCoverUrl { get; set; }
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }
        };

    }

}
