// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ledgerdb20191122.Models
{
    public class ModifyIpWhiteListRequest : TeaModel {
        [NameInMap("LedgerId")]
        [Validation(Required=false)]
        public string LedgerId { get; set; }

        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        [NameInMap("IpList")]
        [Validation(Required=false)]
        public string IpList { get; set; }

    }

}
