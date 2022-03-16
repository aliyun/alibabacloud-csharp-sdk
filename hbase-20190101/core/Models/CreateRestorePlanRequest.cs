// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class CreateRestorePlanRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("RestoreAllTable")]
        [Validation(Required=false)]
        public bool? RestoreAllTable { get; set; }

        [NameInMap("RestoreByCopy")]
        [Validation(Required=false)]
        public bool? RestoreByCopy { get; set; }

        [NameInMap("RestoreToDate")]
        [Validation(Required=false)]
        public string RestoreToDate { get; set; }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public string Tables { get; set; }

        [NameInMap("TargetClusterId")]
        [Validation(Required=false)]
        public string TargetClusterId { get; set; }

    }

}
