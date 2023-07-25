// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CopyConfigRulesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the rules are replicated. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("CopyRulesResult")]
        [Validation(Required=false)]
        public bool? CopyRulesResult { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
