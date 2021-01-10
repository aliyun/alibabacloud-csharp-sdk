// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SaveAKSHelmChartPackageTreeRequest : TeaModel {
        [NameInMap("ChartFiles")]
        [Validation(Required=false)]
        public List<SaveAKSHelmChartPackageTreeRequestChartFiles> ChartFiles { get; set; }
        public class SaveAKSHelmChartPackageTreeRequestChartFiles : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

        }

        [NameInMap("ChartName")]
        [Validation(Required=false)]
        public string ChartName { get; set; }

        [NameInMap("ChartType")]
        [Validation(Required=false)]
        public string ChartType { get; set; }

        [NameInMap("ChartVersion")]
        [Validation(Required=false)]
        public string ChartVersion { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
