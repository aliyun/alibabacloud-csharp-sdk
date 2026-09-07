// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SasClaw20260626.Models
{
    public class ChatUserSecAgentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sec-ops-agent</para>
        /// </summary>
        [NameInMap("Agent")]
        [Validation(Required=false)]
        public string Agent { get; set; }

        /// <summary>
        /// <para>附件暂存 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>stg-6f1d9c8b7a2e4530</para>
        /// </summary>
        [NameInMap("AttachmentStagingId")]
        [Validation(Required=false)]
        public string AttachmentStagingId { get; set; }

        /// <summary>
        /// <para>附件列表 JSON 字符串</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;oss/input.txt&quot;,&quot;oss/raw.txt&quot;]</para>
        /// </summary>
        [NameInMap("Attachments")]
        [Validation(Required=false)]
        public string Attachments { get; set; }

        /// <summary>
        /// <para>逻辑渠道名</para>
        /// 
        /// <b>Example:</b>
        /// <para>console</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>执行模式: single/team/role</para>
        /// 
        /// <b>Example:</b>
        /// <para>single</para>
        /// </summary>
        [NameInMap("ExecutionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// <para>扩展参数 JSON 字符串，如 execution_mode、target 等</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;execution_mode&quot;:&quot;team&quot;,&quot;target&quot;:&quot;team:auto&quot;}</para>
        /// </summary>
        [NameInMap("ExtraParams")]
        [Validation(Required=false)]
        public string ExtraParams { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public bool? Memory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>用户提问；新会话时必填，恢复/交互时可空</para>
        /// 
        /// <b>Example:</b>
        /// <para>帮我梳理最近 24 小时的高危告警并给出处置建议</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("ResponseLanguage")]
        [Validation(Required=false)]
        public string ResponseLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5f2c1b9a8d3e4c7f</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alert-analysis</para>
        /// </summary>
        [NameInMap("Skill")]
        [Validation(Required=false)]
        public string Skill { get; set; }

        [NameInMap("Stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9b1e7d2c4a6f8e30</para>
        /// </summary>
        [NameInMap("TalkId")]
        [Validation(Required=false)]
        public string TalkId { get; set; }

        /// <summary>
        /// <para>执行目标</para>
        /// 
        /// <b>Example:</b>
        /// <para>sec-ops-team-01</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>会话恢复/交互提交信息 JSON 字符串</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;session_example&quot;,&quot;talkId&quot;:&quot;talk_example&quot;,&quot;formId&quot;:&quot;interaction_example&quot;,&quot;formValues&quot;:{&quot;q1&quot;:{&quot;kind&quot;:&quot;selected&quot;,&quot;optionIds&quot;:[&quot;q1_o1&quot;]}},&quot;formAction&quot;:&quot;submit&quot;}</para>
        /// </summary>
        [NameInMap("UserInputInfo")]
        [Validation(Required=false)]
        public string UserInputInfo { get; set; }

    }

}
