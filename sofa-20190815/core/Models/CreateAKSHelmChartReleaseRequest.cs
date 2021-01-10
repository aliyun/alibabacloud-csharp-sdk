// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateAKSHelmChartReleaseRequest : TeaModel {
        [NameInMap("ChartName")]
        [Validation(Required=false)]
        public string ChartName { get; set; }

        [NameInMap("ChartType")]
        [Validation(Required=false)]
        public string ChartType { get; set; }

        [NameInMap("ChartVersion")]
        [Validation(Required=false)]
        public string ChartVersion { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("ReleaseDesc")]
        [Validation(Required=false)]
        public string ReleaseDesc { get; set; }

        [NameInMap("ReleaseName")]
        [Validation(Required=false)]
        public string ReleaseName { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
