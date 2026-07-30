// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthBillSplitGetRequest : TeaModel {
        /// <summary>
        /// <para>The batch number. </para>
        /// <list type="bullet">
        /// <item><description>Format: yyyyMMdd.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Either the batch number or the billing month is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20240101</para>
        /// </summary>
        [NameInMap("bill_batch")]
        [Validation(Required=false)]
        public string BillBatch { get; set; }

        /// <summary>
        /// <para>The billing month.</para>
        /// <list type="bullet">
        /// <item><description>Format: yyyyMM.<remarks>
        /// <para>Either the batch number or the billing month is required.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>202401</para>
        /// </summary>
        [NameInMap("bill_month")]
        [Validation(Required=false)]
        public string BillMonth { get; set; }

        /// <summary>
        /// <para>The list of keys for the bill split dimension.</para>
        /// </summary>
        [NameInMap("bill_split_key_list")]
        [Validation(Required=false)]
        public List<string> BillSplitKeyList { get; set; }

        /// <summary>
        /// <para>The bill split mode.</para>
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
