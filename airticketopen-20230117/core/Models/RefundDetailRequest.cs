// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundDetailRequest : TeaModel {
        /// <summary>
        /// <para>Refund order number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4966***617732</para>
        /// </summary>
        [NameInMap("refund_order_num")]
        [Validation(Required=false)]
        public long? RefundOrderNum { get; set; }

    }

}
