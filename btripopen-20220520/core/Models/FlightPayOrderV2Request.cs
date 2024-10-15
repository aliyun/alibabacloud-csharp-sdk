// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightPayOrderV2Request : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cheshiapi</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cheshiapi002kwl</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1017002195798359400</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5100</para>
        /// </summary>
        [NameInMap("total_price")]
        [Validation(Required=false)]
        public long? TotalPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total_service_fee_price")]
        [Validation(Required=false)]
        public long? TotalServiceFeePrice { get; set; }

    }

}
