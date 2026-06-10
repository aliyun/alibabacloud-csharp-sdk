// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateGlobalQuestionRequest : TeaModel {
        /// <summary>
        /// <para>The answers to the global question.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;你好,您可以再说一遍吗&quot;,&quot;不好意思我刚才没有听清&quot;]</para>
        /// </summary>
        [NameInMap("Answers")]
        [Validation(Required=false)]
        public string Answers { get; set; }

        /// <summary>
        /// <para>The name of the global question.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未识别全局问题</para>
        /// </summary>
        [NameInMap("GlobalQuestionName")]
        [Validation(Required=false)]
        public string GlobalQuestionName { get; set; }

        /// <summary>
        /// <para>The type of the global question.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMMON</para>
        /// </summary>
        [NameInMap("GlobalQuestionType")]
        [Validation(Required=false)]
        public string GlobalQuestionType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>361c8a53-0e29-42f3-8aa7-c7752d010399</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The questions that trigger the global question.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;未识别的用户问题&quot;]</para>
        /// </summary>
        [NameInMap("Questions")]
        [Validation(Required=false)]
        public string Questions { get; set; }

        /// <summary>
        /// <para>The script ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5c5d8c0-c0f1-48a7-be2b-dc46006d888a</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

    }

}
