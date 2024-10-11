// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class CreateClusterResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateClusterResponseBodyData Data { get; set; }
        public class CreateClusterResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cc-bp123bm6vy801****</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21154955706****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vw-uf6a499c0m3w5****</para>
            /// </summary>
            [NameInMap("VirtualWareHouseId")]
            [Validation(Required=false)]
            public string VirtualWareHouseId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F5178C10-1407-4987-9133-DE4DC9119F75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
