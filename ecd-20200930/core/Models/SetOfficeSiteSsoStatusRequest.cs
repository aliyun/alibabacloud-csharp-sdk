// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetOfficeSiteSsoStatusRequest : TeaModel {
        [NameInMap("EnableSso")]
        [Validation(Required=false)]
        public bool? EnableSso { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SsoType")]
        [Validation(Required=false)]
        public string SsoType { get; set; }

    }

}
