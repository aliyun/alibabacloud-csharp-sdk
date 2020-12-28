// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListVirtualHostsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVirtualHostsResponseBodyData Data { get; set; }
        public class ListVirtualHostsResponseBodyData : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("VirtualHosts")]
            [Validation(Required=false)]
            public List<ListVirtualHostsResponseBodyDataVirtualHosts> VirtualHosts { get; set; }
            public class ListVirtualHostsResponseBodyDataVirtualHosts : TeaModel {
                public string Name { get; set; }
            }
        };

    }

}
