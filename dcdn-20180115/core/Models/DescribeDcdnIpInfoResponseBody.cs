// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpInfoResponseBody : TeaModel {
        [NameInMap("DcdnIp")]
        [Validation(Required=false)]
        public string DcdnIp { get; set; }

        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        [NameInMap("IspEname")]
        [Validation(Required=false)]
        public string IspEname { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RegionEname")]
        [Validation(Required=false)]
        public string RegionEname { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
