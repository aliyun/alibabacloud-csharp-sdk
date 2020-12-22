// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class GenerateVideoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateVideoResponseBodyData Data { get; set; }
        public class GenerateVideoResponseBodyData : TeaModel {
            [NameInMap("VideoCoverUrl")]
            [Validation(Required=false)]
            public string VideoCoverUrl { get; set; }
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }
        };

    }

}
