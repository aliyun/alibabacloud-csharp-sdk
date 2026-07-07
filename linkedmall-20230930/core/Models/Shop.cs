// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Shop : TeaModel {
        /// <summary>
        /// <para>The partner shops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12***01</para>
        /// </summary>
        [NameInMap("cooperationShops")]
        [Validation(Required=false)]
        public List<CooperationShop> CooperationShops { get; set; }

        /// <summary>
        /// <para>The ID of the distributor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****09</para>
        /// </summary>
        [NameInMap("distributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-11T12:22:24.000+08:00</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The ID of the purchaser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PID56****2304</para>
        /// </summary>
        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48A34399-A72C-1E23-8388-7E63****E927</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the shop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22****09</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        /// <summary>
        /// <para>The name of the shop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>儿童分销店铺</para>
        /// </summary>
        [NameInMap("shopName")]
        [Validation(Required=false)]
        public string ShopName { get; set; }

        /// <summary>
        /// <para>The type of the shop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DistributorQYG</para>
        /// </summary>
        [NameInMap("shopType")]
        [Validation(Required=false)]
        public string ShopType { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-11T12:22:24.000+08:00</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The status of the shop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Working</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
