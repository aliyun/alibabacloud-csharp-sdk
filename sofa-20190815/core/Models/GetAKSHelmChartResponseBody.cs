// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetAKSHelmChartResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ChartPackage")]
        [Validation(Required=false)]
        public GetAKSHelmChartResponseBodyChartPackage ChartPackage { get; set; }
        public class GetAKSHelmChartResponseBodyChartPackage : TeaModel {
            [NameInMap("ChartType")]
            [Validation(Required=false)]
            public string ChartType { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }
            [NameInMap("Readme")]
            [Validation(Required=false)]
            public string Readme { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("SubCharts")]
            [Validation(Required=false)]
            public List<GetAKSHelmChartResponseBodyChartPackageSubCharts> SubCharts { get; set; }
            public class GetAKSHelmChartResponseBodyChartPackageSubCharts : TeaModel {
                public string Name { get; set; }
                public string Version { get; set; }
            }
            [NameInMap("ChartMetaData")]
            [Validation(Required=false)]
            public GetAKSHelmChartResponseBodyChartPackageChartMetaData ChartMetaData { get; set; }
            public class GetAKSHelmChartResponseBodyChartPackageChartMetaData : TeaModel {
                [NameInMap("ApiVersion")]
                [Validation(Required=false)]
                public string ApiVersion { get; set; }

                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }
        };

    }

}
