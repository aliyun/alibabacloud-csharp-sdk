// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDiskSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the order. You can obtain the order ID on the <a href="https://usercenter2-intl.aliyun.com/order/list?pageIndex=1%5C&pageSize=20%5C&spm=5176.12818093.top-nav.ditem-ord.36f016d0OQFmJa">Orders</a> page in Alibaba Cloud User Center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>219861020660568</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F89BBB13-8B3B-5C8A-A700-EEFDC17B8227</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
