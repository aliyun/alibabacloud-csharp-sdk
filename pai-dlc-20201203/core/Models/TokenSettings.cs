// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class TokenSettings : TeaModel {
        [NameInMap("EnableCrossAccountAccess")]
        [Validation(Required=false)]
        public bool? EnableCrossAccountAccess { get; set; }

        [NameInMap("EnableLogDownloadJob")]
        [Validation(Required=false)]
        public bool? EnableLogDownloadJob { get; set; }

    }

}
