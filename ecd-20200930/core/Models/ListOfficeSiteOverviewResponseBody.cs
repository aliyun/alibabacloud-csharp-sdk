// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListOfficeSiteOverviewResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OfficeSiteOverviewResults")]
        [Validation(Required=false)]
        public List<ListOfficeSiteOverviewResponseBodyOfficeSiteOverviewResults> OfficeSiteOverviewResults { get; set; }
        public class ListOfficeSiteOverviewResponseBodyOfficeSiteOverviewResults : TeaModel {
            [NameInMap("OfficeSiteStatus")]
            [Validation(Required=false)]
            public string OfficeSiteStatus { get; set; }

            [NameInMap("TotalEdsCount")]
            [Validation(Required=false)]
            public int? TotalEdsCount { get; set; }

            [NameInMap("WillExpiredEdsCount")]
            [Validation(Required=false)]
            public int? WillExpiredEdsCount { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("RunningEdsCount")]
            [Validation(Required=false)]
            public int? RunningEdsCount { get; set; }

            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            [NameInMap("HasExpiredEdsCount")]
            [Validation(Required=false)]
            public int? HasExpiredEdsCount { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
