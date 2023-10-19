// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeIpControlsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("IpControlInfos")]
        [Validation(Required=false)]
        public DescribeIpControlsResponseBodyIpControlInfos IpControlInfos { get; set; }
        public class DescribeIpControlsResponseBodyIpControlInfos : TeaModel {
            [NameInMap("IpControlInfo")]
            [Validation(Required=false)]
            public List<DescribeIpControlsResponseBodyIpControlInfosIpControlInfo> IpControlInfo { get; set; }
            public class DescribeIpControlsResponseBodyIpControlInfosIpControlInfo : TeaModel {
                /// <summary>
                /// The name of the ACL.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The time when the ACL was modified. The time is displayed in UTC.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The total number of returned entries.
                /// </summary>
                [NameInMap("IpControlId")]
                [Validation(Required=false)]
                public string IpControlId { get; set; }

                /// <summary>
                /// The type of the ACL.
                /// </summary>
                [NameInMap("IpControlName")]
                [Validation(Required=false)]
                public string IpControlName { get; set; }

                /// <summary>
                /// The information about the ACL. The information is an array of IpControlInfo data. The information does not include specific policies.
                /// </summary>
                [NameInMap("IpControlType")]
                [Validation(Required=false)]
                public string IpControlType { get; set; }

                /// <summary>
                /// The ID of the ACL.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The description of the ACL.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 100. Default value: 10.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
