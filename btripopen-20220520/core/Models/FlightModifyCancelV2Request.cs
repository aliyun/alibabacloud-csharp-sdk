// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyCancelV2Request : TeaModel {
        /// <summary>
        /// <para>The custom channel name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The business travel order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195370467200</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The distribution external order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195370467200</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The distribution external sub-order ID (rebooking).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1019195786853020</para>
        /// </summary>
        [NameInMap("out_sub_order_id")]
        [Validation(Required=false)]
        public string OutSubOrderId { get; set; }

        /// <summary>
        /// <para>The business travel sub-order ID (rebooking sales order ID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1019195786853020</para>
        /// </summary>
        [NameInMap("sub_order_id")]
        [Validation(Required=false)]
        public long? SubOrderId { get; set; }

    }

}
