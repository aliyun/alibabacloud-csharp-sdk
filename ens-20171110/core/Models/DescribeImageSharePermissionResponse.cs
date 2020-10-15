// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImageSharePermissionResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=true)]
        public string ImageId { get; set; }

        [NameInMap("Accounts")]
        [Validation(Required=true)]
        public DescribeImageSharePermissionResponseAccounts Accounts { get; set; }
        public class DescribeImageSharePermissionResponseAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=true)]
            public List<string> Account { get; set; }
        };

    }

}
