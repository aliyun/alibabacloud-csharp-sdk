// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListAuthorizedSoftwareResponseBody : TeaModel {
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Softwares")]
        [Validation(Required=false)]
        public List<ListAuthorizedSoftwareResponseBodySoftwares> Softwares { get; set; }
        public class ListAuthorizedSoftwareResponseBodySoftwares : TeaModel {
            [NameInMap("HelpLink")]
            [Validation(Required=false)]
            public string HelpLink { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            [NameInMap("Locations")]
            [Validation(Required=false)]
            public List<string> Locations { get; set; }

            [NameInMap("Promotion")]
            [Validation(Required=false)]
            public string Promotion { get; set; }

            [NameInMap("SoftwareDefaultVersion")]
            [Validation(Required=false)]
            public string SoftwareDefaultVersion { get; set; }

            [NameInMap("SoftwareDescription")]
            [Validation(Required=false)]
            public string SoftwareDescription { get; set; }

            [NameInMap("SoftwareIcon")]
            [Validation(Required=false)]
            public string SoftwareIcon { get; set; }

            [NameInMap("SoftwareLicenseFee")]
            [Validation(Required=false)]
            public float? SoftwareLicenseFee { get; set; }

            [NameInMap("SoftwareLongName")]
            [Validation(Required=false)]
            public string SoftwareLongName { get; set; }

            [NameInMap("SoftwareName")]
            [Validation(Required=false)]
            public string SoftwareName { get; set; }

            [NameInMap("SoftwareVersions")]
            [Validation(Required=false)]
            public List<string> SoftwareVersions { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
