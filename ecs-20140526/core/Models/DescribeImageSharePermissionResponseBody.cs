// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageSharePermissionResponseBody : TeaModel {
        /// <summary>
        /// The Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeImageSharePermissionResponseBodyAccounts Accounts { get; set; }
        public class DescribeImageSharePermissionResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<DescribeImageSharePermissionResponseBodyAccountsAccount> Account { get; set; }
            public class DescribeImageSharePermissionResponseBodyAccountsAccount : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public string AliyunId { get; set; }

                /// <summary>
                /// The time when the image was shared. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("SharedTime")]
                [Validation(Required=false)]
                public string SharedTime { get; set; }

            }

        }

        /// <summary>
        /// The ID of the custom image.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the custom image.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The shared groups.
        /// </summary>
        [NameInMap("ShareGroups")]
        [Validation(Required=false)]
        public DescribeImageSharePermissionResponseBodyShareGroups ShareGroups { get; set; }
        public class DescribeImageSharePermissionResponseBodyShareGroups : TeaModel {
            [NameInMap("ShareGroup")]
            [Validation(Required=false)]
            public List<DescribeImageSharePermissionResponseBodyShareGroupsShareGroup> ShareGroup { get; set; }
            public class DescribeImageSharePermissionResponseBodyShareGroupsShareGroup : TeaModel {
                /// <summary>
                /// The shared group.
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
