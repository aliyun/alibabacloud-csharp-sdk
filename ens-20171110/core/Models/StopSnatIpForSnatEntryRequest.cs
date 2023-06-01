// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class StopSnatIpForSnatEntryRequest : TeaModel {
        [NameInMap("SnatEntryId")]
        [Validation(Required=false)]
        public string SnatEntryId { get; set; }

        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

    }

}
