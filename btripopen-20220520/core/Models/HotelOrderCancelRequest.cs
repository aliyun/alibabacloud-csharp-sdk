// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderCancelRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1002202194207077022</para>
        /// </summary>
        [NameInMap("btrip_order_id")]
        [Validation(Required=false)]
        public string BtripOrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

    }

}
