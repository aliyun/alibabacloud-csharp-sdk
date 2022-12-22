// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePolicyAdvancedConfigResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the strict mode is enabled for the access control policy. Valid values:
        /// 
        /// *   **on**: The strict mode is enabled.
        /// *   **off**: The strict mode is disabled.
        /// </summary>
        [NameInMap("InternetSwitch")]
        [Validation(Required=false)]
        public string InternetSwitch { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
