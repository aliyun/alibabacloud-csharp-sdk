// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class SecurityContextCapabilities : TeaModel {
        [NameInMap("Add")]
        [Validation(Required=false)]
        public List<string> Add { get; set; }

        [NameInMap("Drop")]
        [Validation(Required=false)]
        public List<string> Drop { get; set; }

    }

}
