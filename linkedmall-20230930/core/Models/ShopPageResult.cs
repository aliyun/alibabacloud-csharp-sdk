// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ShopPageResult : TeaModel {
        /// <summary>
        /// <para>API request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>841471F6-5D61-1331-8C38-2****B55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Shop collection</para>
        /// </summary>
        [NameInMap("shopList")]
        [Validation(Required=false)]
        public List<ShopPageDataResult> ShopList { get; set; }

        /// <summary>
        /// <para>Total count</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
