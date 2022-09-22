// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImageSharePermissionResponseBody : TeaModel {
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeImageSharePermissionResponseBodyAccounts Accounts { get; set; }
        public class DescribeImageSharePermissionResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<string> Account { get; set; }

        }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
