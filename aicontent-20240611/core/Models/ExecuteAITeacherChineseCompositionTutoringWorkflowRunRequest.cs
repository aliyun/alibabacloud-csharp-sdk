// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteAITeacherChineseCompositionTutoringWorkflowRunRequest : TeaModel {
        [NameInMap("essayOutline")]
        [Validation(Required=false)]
        public string EssayOutline { get; set; }

        [NameInMap("essayRequirements")]
        [Validation(Required=false)]
        public string EssayRequirements { get; set; }

        [NameInMap("essayTopic")]
        [Validation(Required=false)]
        public string EssayTopic { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>essay</para>
        /// </summary>
        [NameInMap("essayType")]
        [Validation(Required=false)]
        public string EssayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("essayWordCount")]
        [Validation(Required=false)]
        public long? EssayWordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("grade")]
        [Validation(Required=false)]
        public long? Grade { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>streaming</para>
        /// </summary>
        [NameInMap("responseMode")]
        [Validation(Required=false)]
        public string ResponseMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxxxxx</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
