// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetMobileResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GetMobileResultDTO")]
        [Validation(Required=false)]
        public GetMobileResponseBodyGetMobileResultDTO GetMobileResultDTO { get; set; }
        public class GetMobileResponseBodyGetMobileResultDTO : TeaModel {
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
