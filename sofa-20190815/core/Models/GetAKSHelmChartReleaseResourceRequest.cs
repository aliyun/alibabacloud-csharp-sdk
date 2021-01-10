// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetAKSHelmChartReleaseResourceRequest : TeaModel {
        [NameInMap("ChartName")]
        [Validation(Required=false)]
        public string ChartName { get; set; }

        [NameInMap("ChartVersion")]
        [Validation(Required=false)]
        public string ChartVersion { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("ReleaseName")]
        [Validation(Required=false)]
        public string ReleaseName { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
