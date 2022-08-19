// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CheckVpnBgpEnabledResponseBody : TeaModel {
        [NameInMap("BgpEnabled")]
        [Validation(Required=false)]
        public bool? BgpEnabled { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
