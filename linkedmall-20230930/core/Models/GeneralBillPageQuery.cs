// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class GeneralBillPageQuery : TeaModel {
        /// <summary>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// <para>billId</para>
        /// </summary>
        [NameInMap("billId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        /// <summary>
        /// <para>billPeriod</para>
        /// </summary>
        [NameInMap("billPeriod")]
        [Validation(Required=false)]
        public string BillPeriod { get; set; }

        /// <summary>
        /// <para>limit</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>orderBy</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>orderDirection</para>
        /// </summary>
        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <para>pageNumber</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>pageSize</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>shopId</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        /// <summary>
        /// <para>start</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

    }

}
