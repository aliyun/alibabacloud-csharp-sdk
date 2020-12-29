// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageSharePermissionResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ShareGroups")]
        [Validation(Required=false)]
        public DescribeImageSharePermissionResponseBodyShareGroups ShareGroups { get; set; }
        public class DescribeImageSharePermissionResponseBodyShareGroups : TeaModel {
            [NameInMap("ShareGroup")]
            [Validation(Required=false)]
            public List<DescribeImageSharePermissionResponseBodyShareGroupsShareGroup> ShareGroup { get; set; }
            public class DescribeImageSharePermissionResponseBodyShareGroupsShareGroup : TeaModel {
                public string Group { get; set; }
            }
        };

        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeImageSharePermissionResponseBodyAccounts Accounts { get; set; }
        public class DescribeImageSharePermissionResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<DescribeImageSharePermissionResponseBodyAccountsAccount> Account { get; set; }
            public class DescribeImageSharePermissionResponseBodyAccountsAccount : TeaModel {
                public string AliyunId { get; set; }
            }
        };

    }

}
