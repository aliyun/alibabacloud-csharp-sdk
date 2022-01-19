// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class JyGetMobileResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GetMobileResultData")]
        [Validation(Required=false)]
        public JyGetMobileResponseBodyGetMobileResultData GetMobileResultData { get; set; }
        public class JyGetMobileResponseBodyGetMobileResultData : TeaModel {
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
