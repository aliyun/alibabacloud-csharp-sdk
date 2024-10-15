// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderDetailInfoRequest : TeaModel {
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
