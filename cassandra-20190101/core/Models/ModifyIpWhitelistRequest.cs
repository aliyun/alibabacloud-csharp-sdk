// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class ModifyIpWhitelistRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("IpList")]
        [Validation(Required=false)]
        public string IpList { get; set; }

    }

}
