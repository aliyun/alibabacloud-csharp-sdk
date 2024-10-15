// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOrderPayRequest : TeaModel {
        [NameInMap("ext_params")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TRAVEL</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1002145190081005400</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F11372878673688133632</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15500</para>
        /// </summary>
        [NameInMap("total_price")]
        [Validation(Required=false)]
        public long? TotalPrice { get; set; }

    }

}
