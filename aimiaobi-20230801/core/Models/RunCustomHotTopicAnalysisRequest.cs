// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunCustomHotTopicAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>The follow-up question from the model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>模型反问</para>
        /// </summary>
        [NameInMap("AskUser")]
        [Validation(Required=false)]
        public string AskUser { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly analyze a duplicate topic and overwrite the existing analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceAnalysisExistsTopic")]
        [Validation(Required=false)]
        public bool? ForceAnalysisExistsTopic { get; set; }

        /// <summary>
        /// <para>The user\&quot;s input prompt.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户输入Prompt</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The unique ID for each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The unique ID for the entire conversation task.</para>
        /// <remarks>
        /// <para>By default, you do not need to specify TaskId. The system automatically generates one. If you specify the same TaskId for subsequent tasks, the tasks are considered part of the same conversation group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The user\&quot;s input in response to the model\&quot;s follow-up question.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户针对模型反问的输入</para>
        /// </summary>
        [NameInMap("UserBack")]
        [Validation(Required=false)]
        public string UserBack { get; set; }

        /// <summary>
        /// <para>The unique ID of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Obtain a Workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
