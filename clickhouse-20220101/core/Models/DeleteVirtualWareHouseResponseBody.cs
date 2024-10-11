// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class DeleteVirtualWareHouseResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteVirtualWareHouseResponseBodyData Data { get; set; }
        public class DeleteVirtualWareHouseResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>21152153510****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D0CEC6AC-7760-409A-A0D5-E6CD8660E9CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
