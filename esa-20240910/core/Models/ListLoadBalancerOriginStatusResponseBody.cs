// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListLoadBalancerOriginStatusResponseBody : TeaModel {
        [NameInMap("OriginStatus")]
        [Validation(Required=false)]
        public List<ListLoadBalancerOriginStatusResponseBodyOriginStatus> OriginStatus { get; set; }
        public class ListLoadBalancerOriginStatusResponseBodyOriginStatus : TeaModel {
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public long? LoadBalancerId { get; set; }

            [NameInMap("OriginId")]
            [Validation(Required=false)]
            public long? OriginId { get; set; }

            [NameInMap("PoolId")]
            [Validation(Required=false)]
            public long? PoolId { get; set; }

            [NameInMap("PoolType")]
            [Validation(Required=false)]
            public string PoolType { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
