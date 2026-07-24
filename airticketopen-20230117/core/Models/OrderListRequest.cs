// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class OrderListRequest : TeaModel {
        /// <summary>
        /// <para>The query end time. The value is a 13-digit UNIX timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1677229006000</para>
        /// </summary>
        [NameInMap("book_time_end")]
        [Validation(Required=false)]
        public long? BookTimeEnd { get; set; }

        /// <summary>
        /// <para>The query start time. The value is a 13-digit UNIX timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1677229005000</para>
        /// </summary>
        [NameInMap("book_time_start")]
        [Validation(Required=false)]
        public long? BookTimeStart { get; set; }

        /// <summary>
        /// <para>The page index. The value starts from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_index")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The order status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>2: order creation succeeded.</description></item>
        /// <item><description>3: order paid.</description></item>
        /// <item><description>4: order succeeded.</description></item>
        /// <item><description>5: order closed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
