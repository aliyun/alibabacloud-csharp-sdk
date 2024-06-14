// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class SetDeletionProtectionRequest : TeaModel {
        /// <summary>
        /// The description of deletion protection.
        /// 
        /// >  This parameter takes effect only when you set the EnableDeletionProtection parameter to true.
        /// </summary>
        [NameInMap("DeletionProtectionDescription")]
        [Validation(Required=false)]
        public string DeletionProtectionDescription { get; set; }

        /// <summary>
        /// Specifies whether to enable deletion protection. Valid values:
        /// 
        /// *   true: enables deletion protection.
        /// *   false: disables deletion protection.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnableDeletionProtection")]
        [Validation(Required=false)]
        public bool? EnableDeletionProtection { get; set; }

        /// <summary>
        /// The ARN of the CMK for which you want to set deletion protection.
        /// 
        /// You can call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the CMK ARN.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProtectedResourceArn")]
        [Validation(Required=false)]
        public string ProtectedResourceArn { get; set; }

    }

}
