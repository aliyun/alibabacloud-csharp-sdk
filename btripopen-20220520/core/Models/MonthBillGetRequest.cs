// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthBillGetRequest : TeaModel {
        /// <summary>
        /// <para>The bill batch. Format: yyyyMMdd for periodic billing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250101</para>
        /// </summary>
        [NameInMap("bill_batch")]
        [Validation(Required=false)]
        public string BillBatch { get; set; }

        /// <summary>
        /// <para>The billing month.</para>
        /// <list type="bullet">
        /// <item><description>Format: yyyyMM.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>202401</para>
        /// </summary>
        [NameInMap("bill_month")]
        [Validation(Required=false)]
        public string BillMonth { get; set; }

    }

}
