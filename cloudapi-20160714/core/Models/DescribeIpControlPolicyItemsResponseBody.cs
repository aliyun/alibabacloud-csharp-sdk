// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeIpControlPolicyItemsResponseBody : TeaModel {
        /// <summary>
        /// The information about policies. The information is an array of IpControlPolicyItem data.
        /// </summary>
        [NameInMap("IpControlPolicyItems")]
        [Validation(Required=false)]
        public DescribeIpControlPolicyItemsResponseBodyIpControlPolicyItems IpControlPolicyItems { get; set; }
        public class DescribeIpControlPolicyItemsResponseBodyIpControlPolicyItems : TeaModel {
            [NameInMap("IpControlPolicyItem")]
            [Validation(Required=false)]
            public List<DescribeIpControlPolicyItemsResponseBodyIpControlPolicyItemsIpControlPolicyItem> IpControlPolicyItem { get; set; }
            public class DescribeIpControlPolicyItemsResponseBodyIpControlPolicyItemsIpControlPolicyItem : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The IP addresses or CIDR blocks.
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// The time when the policy was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The time when the policy was modified. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The ID of the policy.
                /// </summary>
                [NameInMap("PolicyItemId")]
                [Validation(Required=false)]
                public string PolicyItemId { get; set; }

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
