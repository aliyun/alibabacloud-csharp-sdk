// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDocIntroductionRequest : TeaModel {
        /// <summary>
        /// <para>Purge cache</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CleanCache")]
        [Validation(Required=false)]
        public bool? CleanCache { get; set; }

        /// <summary>
        /// <para>Document ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("DocId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <para>Custom requirements for the document summary</para>
        /// 
        /// <b>Example:</b>
        /// <para>用英文输出</para>
        /// </summary>
        [NameInMap("IntroductionPrompt")]
        [Validation(Required=false)]
        public string IntroductionPrompt { get; set; }

        /// <summary>
        /// <para>Custom requirements for key points</para>
        /// 
        /// <b>Example:</b>
        /// <para>用英文输出</para>
        /// </summary>
        [NameInMap("KeyPointPrompt")]
        [Validation(Required=false)]
        public string KeyPointPrompt { get; set; }

        /// <summary>
        /// <para>User-defined model name</para>
        /// 
        /// <b>Example:</b>
        /// <para>quanmiao-max、quanmiao-plus</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>Conversation ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a3b5eb35-6b28-4cf9-ac09-1dec25ab4df6</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Custom requirements for the summary content</para>
        /// 
        /// <b>Example:</b>
        /// <para>用英文输出</para>
        /// </summary>
        [NameInMap("SummaryPrompt")]
        [Validation(Required=false)]
        public string SummaryPrompt { get; set; }

        /// <summary>
        /// <para>Unique identifier (UUID) of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2587495.html">Workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>Content to generate the summary from. If not empty, this value takes precedence over docId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>要进行导读的内容</para>
        /// </summary>
        [NameInMap("referenceContent")]
        [Validation(Required=false)]
        public string ReferenceContent { get; set; }

    }

}
