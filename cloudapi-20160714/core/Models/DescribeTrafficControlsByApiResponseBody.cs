// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeTrafficControlsByApiResponseBody : TeaModel {
        /// <summary>
        /// The ID of the throttling policy.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The binding time of the policy.
        /// </summary>
        [NameInMap("TrafficControlItems")]
        [Validation(Required=false)]
        public DescribeTrafficControlsByApiResponseBodyTrafficControlItems TrafficControlItems { get; set; }
        public class DescribeTrafficControlsByApiResponseBodyTrafficControlItems : TeaModel {
            [NameInMap("TrafficControlItem")]
            [Validation(Required=false)]
            public List<DescribeTrafficControlsByApiResponseBodyTrafficControlItemsTrafficControlItem> TrafficControlItem { get; set; }
            public class DescribeTrafficControlsByApiResponseBodyTrafficControlItemsTrafficControlItem : TeaModel {
                /// <summary>
                /// *   This API is intended for API providers.
                /// </summary>
                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                /// <summary>
                /// The name of the throttling policy.
                /// </summary>
                [NameInMap("TrafficControlItemId")]
                [Validation(Required=false)]
                public string TrafficControlItemId { get; set; }

                /// <summary>
                /// Queries the throttling policy that is bound to a specific API.
                /// </summary>
                [NameInMap("TrafficControlItemName")]
                [Validation(Required=false)]
                public string TrafficControlItemName { get; set; }

            }

        }

    }

}
