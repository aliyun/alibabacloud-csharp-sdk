// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteAITeacherChineseCompositionTutoringWorkflowRunRequest : TeaModel {
        /// <summary>
        /// <para>The essay outline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>题目： 春天的色彩
        /// 开头： 开门见山，点明主题。
        /// 中间： 分段描写春天的不同色彩。
        /// 结尾： 总结全文，抒发情感。</para>
        /// </summary>
        [NameInMap("essayOutline")]
        [Validation(Required=false)]
        public string EssayOutline { get; set; }

        /// <summary>
        /// <para>The essay requirements.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>生动形象，字数不得少于100字</para>
        /// </summary>
        [NameInMap("essayRequirements")]
        [Validation(Required=false)]
        public string EssayRequirements { get; set; }

        /// <summary>
        /// <para>The essay topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>春天的景色</para>
        /// </summary>
        [NameInMap("essayTopic")]
        [Validation(Required=false)]
        public string EssayTopic { get; set; }

        /// <summary>
        /// <para>The essay type.</para>
        /// <para>outline: An outline.</para>
        /// <para>essay: A full essay.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>essay</para>
        /// </summary>
        [NameInMap("essayType")]
        [Validation(Required=false)]
        public string EssayType { get; set; }

        /// <summary>
        /// <para>The target word count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("essayWordCount")]
        [Validation(Required=false)]
        public long? EssayWordCount { get; set; }

        /// <summary>
        /// <para>The student\&quot;s grade level.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("grade")]
        [Validation(Required=false)]
        public long? Grade { get; set; }

        /// <summary>
        /// <para>The response mode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>streaming</para>
        /// </summary>
        [NameInMap("responseMode")]
        [Validation(Required=false)]
        public string ResponseMode { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxxx</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
