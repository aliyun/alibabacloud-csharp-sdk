// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightRefundConsultRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002145190081005400</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3753197470069161984</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

    }

}
