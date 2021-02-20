// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventSrcIpResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Ips")]
        [Validation(Required=false)]
        public List<DescribeDDosEventSrcIpResponseBodyIps> Ips { get; set; }
        public class DescribeDDosEventSrcIpResponseBodyIps : TeaModel {
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

        }

    }

}
