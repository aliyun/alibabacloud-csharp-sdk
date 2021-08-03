// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyOfficeSiteAttributeRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

    }

}
