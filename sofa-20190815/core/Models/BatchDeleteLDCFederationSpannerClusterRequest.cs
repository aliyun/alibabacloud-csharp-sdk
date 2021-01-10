// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchDeleteLDCFederationSpannerClusterRequest : TeaModel {
        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

        [NameInMap("ClusterNamesRepeatList")]
        [Validation(Required=false)]
        public List<string> ClusterNamesRepeatList { get; set; }

    }

}
