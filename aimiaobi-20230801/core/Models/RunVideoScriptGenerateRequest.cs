// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunVideoScriptGenerateRequest : TeaModel {
        /// <summary>
        /// <para>The language of the generated script.
        /// Recommended values:</para>
        /// <para>zh-CN: Chinese</para>
        /// <para>en-US: English</para>
        /// <para>The default is Chinese.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The prompt for the video script.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>写一篇关于黄山旅游的脚本</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The length of the script. Valid values:</para>
        /// <para>20\~75: 10 to 15 seconds of normal speaking time.</para>
        /// <para>75\~150: 15 to 30 seconds of normal speaking time.</para>
        /// <para>150\~300: Approximately 30 to 60 seconds of normal speaking time.</para>
        /// <para>\&gt;=300: 60 seconds or more of normal speaking time.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <para>=300</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ScriptLength")]
        [Validation(Required=false)]
        public string ScriptLength { get; set; }

        /// <summary>
        /// <para>The number of scripts to generate. The default is 1. You can generate a maximum of three scripts at a time.
        /// If you specify multiple scripts, the results are returned in parallel streams. The client distinguishes between the streams using different session IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScriptNumber")]
        [Validation(Required=false)]
        public int? ScriptNumber { get; set; }

        /// <summary>
        /// <para>Specifies whether to use an internet search. If you set this to true, the system performs intention recognition and then searches the internet for relevant reference materials.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseSearch")]
        [Validation(Required=false)]
        public bool? UseSearch { get; set; }

        /// <summary>
        /// <para>The unique ID of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get a Workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
