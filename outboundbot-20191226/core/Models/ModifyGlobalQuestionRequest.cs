// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyGlobalQuestionRequest : TeaModel {
        /// <summary>
        /// <para>A JSON string containing an array of answers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;你好,我是你的专属客服顾问.&quot;]</para>
        /// </summary>
        [NameInMap("Answers")]
        [Validation(Required=false)]
        public string Answers { get; set; }

        /// <summary>
        /// <para>The unique ID of the global question.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad80de88-1661-445a-92ec-bf88dc45d581</para>
        /// </summary>
        [NameInMap("GlobalQuestionId")]
        [Validation(Required=false)]
        public string GlobalQuestionId { get; set; }

        /// <summary>
        /// <para>The global question name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未识别全局问题</para>
        /// </summary>
        [NameInMap("GlobalQuestionName")]
        [Validation(Required=false)]
        public string GlobalQuestionName { get; set; }

        /// <summary>
        /// <para>The global question type.</para>
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
        /// <para>e5035654-1745-484a-8c5b-165f7c7bcd79</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>A JSON string containing an array of questions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;你是谁&quot;,&quot;你叫什么&quot;]</para>
        /// </summary>
        [NameInMap("Questions")]
        [Validation(Required=false)]
        public string Questions { get; set; }

        /// <summary>
        /// <para>The script ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0fe7f71c-8771-42ef-9bb1-19aa16ae7120</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

    }

}
