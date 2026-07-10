// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ConfirmPreBillRequest : TeaModel {
        /// <summary>
        /// <para>The bill batch date in the format of yyyy-MM-dd, such as 2026-06-21.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-21</para>
        /// </summary>
        [NameInMap("bill_batch")]
        [Validation(Required=false)]
        public string BillBatch { get; set; }

    }

}
