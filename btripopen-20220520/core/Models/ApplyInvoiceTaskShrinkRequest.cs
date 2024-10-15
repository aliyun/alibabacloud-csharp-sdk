// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyInvoiceTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-01</para>
        /// </summary>
        [NameInMap("bill_date")]
        [Validation(Required=false)]
        public string BillDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("invoice_task_list")]
        [Validation(Required=false)]
        public string InvoiceTaskListShrink { get; set; }

    }

}
