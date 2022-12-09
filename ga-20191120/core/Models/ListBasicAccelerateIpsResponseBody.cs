// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBasicAccelerateIpsResponseBody : TeaModel {
        [NameInMap("AccelerateIps")]
        [Validation(Required=false)]
        public List<ListBasicAccelerateIpsResponseBodyAccelerateIps> AccelerateIps { get; set; }
        public class ListBasicAccelerateIpsResponseBodyAccelerateIps : TeaModel {
            [NameInMap("AccelerateIpAddress")]
            [Validation(Required=false)]
            public string AccelerateIpAddress { get; set; }

            [NameInMap("AccelerateIpId")]
            [Validation(Required=false)]
            public string AccelerateIpId { get; set; }

            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            [NameInMap("IpSetId")]
            [Validation(Required=false)]
            public string IpSetId { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
