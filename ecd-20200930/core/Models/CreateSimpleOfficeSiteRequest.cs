// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateSimpleOfficeSiteRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        [NameInMap("EnableInternetAccess")]
        [Validation(Required=false)]
        public bool? EnableInternetAccess { get; set; }

        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

    }

}
