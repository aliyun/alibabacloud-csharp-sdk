// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarOrderQueryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the car service main order.</para>
        /// <remarks>
        /// <para>Specify either order_id or sub_order_id. If both are specified, order_id takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1012000000000000</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the car service sub-order.</para>
        /// <remarks>
        /// <para>Specify either order_id or sub_order_id. If both are specified, order_id takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("sub_order_id")]
        [Validation(Required=false)]
        public long? SubOrderId { get; set; }

    }

}
