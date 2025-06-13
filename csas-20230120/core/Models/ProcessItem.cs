// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ProcessItem : TeaModel {
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        [NameInMap("DevType")]
        [Validation(Required=false)]
        public string DevType { get; set; }

        [NameInMap("Directory")]
        [Validation(Required=false)]
        public string Directory { get; set; }

        [NameInMap("Process")]
        [Validation(Required=false)]
        public string Process { get; set; }

    }

}
