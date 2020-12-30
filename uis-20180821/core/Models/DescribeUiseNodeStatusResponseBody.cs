// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Uis20180821.Models
{
    public class DescribeUiseNodeStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IpStatusList")]
        [Validation(Required=false)]
        public DescribeUiseNodeStatusResponseBodyIpStatusList IpStatusList { get; set; }
        public class DescribeUiseNodeStatusResponseBodyIpStatusList : TeaModel {
            [NameInMap("IpStatus")]
            [Validation(Required=false)]
            public List<DescribeUiseNodeStatusResponseBodyIpStatusListIpStatus> IpStatus { get; set; }
            public class DescribeUiseNodeStatusResponseBodyIpStatusListIpStatus : TeaModel {
                public int? CurrentConnections { get; set; }
                public string Ip { get; set; }
                public int? MaxConnections { get; set; }
            }
        };

    }

}
