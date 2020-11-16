// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateCasterRequest : TeaModel {
        [NameInMap("CasterName")]
        [Validation(Required=false)]
        public string CasterName { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=true)]
        public string ClientToken { get; set; }

        [NameInMap("NormType")]
        [Validation(Required=true)]
        public int? NormType { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=true)]
        public string ChargeType { get; set; }

        [NameInMap("PurchaseTime")]
        [Validation(Required=false)]
        public string PurchaseTime { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("CasterTemplate")]
        [Validation(Required=false)]
        public string CasterTemplate { get; set; }

    }

}
