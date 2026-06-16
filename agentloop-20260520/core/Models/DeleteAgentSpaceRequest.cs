// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class DeleteAgentSpaceRequest : TeaModel {
        [NameInMap("deleteCmsWorkspace")]
        [Validation(Required=false)]
        public bool? DeleteCmsWorkspace { get; set; }

        [NameInMap("deleteMseNamespace")]
        [Validation(Required=false)]
        public bool? DeleteMseNamespace { get; set; }

        [NameInMap("deleteSlsProject")]
        [Validation(Required=false)]
        public bool? DeleteSlsProject { get; set; }

    }

}
