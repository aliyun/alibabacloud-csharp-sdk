// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class CreateMyBaseResponseBody : TeaModel {
        [NameInMap("OrderList")]
        [Validation(Required=false)]
        public CreateMyBaseResponseBodyOrderList OrderList { get; set; }
        public class CreateMyBaseResponseBodyOrderList : TeaModel {
            [NameInMap("OrderList")]
            [Validation(Required=false)]
            public List<CreateMyBaseResponseBodyOrderListOrderList> OrderList { get; set; }
            public class CreateMyBaseResponseBodyOrderListOrderList : TeaModel {
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("DedicatedHostGroupName")]
                [Validation(Required=false)]
                public string DedicatedHostGroupName { get; set; }

                [NameInMap("ECSInstanceIds")]
                [Validation(Required=false)]
                public string ECSInstanceIds { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
