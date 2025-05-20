// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ServiceSpec : TeaModel {
        [NameInMap("DefaultPort")]
        [Validation(Required=false)]
        public int? DefaultPort { get; set; }

        [NameInMap("ExtraPorts")]
        [Validation(Required=false)]
        public int? ExtraPorts { get; set; }

        [NameInMap("ServiceMode")]
        [Validation(Required=false)]
        public string ServiceMode { get; set; }

    }

}
