// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOssBucketRequest : TeaModel {
        /// <summary>
        /// The name of the bucket.
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// The language of the content in the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese.
        /// *   **en**: English.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
