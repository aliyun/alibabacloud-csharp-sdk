// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteDEPSServiceGroupCollectionRequest : TeaModel {
        [NameInMap("ArrangementId")]
        [Validation(Required=false)]
        public string ArrangementId { get; set; }

        [NameInMap("ProcessDefinitionId")]
        [Validation(Required=false)]
        public string ProcessDefinitionId { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
