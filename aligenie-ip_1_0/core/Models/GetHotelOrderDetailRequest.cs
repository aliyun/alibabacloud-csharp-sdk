// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetHotelOrderDetailRequest : TeaModel {
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public GetHotelOrderDetailRequestPayload Payload { get; set; }
        public class GetHotelOrderDetailRequestPayload : TeaModel {
            [NameInMap("OrderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }
        };

    }

}
