// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListWarehousesResponseBody : TeaModel {
        [NameInMap("WarehouseList")]
        [Validation(Required=false)]
        public List<ListWarehousesResponseBodyWarehouseList> WarehouseList { get; set; }
        public class ListWarehousesResponseBodyWarehouseList : TeaModel {
            /// <summary>
            /// cpu
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            /// <summary>
            /// id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Mem")]
            [Validation(Required=false)]
            public long? Mem { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public long? NodeCount { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
