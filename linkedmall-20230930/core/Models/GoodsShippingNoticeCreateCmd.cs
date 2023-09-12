// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class GoodsShippingNoticeCreateCmd : TeaModel {
        [NameInMap("cpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        [NameInMap("disputeId")]
        [Validation(Required=false)]
        public long? DisputeId { get; set; }

        [NameInMap("logisticsNo")]
        [Validation(Required=false)]
        public string LogisticsNo { get; set; }

    }

}
