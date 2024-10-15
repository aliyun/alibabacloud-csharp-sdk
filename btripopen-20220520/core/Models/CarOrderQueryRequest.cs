// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarOrderQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1012000000000000</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("sub_order_id")]
        [Validation(Required=false)]
        public long? SubOrderId { get; set; }

    }

}
