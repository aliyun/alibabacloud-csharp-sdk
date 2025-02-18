// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ShopCreateResult : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WORKING</para>
        /// </summary>
        [NameInMap("shopStatus")]
        [Validation(Required=false)]
        public string ShopStatus { get; set; }

    }

}
