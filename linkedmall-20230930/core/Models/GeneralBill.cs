// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class GeneralBill : TeaModel {
        /// <summary>
        /// <para>The bill ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bill_demo_001</para>
        /// </summary>
        [NameInMap("billId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        /// <summary>
        /// <para>The billing cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08</para>
        /// </summary>
        [NameInMap("billPeriod")]
        [Validation(Required=false)]
        public string BillPeriod { get; set; }

        /// <summary>
        /// <para>The details download URL.</para>
        /// </summary>
        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public List<string> DownloadUrl { get; set; }

        /// <summary>
        /// <para>The end time of the billing cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The bill creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The bill modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The shop ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21000017</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        /// <summary>
        /// <para>The shop name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Children\&quot;s distribution store</para>
        /// </summary>
        [NameInMap("shopName")]
        [Validation(Required=false)]
        public string ShopName { get; set; }

        /// <summary>
        /// <para>The start time of the billing cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The bill amount.</para>
        /// </summary>
        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public Money TotalAmount { get; set; }

    }

}
