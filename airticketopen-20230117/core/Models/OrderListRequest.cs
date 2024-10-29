// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class OrderListRequest : TeaModel {
        /// <summary>
        /// <para>latest booking time (timestamp)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-02 11:20:00</para>
        /// </summary>
        [NameInMap("book_time_end")]
        [Validation(Required=false)]
        public long? BookTimeEnd { get; set; }

        /// <summary>
        /// <para>earliest book time(timestamp)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-01 11:20:00</para>
        /// </summary>
        [NameInMap("book_time_start")]
        [Validation(Required=false)]
        public long? BookTimeStart { get; set; }

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
        /// <para>which order status will be query</para>
        /// <para>1: order reservation in process</para>
        /// <para>2: order reservation successful</para>
        /// <para>3: order paid</para>
        /// <para>4: order successful</para>
        /// <para>5: order closed</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
