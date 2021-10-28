// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class SwitchCSGClientsReverseSyncConfigurationShrinkRequest : TeaModel {
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public string ClientIdsShrink { get; set; }

        [NameInMap("ClientRegionId")]
        [Validation(Required=false)]
        public string ClientRegionId { get; set; }

        [NameInMap("IsReverseSync")]
        [Validation(Required=false)]
        public bool? IsReverseSync { get; set; }

        [NameInMap("ReverseSyncInternalSecond")]
        [Validation(Required=false)]
        public int? ReverseSyncInternalSecond { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
