// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOssBucketScanInfoRequest : TeaModel {
        /// <summary>
        /// The name of the bucket.
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The name of the bucket that is used for fuzzy match.
        /// </summary>
        [NameInMap("FuzzBucketName")]
        [Validation(Required=false)]
        public string FuzzBucketName { get; set; }

        /// <summary>
        /// Specifies whether at-risk objects are detected. Valid values:
        /// 
        /// *   **0**: No at-risk objects are detected.
        /// *   **1**: At-risk objects are detected.
        /// </summary>
        [NameInMap("HasRisk")]
        [Validation(Required=false)]
        public int? HasRisk { get; set; }

        /// <summary>
        /// The language of the content in the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese.
        /// *   **en**: English.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The check status of the bucket. Valid values:
        /// 
        /// *   **1**: The bucket is not checked.
        /// *   **2**: All objects in the bucket are being checked.
        /// *   **3**: Only new objects in the bucket are being checked.
        /// *   **4**: The bucket is checked.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
