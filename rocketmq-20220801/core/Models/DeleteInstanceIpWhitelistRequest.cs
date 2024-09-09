// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class DeleteInstanceIpWhitelistRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ipWhitelist")]
        [Validation(Required=false)]
        public string IpWhitelist { get; set; }

    }

}
