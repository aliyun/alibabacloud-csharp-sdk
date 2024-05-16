// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainVerifyDataRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. You can specify only one domain name in each request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies whether to enable the global resource plan.
        /// 
        /// Valid values:
        /// 
        /// *   off
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   on
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("GlobalResourcePlan")]
        [Validation(Required=false)]
        public string GlobalResourcePlan { get; set; }

    }

}
