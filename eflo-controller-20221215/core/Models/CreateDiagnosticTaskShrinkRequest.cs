// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateDiagnosticTaskShrinkRequest : TeaModel {
        [NameInMap("AiJobLogInfo")]
        [Validation(Required=false)]
        public string AiJobLogInfoShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i118913031696573280136</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CheckByAiJobLogs</para>
        /// </summary>
        [NameInMap("DiagnosticType")]
        [Validation(Required=false)]
        public string DiagnosticType { get; set; }

        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIdsShrink { get; set; }

    }

}
