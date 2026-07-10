// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthBillSplitGetShrinkRequest : TeaModel {
        [NameInMap("bill_batch")]
        [Validation(Required=false)]
        public string BillBatch { get; set; }

        [NameInMap("bill_month")]
        [Validation(Required=false)]
        public string BillMonth { get; set; }

        [NameInMap("bill_split_key_list")]
        [Validation(Required=false)]
        public string BillSplitKeyListShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bill_split_mode")]
        [Validation(Required=false)]
        public string BillSplitMode { get; set; }

    }

}
