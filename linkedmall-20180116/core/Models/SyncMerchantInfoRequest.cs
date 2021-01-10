// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class SyncMerchantInfoRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("SellerNick")]
        [Validation(Required=false)]
        public string SellerNick { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public string ItemList { get; set; }

        [NameInMap("TimeStamp")]
        [Validation(Required=false)]
        public long? TimeStamp { get; set; }

    }

}
