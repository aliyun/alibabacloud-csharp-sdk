// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class GetWebHostingConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWebHostingConfigResponseBodyData Data { get; set; }
        public class GetWebHostingConfigResponseBodyData : TeaModel {
            [NameInMap("SpaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }
            [NameInMap("AllowedIps")]
            [Validation(Required=false)]
            public string AllowedIps { get; set; }
            [NameInMap("ErrorPath")]
            [Validation(Required=false)]
            public string ErrorPath { get; set; }
            [NameInMap("DefaultDomain")]
            [Validation(Required=false)]
            public string DefaultDomain { get; set; }
            [NameInMap("IndexPath")]
            [Validation(Required=false)]
            public string IndexPath { get; set; }
        };

    }

}
