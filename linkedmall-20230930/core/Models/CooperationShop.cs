// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class CooperationShop : TeaModel {
        /// <summary>
        /// <para>The partner company ID.</para>
        /// </summary>
        [NameInMap("cooperationCompanyId")]
        [Validation(Required=false)]
        public string CooperationCompanyId { get; set; }

        /// <summary>
        /// <para>The partner shop ID.</para>
        /// </summary>
        [NameInMap("cooperationShopId")]
        [Validation(Required=false)]
        public string CooperationShopId { get; set; }

        /// <summary>
        /// <para>The shop ID.</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

    }

}
