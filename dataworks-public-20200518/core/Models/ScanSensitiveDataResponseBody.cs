// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ScanSensitiveDataResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the check.
        /// 
        /// sensDatas indicates the rules that are used to check the sensitive data. sensDatas includes the following parameters:
        /// 
        /// *   hitCount: the number of times that the sensitive data hits the rule
        /// *   ruleName: the name of the rule
        /// </summary>
        [NameInMap("Sensitives")]
        [Validation(Required=false)]
        public Dictionary<string, object> Sensitives { get; set; }

    }

}
