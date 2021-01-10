// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListAKSHelmChartReleaseResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("ChartReleases")]
        [Validation(Required=false)]
        public List<ListAKSHelmChartReleaseResponseBodyChartReleases> ChartReleases { get; set; }
        public class ListAKSHelmChartReleaseResponseBodyChartReleases : TeaModel {
            [NameInMap("ChartId")]
            [Validation(Required=false)]
            public string ChartId { get; set; }

            [NameInMap("ChartName")]
            [Validation(Required=false)]
            public string ChartName { get; set; }

            [NameInMap("ChartVersion")]
            [Validation(Required=false)]
            public string ChartVersion { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("ReleaseLog")]
            [Validation(Required=false)]
            public string ReleaseLog { get; set; }

            [NameInMap("ReleaseName")]
            [Validation(Required=false)]
            public string ReleaseName { get; set; }

            [NameInMap("Revision")]
            [Validation(Required=false)]
            public long? Revision { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("Superseded")]
            [Validation(Required=false)]
            public long? Superseded { get; set; }

            [NameInMap("ExtraData")]
            [Validation(Required=false)]
            public ListAKSHelmChartReleaseResponseBodyChartReleasesExtraData ExtraData { get; set; }
            public class ListAKSHelmChartReleaseResponseBodyChartReleasesExtraData : TeaModel {
                [NameInMap("ChartType")]
                [Validation(Required=false)]
                public string ChartType { get; set; }
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }
            };

        }

    }

}
