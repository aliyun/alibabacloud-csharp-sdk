// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiTrafficControlsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the API.
        /// </summary>
        [NameInMap("ApiTrafficControls")]
        [Validation(Required=false)]
        public DescribeApiTrafficControlsResponseBodyApiTrafficControls ApiTrafficControls { get; set; }
        public class DescribeApiTrafficControlsResponseBodyApiTrafficControls : TeaModel {
            [NameInMap("ApiTrafficControlItem")]
            [Validation(Required=false)]
            public List<DescribeApiTrafficControlsResponseBodyApiTrafficControlsApiTrafficControlItem> ApiTrafficControlItem { get; set; }
            public class DescribeApiTrafficControlsResponseBodyApiTrafficControlsApiTrafficControlItem : TeaModel {
                /// <summary>
                /// The name of the throttling policy.
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// Queries the throttling policies bound to all members of an API group in a specified environment.
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// The ID of the throttling policy.
                /// </summary>
                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                /// <summary>
                /// API operation
                /// </summary>
                [NameInMap("TrafficControlId")]
                [Validation(Required=false)]
                public string TrafficControlId { get; set; }

                /// <summary>
                /// *   This API is intended for API providers.
                /// *   The ApiIds parameter is optional. If this parameter is not specified, all results in the specified environment of an API group are returned.
                /// </summary>
                [NameInMap("TrafficControlName")]
                [Validation(Required=false)]
                public string TrafficControlName { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The returned throttling policy information. It is an array consisting of ApiTrafficControlItem data.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The binding time of the throttling policy.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
