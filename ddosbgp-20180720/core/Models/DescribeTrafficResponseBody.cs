// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeTrafficResponseBody : TeaModel {
        /// <summary>
        /// The ID of the traffic statistics.
        /// </summary>
        [NameInMap("FlowList")]
        [Validation(Required=false)]
        public List<DescribeTrafficResponseBodyFlowList> FlowList { get; set; }
        public class DescribeTrafficResponseBodyFlowList : TeaModel {
            [NameInMap("AttackBps")]
            [Validation(Required=false)]
            public long? AttackBps { get; set; }

            /// <summary>
            /// Queries traffic statistics of an Anti-DDoS Origin instance within a specific time period.
            /// </summary>
            [NameInMap("AttackPps")]
            [Validation(Required=false)]
            public long? AttackPps { get; set; }

            /// <summary>
            /// All Alibaba Cloud API operations must include common request parameters. For more information about common request parameters, see [Common parameters](~~118841~~).
            /// 
            /// For more information about sample requests, see the "**Examples**" section of this topic.
            /// </summary>
            [NameInMap("FlowType")]
            [Validation(Required=false)]
            public string FlowType { get; set; }

            [NameInMap("Kbps")]
            [Validation(Required=false)]
            public int? Kbps { get; set; }

            /// <summary>
            /// DescribeTraffic
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// WB269094
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

        }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
