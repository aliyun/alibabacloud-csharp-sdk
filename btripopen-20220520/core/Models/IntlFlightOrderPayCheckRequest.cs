// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOrderPayCheckRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ZHANG/SAN</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TRAVEL</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002094194679957528</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F11374007131319304192</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

    }

}
