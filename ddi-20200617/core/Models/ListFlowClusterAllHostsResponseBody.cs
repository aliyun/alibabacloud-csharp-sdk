// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowClusterAllHostsResponseBody : TeaModel {
        [NameInMap("HostList")]
        [Validation(Required=false)]
        public ListFlowClusterAllHostsResponseBodyHostList HostList { get; set; }
        public class ListFlowClusterAllHostsResponseBodyHostList : TeaModel {
            [NameInMap("Host")]
            [Validation(Required=false)]
            public List<ListFlowClusterAllHostsResponseBodyHostListHost> Host { get; set; }
            public class ListFlowClusterAllHostsResponseBodyHostListHost : TeaModel {
                public int? Cpu { get; set; }
                public string HostId { get; set; }
                public string HostInstanceId { get; set; }
                public string HostName { get; set; }
                public string InstanceType { get; set; }
                public int? Memory { get; set; }
                public string PrivateIp { get; set; }
                public string PublicIp { get; set; }
                public string Role { get; set; }
                public string SerialNumber { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
