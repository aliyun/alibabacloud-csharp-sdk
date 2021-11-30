// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTagScanResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Vulnerabilities")]
        [Validation(Required=false)]
        public List<ListRepoTagScanResultResponseBodyVulnerabilities> Vulnerabilities { get; set; }
        public class ListRepoTagScanResultResponseBodyVulnerabilities : TeaModel {
            [NameInMap("AddedBy")]
            [Validation(Required=false)]
            public string AddedBy { get; set; }

            [NameInMap("CveLink")]
            [Validation(Required=false)]
            public string CveLink { get; set; }

            [NameInMap("CveName")]
            [Validation(Required=false)]
            public string CveName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            [NameInMap("FixCmd")]
            [Validation(Required=false)]
            public string FixCmd { get; set; }

            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("VersionFixed")]
            [Validation(Required=false)]
            public string VersionFixed { get; set; }

            [NameInMap("VersionFormat")]
            [Validation(Required=false)]
            public string VersionFormat { get; set; }

        }

    }

}
