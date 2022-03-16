// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeEndpointsResponseBody : TeaModel {
        [NameInMap("ConnAddrs")]
        [Validation(Required=false)]
        public DescribeEndpointsResponseBodyConnAddrs ConnAddrs { get; set; }
        public class DescribeEndpointsResponseBodyConnAddrs : TeaModel {
            [NameInMap("ConnAddrInfo")]
            [Validation(Required=false)]
            public List<DescribeEndpointsResponseBodyConnAddrsConnAddrInfo> ConnAddrInfo { get; set; }
            public class DescribeEndpointsResponseBodyConnAddrsConnAddrInfo : TeaModel {
                public string ConnAddr { get; set; }
                public string ConnAddrPort { get; set; }
                public string ConnType { get; set; }
                public string NetType { get; set; }
            }
        };

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
