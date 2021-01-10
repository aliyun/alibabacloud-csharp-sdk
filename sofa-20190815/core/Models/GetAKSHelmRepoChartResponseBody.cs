// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetAKSHelmRepoChartResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ChartName")]
        [Validation(Required=false)]
        public string ChartName { get; set; }

        [NameInMap("ChartVersion")]
        [Validation(Required=false)]
        public string ChartVersion { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("HelmRepoChartTree")]
        [Validation(Required=false)]
        public string HelmRepoChartTree { get; set; }

        [NameInMap("Icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("Readme")]
        [Validation(Required=false)]
        public string Readme { get; set; }

    }

}
