// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class QueryProductQuotaPageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2oImhCz4f8XCviiM</para>
        /// </summary>
        [NameInMap("productKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-04-01 00:00:00</para>
        /// </summary>
        [NameInMap("purchaseTimeEnd")]
        [Validation(Required=false)]
        public string PurchaseTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-03-01 00:00:00</para>
        /// </summary>
        [NameInMap("purchaseTimeStart")]
        [Validation(Required=false)]
        public string PurchaseTimeStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("purchaseType")]
        [Validation(Required=false)]
        public int? PurchaseType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>628103740287873</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
