// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudVendorAccountAKListRequest : TeaModel {
        /// <summary>
        /// The unique ID of the AccessKey pair.
        /// </summary>
        [NameInMap("AuthIds")]
        [Validation(Required=false)]
        public string AuthIds { get; set; }

        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The status of the AccessKey pair. Valid values:
        /// 
        /// *   **0**: enabled
        /// *   **1**: disabled
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The username of the sub-account of the cloud service provider to which the AccessKey pair belongs.
        /// </summary>
        [NameInMap("SubAccountName")]
        [Validation(Required=false)]
        public string SubAccountName { get; set; }

    }

}
