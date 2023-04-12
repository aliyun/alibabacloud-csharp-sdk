// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CopyCompliancePacksResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the compliance packages are successfully replicated. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("CopyRulesResult")]
        [Validation(Required=false)]
        public bool? CopyRulesResult { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
