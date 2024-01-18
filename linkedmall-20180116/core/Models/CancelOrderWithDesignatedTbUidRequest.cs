// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CancelOrderWithDesignatedTbUidRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("LmOrderId")]
        [Validation(Required=false)]
        public long? LmOrderId { get; set; }

        [NameInMap("TbAccountType")]
        [Validation(Required=false)]
        public string TbAccountType { get; set; }

        [NameInMap("TbUserId")]
        [Validation(Required=false)]
        public long? TbUserId { get; set; }

        [NameInMap("ThirdPartyUserId")]
        [Validation(Required=false)]
        public string ThirdPartyUserId { get; set; }

    }

}
