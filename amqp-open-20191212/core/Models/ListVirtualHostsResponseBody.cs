// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListVirtualHostsResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVirtualHostsResponseBodyData Data { get; set; }
        public class ListVirtualHostsResponseBodyData : TeaModel {
            /// <summary>
            /// The maximum number of entries returned.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The token that marks the end of the current returned page. If this parameter is empty, all data is retrieved.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The vhosts.
            /// </summary>
            [NameInMap("VirtualHosts")]
            [Validation(Required=false)]
            public List<ListVirtualHostsResponseBodyDataVirtualHosts> VirtualHosts { get; set; }
            public class ListVirtualHostsResponseBodyDataVirtualHosts : TeaModel {
                /// <summary>
                /// The vhost name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
