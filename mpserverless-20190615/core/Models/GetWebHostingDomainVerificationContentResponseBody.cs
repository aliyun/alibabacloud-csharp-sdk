// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class GetWebHostingDomainVerificationContentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWebHostingDomainVerificationContentResponseBodyData Data { get; set; }
        public class GetWebHostingDomainVerificationContentResponseBodyData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }
        };

    }

}
