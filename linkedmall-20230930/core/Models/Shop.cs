// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Shop : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12***01</para>
        /// </summary>
        [NameInMap("cooperationShops")]
        [Validation(Required=false)]
        public List<CooperationShop> CooperationShops { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12****09</para>
        /// </summary>
        [NameInMap("distributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-09-09 00:00:00</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PID56****2304</para>
        /// </summary>
        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>48A34399-A72C-1E23-8388-7E63****E927</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22****09</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>儿童分销店铺</para>
        /// </summary>
        [NameInMap("shopName")]
        [Validation(Required=false)]
        public string ShopName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DistributorQYG</para>
        /// </summary>
        [NameInMap("shopType")]
        [Validation(Required=false)]
        public string ShopType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-09-09 00:00:00</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Working</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
