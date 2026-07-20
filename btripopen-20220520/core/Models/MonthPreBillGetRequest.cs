// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthPreBillGetRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20251201</para>
        /// </summary>
        [NameInMap("bill_batch")]
        [Validation(Required=false)]
        public string BillBatch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>202207</para>
        /// </summary>
        [NameInMap("bill_month")]
        [Validation(Required=false)]
        public string BillMonth { get; set; }

    }

}
