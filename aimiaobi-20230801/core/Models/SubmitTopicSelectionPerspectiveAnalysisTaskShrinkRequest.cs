// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitTopicSelectionPerspectiveAnalysisTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("Documents")]
        [Validation(Required=false)]
        public string DocumentsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TimedViewPoints</para>
        /// </summary>
        [NameInMap("PerspectiveTypes")]
        [Validation(Required=false)]
        public string PerspectiveTypesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>待分析的主题名（documents与topic二者至少传一个）</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
