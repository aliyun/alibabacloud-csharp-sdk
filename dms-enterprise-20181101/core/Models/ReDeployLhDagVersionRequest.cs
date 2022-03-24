// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ReDeployLhDagVersionRequest : TeaModel {
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        [NameInMap("DagVersion")]
        [Validation(Required=false)]
        public long? DagVersion { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
