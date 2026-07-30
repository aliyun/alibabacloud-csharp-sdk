// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightPayOrderV2Request : TeaModel {
        /// <summary>
        /// <para>The custom channel name defined by the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The business travel order ID. Either the external order ID or the business travel order ID is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234234</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The external order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195798359400</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The total ticket price, excluding service fees.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5100</para>
        /// </summary>
        [NameInMap("total_price")]
        [Validation(Required=false)]
        public long? TotalPrice { get; set; }

        /// <summary>
        /// <para>The total service fee. Unit: cents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total_service_fee_price")]
        [Validation(Required=false)]
        public long? TotalServiceFeePrice { get; set; }

    }

}
