// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImageSharePermissionRequest : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("AliyunId")]
        [Validation(Required=false)]
        public long? AliyunId { get; set; }

        /// <summary>
        /// The ID of the image.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The page number. Pages start from page **1**.
        /// 
        /// Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: **100**.
        /// 
        /// Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
