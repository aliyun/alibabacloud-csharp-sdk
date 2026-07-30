// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderCancelRequest : TeaModel {
        /// <summary>
        /// <para>The change order ID in Alibaba Business Travel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234223</para>
        /// </summary>
        [NameInMap("change_order_id")]
        [Validation(Required=false)]
        public string ChangeOrderId { get; set; }

        /// <summary>
        /// <para>The order ID in Alibaba Business Travel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002145190081005400</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The change order ID of the distributor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123321245534</para>
        /// </summary>
        [NameInMap("out_change_order_id")]
        [Validation(Required=false)]
        public string OutChangeOrderId { get; set; }

        /// <summary>
        /// <para>The order ID of the distributor.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

    }

}
