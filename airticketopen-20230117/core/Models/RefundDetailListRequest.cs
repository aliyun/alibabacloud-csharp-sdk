// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundDetailListRequest : TeaModel {
        /// <summary>
        /// <para>order number returned by Book</para>
        /// 
        /// <b>Example:</b>
        /// <para>49884*****950</para>
        /// </summary>
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        /// <summary>
        /// <para>pagination query parameters, from which page to start querying</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_index")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>pagination query parameters, how many orders to return</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>the earliest time(timestamp) of refund order creation</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1677229002000</para>
        /// </summary>
        [NameInMap("refund_create_begin_time")]
        [Validation(Required=false)]
        public long? RefundCreateBeginTime { get; set; }

        /// <summary>
        /// <para>the latest time(timestamp) of refund order creation</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1677229005000</para>
        /// </summary>
        [NameInMap("refund_create_end_time")]
        [Validation(Required=false)]
        public long? RefundCreateEndTime { get; set; }

    }

}
