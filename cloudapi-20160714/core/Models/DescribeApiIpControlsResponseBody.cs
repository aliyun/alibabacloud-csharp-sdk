// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiIpControlsResponseBody : TeaModel {
        /// <summary>
        /// The information about the ACLs. The information is an array of ApiIpControlItem data.
        /// </summary>
        [NameInMap("ApiIpControls")]
        [Validation(Required=false)]
        public DescribeApiIpControlsResponseBodyApiIpControls ApiIpControls { get; set; }
        public class DescribeApiIpControlsResponseBodyApiIpControls : TeaModel {
            [NameInMap("ApiIpControlItem")]
            [Validation(Required=false)]
            public List<DescribeApiIpControlsResponseBodyApiIpControlsApiIpControlItem> ApiIpControlItem { get; set; }
            public class DescribeApiIpControlsResponseBodyApiIpControlsApiIpControlItem : TeaModel {
                /// <summary>
                /// The ID of the API.
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// The name of the API.
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// The time of binding.
                /// </summary>
                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                /// <summary>
                /// The ID of the ACL.
                /// </summary>
                [NameInMap("IpControlId")]
                [Validation(Required=false)]
                public string IpControlId { get; set; }

                /// <summary>
                /// The name of the ACL.
                /// </summary>
                [NameInMap("IpControlName")]
                [Validation(Required=false)]
                public string IpControlName { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
