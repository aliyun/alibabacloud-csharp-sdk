// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateK8sClusterUserConfigExpireRequest : TeaModel {
        [NameInMap("expire_hour")]
        [Validation(Required=false)]
        public long? ExpireHour { get; set; }

        [NameInMap("user")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
