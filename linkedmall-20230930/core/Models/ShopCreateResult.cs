// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ShopCreateResult : TeaModel {
        /// <summary>
        /// <para>The store ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        /// <summary>
        /// <para>The store status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WORKING</para>
        /// </summary>
        [NameInMap("shopStatus")]
        [Validation(Required=false)]
        public string ShopStatus { get; set; }

    }

}
