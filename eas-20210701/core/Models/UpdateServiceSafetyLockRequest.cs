// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceSafetyLockRequest : TeaModel {
        /// <summary>
        /// The lock scope. Valid values:
        /// 
        /// *   all: locks all operations.
        /// *   dangerous: locks high-risk operations such as delete and stop operations.
        /// *   none: locks no operations.
        /// 
        /// Enumerated values:
        /// 
        /// *   all
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   dangerous
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   none
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("Lock")]
        [Validation(Required=false)]
        public string Lock { get; set; }

    }

}
