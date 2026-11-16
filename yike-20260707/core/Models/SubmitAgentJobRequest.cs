// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitAgentJobRequest : TeaModel {
        /// <summary>
        /// <para>The large language model (LLM) used to execute the agent task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3.7-plus</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The callback URL. Only HTTP and HTTPS URLs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://api.ai-x.vip/callback">https://api.ai-x.vip/callback</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>The prompt. The specific content is defined by your business.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Compare the military records of Yue Jin and Guan Yu in real history to determine who was stronger</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The skill identifier used for the task, which is provided by the skill provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wf://xxx</para>
        /// </summary>
        [NameInMap("Skill")]
        [Validation(Required=false)]
        public string Skill { get; set; }

        /// <summary>
        /// <para>The user-defined information. This information is returned as-is in the callback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“x”: 1}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws_1151222932383236</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
