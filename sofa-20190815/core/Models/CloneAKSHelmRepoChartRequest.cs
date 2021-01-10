// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CloneAKSHelmRepoChartRequest : TeaModel {
        [NameInMap("ChartNameWithRepo")]
        [Validation(Required=false)]
        public string ChartNameWithRepo { get; set; }

        [NameInMap("ChartVersion")]
        [Validation(Required=false)]
        public string ChartVersion { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
