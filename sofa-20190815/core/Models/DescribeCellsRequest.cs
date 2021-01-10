// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeCellsRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NamePrefix")]
        [Validation(Required=false)]
        public string NamePrefix { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

    }

}
