// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210218.Models
{
    public class GetAuthCodeResponseBody : TeaModel {
        [NameInMap("AuthModel")]
        [Validation(Required=false)]
        public GetAuthCodeResponseBodyAuthModel AuthModel { get; set; }
        public class GetAuthCodeResponseBodyAuthModel : TeaModel {
            [NameInMap("AuthCode")]
            [Validation(Required=false)]
            public string AuthCode { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
