// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class GetBusAppConfigResponseBody : TeaModel {
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

        [NameInMap("RetMsg")]
        [Validation(Required=false)]
        public string RetMsg { get; set; }

        [NameInMap("RetValue")]
        [Validation(Required=false)]
        public GetBusAppConfigResponseBodyRetValue RetValue { get; set; }
        public class GetBusAppConfigResponseBodyRetValue : TeaModel {
            [NameInMap("Cashier")]
            [Validation(Required=false)]
            public string Cashier { get; set; }

            [NameInMap("ShoppingBar")]
            [Validation(Required=false)]
            public string ShoppingBar { get; set; }

            [NameInMap("ShoppingWindow")]
            [Validation(Required=false)]
            public string ShoppingWindow { get; set; }

            [NameInMap("VipLabel")]
            [Validation(Required=false)]
            public string VipLabel { get; set; }

        }

    }

}
