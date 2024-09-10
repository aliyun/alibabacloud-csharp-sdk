// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetHotelOrderDetailRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public GetHotelOrderDetailRequestPayload Payload { get; set; }
        public class GetHotelOrderDetailRequestPayload : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OrderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

        }

    }

}
