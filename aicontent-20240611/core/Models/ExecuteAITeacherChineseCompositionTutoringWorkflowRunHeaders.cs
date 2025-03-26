// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteAITeacherChineseCompositionTutoringWorkflowRunHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxxx</para>
        /// </summary>
        [NameInMap("callerParentId")]
        [Validation(Required=false)]
        public long? CallerParentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sub</para>
        /// </summary>
        [NameInMap("callerType")]
        [Validation(Required=false)]
        public string CallerType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxxx</para>
        /// </summary>
        [NameInMap("callerUid")]
        [Validation(Required=false)]
        public long? CallerUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxxx</para>
        /// </summary>
        [NameInMap("stsTokenCallerUid")]
        [Validation(Required=false)]
        public long? StsTokenCallerUid { get; set; }

    }

}
