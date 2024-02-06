// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImageSharePermissionResponseBody : TeaModel {
        /// <summary>
        /// The account information.
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public DescribeImageSharePermissionResponseBodyAccounts Accounts { get; set; }
        public class DescribeImageSharePermissionResponseBodyAccounts : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public List<string> Account { get; set; }

        }

        /// <summary>
        /// The ID of the image.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of Alibaba Cloud accounts with which you share the image.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
