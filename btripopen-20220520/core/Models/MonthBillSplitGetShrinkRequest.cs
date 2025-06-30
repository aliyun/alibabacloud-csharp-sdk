// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthBillSplitGetShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20240101</para>
        /// </summary>
        [NameInMap("bill_batch")]
        [Validation(Required=false)]
        public string BillBatch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>202401</para>
        /// </summary>
        [NameInMap("bill_month")]
        [Validation(Required=false)]
        public string BillMonth { get; set; }

        [NameInMap("bill_split_key_list")]
        [Validation(Required=false)]
        public string BillSplitKeyListShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>by_invoice_third_part_id</para>
        /// </summary>
        [NameInMap("bill_split_mode")]
        [Validation(Required=false)]
        public string BillSplitMode { get; set; }

    }

}
