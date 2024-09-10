// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUsageTopRequest : TeaModel {
        /// <summary>
        /// The type of the asset fingerprint. Valid value:
        /// 
        /// *   **port**: port
        /// *   **process**: process
        /// *   **software**: software
        /// *   **user**: account
        /// *   **sca**: middleware
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
