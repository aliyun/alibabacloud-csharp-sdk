// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IeHotelBillSettlementQueryRequest : TeaModel {
        [NameInMap("bill_batch")]
        [Validation(Required=false)]
        public string BillBatch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_no")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-10-02</para>
        /// </summary>
        [NameInMap("period_end")]
        [Validation(Required=false)]
        public string PeriodEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-10-01</para>
        /// </summary>
        [NameInMap("period_start")]
        [Validation(Required=false)]
        public string PeriodStart { get; set; }

        [NameInMap("scroll_id")]
        [Validation(Required=false)]
        public string ScrollId { get; set; }

        [NameInMap("scroll_mod")]
        [Validation(Required=false)]
        public bool? ScrollMod { get; set; }

    }

}
