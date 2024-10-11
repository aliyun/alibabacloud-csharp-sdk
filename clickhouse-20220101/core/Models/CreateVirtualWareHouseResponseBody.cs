// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class CreateVirtualWareHouseResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateVirtualWareHouseResponseBodyData Data { get; set; }
        public class CreateVirtualWareHouseResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>21155221661****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vw-bp1w2728d535t****</para>
            /// </summary>
            [NameInMap("VirtualWareHouseId")]
            [Validation(Required=false)]
            public string VirtualWareHouseId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627FA5A19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
