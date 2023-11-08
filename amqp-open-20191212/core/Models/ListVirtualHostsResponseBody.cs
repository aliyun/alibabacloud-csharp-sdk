// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListVirtualHostsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVirtualHostsResponseBodyData Data { get; set; }
        public class ListVirtualHostsResponseBodyData : TeaModel {
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// Vhost。
            /// </summary>
            [NameInMap("VirtualHosts")]
            [Validation(Required=false)]
            public List<ListVirtualHostsResponseBodyDataVirtualHosts> VirtualHosts { get; set; }
            public class ListVirtualHostsResponseBodyDataVirtualHosts : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
