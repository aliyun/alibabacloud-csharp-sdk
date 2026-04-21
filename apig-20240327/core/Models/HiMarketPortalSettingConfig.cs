// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketPortalSettingConfig : TeaModel {
        [NameInMap("autoApproveDevelopers")]
        [Validation(Required=false)]
        public bool? AutoApproveDevelopers { get; set; }

        [NameInMap("autoApproveSubscriptions")]
        [Validation(Required=false)]
        public bool? AutoApproveSubscriptions { get; set; }

        [NameInMap("builtinAuthEnabled")]
        [Validation(Required=false)]
        public bool? BuiltinAuthEnabled { get; set; }

    }

}
