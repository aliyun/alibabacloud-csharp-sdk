// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateDiagnosticTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The log information.</para>
        /// </summary>
        [NameInMap("AiJobLogInfo")]
        [Validation(Required=false)]
        public string AiJobLogInfoShrink { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i118913031696573280136</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The diagnostics type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CheckByAiJobLogs</para>
        /// </summary>
        [NameInMap("DiagnosticType")]
        [Validation(Required=false)]
        public string DiagnosticType { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes.</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIdsShrink { get; set; }

    }

}
