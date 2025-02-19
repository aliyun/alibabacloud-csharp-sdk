// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetInstanceIpWhitelistRequest : TeaModel {
        [NameInMap("ipWhitelists")]
        [Validation(Required=false)]
        public List<string> IpWhitelists { get; set; }

    }

}
