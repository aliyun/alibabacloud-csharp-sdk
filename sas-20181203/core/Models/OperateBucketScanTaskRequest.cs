// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateBucketScanTaskRequest : TeaModel {
        /// <summary>
        /// The name of the bucket.
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// The operation that you want to perform on the bucket. Valid value:
        /// 
        /// *   **1**: cancels the bucket check.
        /// </summary>
        [NameInMap("OperateCode")]
        [Validation(Required=false)]
        public int? OperateCode { get; set; }

    }

}
