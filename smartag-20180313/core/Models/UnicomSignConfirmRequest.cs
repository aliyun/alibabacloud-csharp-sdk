// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class UnicomSignConfirmRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TmsOrder")]
        [Validation(Required=false)]
        public List<UnicomSignConfirmRequestTmsOrder> TmsOrder { get; set; }
        public class UnicomSignConfirmRequestTmsOrder : TeaModel {
            [NameInMap("SigningTime")]
            [Validation(Required=false)]
            public string SigningTime { get; set; }

            [NameInMap("TradeId")]
            [Validation(Required=false)]
            public string TradeId { get; set; }

            [NameInMap("TmsOrderCode")]
            [Validation(Required=false)]
            public string TmsOrderCode { get; set; }

            [NameInMap("TmsCode")]
            [Validation(Required=false)]
            public string TmsCode { get; set; }

        }

    }

}
