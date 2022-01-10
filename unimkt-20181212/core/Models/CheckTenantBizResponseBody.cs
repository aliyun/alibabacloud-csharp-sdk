// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class CheckTenantBizResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public CheckTenantBizResponseBodyModel Model { get; set; }
        public class CheckTenantBizResponseBodyModel : TeaModel {
            [NameInMap("CanAccessAdSlot")]
            [Validation(Required=false)]
            public bool? CanAccessAdSlot { get; set; }
            [NameInMap("CanAccessMedia")]
            [Validation(Required=false)]
            public bool? CanAccessMedia { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
