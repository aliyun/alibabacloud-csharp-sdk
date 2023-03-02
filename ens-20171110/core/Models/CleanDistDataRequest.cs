// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CleanDistDataRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("DataName")]
        [Validation(Required=false)]
        public string DataName { get; set; }

        [NameInMap("DataVersion")]
        [Validation(Required=false)]
        public string DataVersion { get; set; }

        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

    }

}
