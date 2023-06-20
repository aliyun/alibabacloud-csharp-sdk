// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class AutoRenewInstanceRequest : TeaModel {
        [NameInMap("AutoRenewCycle")]
        [Validation(Required=false)]
        public string AutoRenewCycle { get; set; }

        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        [NameInMap("OrderBizId")]
        [Validation(Required=false)]
        public long? OrderBizId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
