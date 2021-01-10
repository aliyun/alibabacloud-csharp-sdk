// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteLDCUnifiedAccessInstanceRequest : TeaModel {
        [NameInMap("UnifiedAccessInstanceName")]
        [Validation(Required=false)]
        public string UnifiedAccessInstanceName { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

    }

}
