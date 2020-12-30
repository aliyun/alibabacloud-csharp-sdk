/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aegis20161111.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public int? VersionCode { get; set; }

        [NameInMap("VmNumber")]
        [Validation(Required=false)]
        public int? VmNumber { get; set; }

        [NameInMap("IsAutoRenew")]
        [Validation(Required=false)]
        public bool? IsAutoRenew { get; set; }

        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

    }

}
