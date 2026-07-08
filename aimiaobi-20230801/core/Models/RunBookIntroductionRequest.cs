// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunBookIntroductionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CleanCache")]
        [Validation(Required=false)]
        public bool? CleanCache { get; set; }

        /// <summary>
        /// <para>The document ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3YQRatoe8phnpIsIE6z7DTPknhG8Fj</para>
        /// </summary>
        [NameInMap("DocId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <para>A custom prompt for extracting key points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用英文输出</para>
        /// </summary>
        [NameInMap("KeyPointPrompt")]
        [Validation(Required=false)]
        public string KeyPointPrompt { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0f56f98a-f2d8-47ec-98e9-1cbdcffa9539</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>A custom prompt for generating the summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用英文输出</para>
        /// </summary>
        [NameInMap("SummaryPrompt")]
        [Validation(Required=false)]
        public string SummaryPrompt { get; set; }

        /// <summary>
        /// <para>The unique ID of the workspace in Model Studio (Bailian). For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get your workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-vtmox6g2bhq2qv5c</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
