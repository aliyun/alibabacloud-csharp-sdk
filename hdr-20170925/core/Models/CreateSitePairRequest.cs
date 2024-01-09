// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class CreateSitePairRequest : TeaModel {
        [NameInMap("PrimarySiteName")]
        [Validation(Required=false)]
        public string PrimarySiteName { get; set; }

        [NameInMap("PrimarySiteRegionId")]
        [Validation(Required=false)]
        public string PrimarySiteRegionId { get; set; }

        [NameInMap("PrimarySiteType")]
        [Validation(Required=false)]
        public string PrimarySiteType { get; set; }

        [NameInMap("PrimarySiteVpcId")]
        [Validation(Required=false)]
        public string PrimarySiteVpcId { get; set; }

        [NameInMap("PrimarySiteZoneId")]
        [Validation(Required=false)]
        public string PrimarySiteZoneId { get; set; }

        [NameInMap("SecondarySiteName")]
        [Validation(Required=false)]
        public string SecondarySiteName { get; set; }

        [NameInMap("SecondarySiteRegionId")]
        [Validation(Required=false)]
        public string SecondarySiteRegionId { get; set; }

        [NameInMap("SecondarySiteType")]
        [Validation(Required=false)]
        public string SecondarySiteType { get; set; }

        [NameInMap("SecondarySiteVpcId")]
        [Validation(Required=false)]
        public string SecondarySiteVpcId { get; set; }

        [NameInMap("SecondarySiteZoneId")]
        [Validation(Required=false)]
        public string SecondarySiteZoneId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("SitePairType")]
        [Validation(Required=false)]
        public string SitePairType { get; set; }

    }

}
