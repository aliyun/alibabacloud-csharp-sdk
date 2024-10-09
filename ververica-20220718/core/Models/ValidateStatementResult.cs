// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ValidateStatementResult : TeaModel {
        [NameInMap("errorDetails")]
        [Validation(Required=false)]
        public ValidationErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;there have some errors&quot;&quot;</para>
        /// </summary>
        [NameInMap("validationResult")]
        [Validation(Required=false)]
        public string ValidationResult { get; set; }

    }

}
