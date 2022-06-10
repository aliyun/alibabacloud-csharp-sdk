// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorISPCityListRequest : TeaModel {
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("IPV4")]
        [Validation(Required=false)]
        public bool? IPV4 { get; set; }

        [NameInMap("IPV6")]
        [Validation(Required=false)]
        public bool? IPV6 { get; set; }

        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
