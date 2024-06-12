// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class PutEvaluationsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the delete mode. Valid values:
        /// 
        /// *   true: enables the delete mode
        /// *   false (default): disables the delete mode
        /// 
        /// > This parameter is valid only when you manually trigger or periodically trigger custom rules to evaluate resources. If you enable the delete mode, the evaluation results that are not updated during the current evaluation are automatically deleted.
        /// </summary>
        [NameInMap("DeleteMode")]
        [Validation(Required=false)]
        public bool? DeleteMode { get; set; }

        /// <summary>
        /// The evaluation results.
        /// </summary>
        [NameInMap("Evaluations")]
        [Validation(Required=false)]
        public string Evaluations { get; set; }

        /// <summary>
        /// The callback token. When Cloud Config triggers a custom rule to evaluate resources, the token information is sent to Function Compute as an input parameter. The token must be specified when you submit the evaluation results.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResultToken")]
        [Validation(Required=false)]
        public string ResultToken { get; set; }

    }

}
