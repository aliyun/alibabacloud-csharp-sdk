// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class DoIotRechargeResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IotRecharge")]
        [Validation(Required=false)]
        public DoIotRechargeResponseBodyIotRecharge IotRecharge { get; set; }
        public class DoIotRechargeResponseBodyIotRecharge : TeaModel {
            [NameInMap("OrderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }
            [NameInMap("DoneCode")]
            [Validation(Required=false)]
            public string DoneCode { get; set; }
            [NameInMap("OrderResult")]
            [Validation(Required=false)]
            public string OrderResult { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
