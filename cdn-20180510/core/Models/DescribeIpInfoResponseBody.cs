// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeIpInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("IspEname")]
        [Validation(Required=false)]
        public string IspEname { get; set; }

        [NameInMap("CdnIp")]
        [Validation(Required=false)]
        public string CdnIp { get; set; }

        [NameInMap("RegionEname")]
        [Validation(Required=false)]
        public string RegionEname { get; set; }

    }

}
