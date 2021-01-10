// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLDCFlowUidInfoRequest : TeaModel {
        [NameInMap("Elastic")]
        [Validation(Required=false)]
        public bool? Elastic { get; set; }

        [NameInMap("Gray")]
        [Validation(Required=false)]
        public bool? Gray { get; set; }

        [NameInMap("Press")]
        [Validation(Required=false)]
        public bool? Press { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

    }

}
