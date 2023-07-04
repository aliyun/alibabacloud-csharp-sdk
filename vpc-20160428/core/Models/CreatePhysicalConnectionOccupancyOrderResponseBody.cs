// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePhysicalConnectionOccupancyOrderResponseBody : TeaModel {
        /// <summary>
        /// The details.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreatePhysicalConnectionOccupancyOrderResponseBodyData Data { get; set; }
        public class CreatePhysicalConnectionOccupancyOrderResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the order that is placed.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
