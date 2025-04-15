// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetInstanceIpWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The  filter IP address whitelists.</para>
        /// </summary>
        [NameInMap("ipWhitelists")]
        [Validation(Required=false)]
        public List<string> IpWhitelists { get; set; }

    }

}
