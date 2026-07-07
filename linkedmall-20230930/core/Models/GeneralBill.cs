// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class GeneralBill : TeaModel {
        /// <summary>
        /// <para>bill ID</para>
        /// </summary>
        [NameInMap("billId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        /// <summary>
        /// <para>billing cycle</para>
        /// </summary>
        [NameInMap("billPeriod")]
        [Validation(Required=false)]
        public string BillPeriod { get; set; }

        /// <summary>
        /// <para>download URL for details</para>
        /// </summary>
        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public List<string> DownloadUrl { get; set; }

        /// <summary>
        /// <para>billing cycle End Time</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>bill Creation Time</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>bill Updated At</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>shop ID</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        /// <summary>
        /// <para>shop Name</para>
        /// </summary>
        [NameInMap("shopName")]
        [Validation(Required=false)]
        public string ShopName { get; set; }

        /// <summary>
        /// <para>billing cycle Start Time</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public Money TotalAmount { get; set; }

    }

}
