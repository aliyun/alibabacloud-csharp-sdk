// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunMultiDocIntroductionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Array of document IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DocIds")]
        [Validation(Required=false)]
        public string DocIdsShrink { get; set; }

        /// <summary>
        /// <para>Custom prompt for key points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请简明扼要</para>
        /// </summary>
        [NameInMap("KeyPointPrompt")]
        [Validation(Required=false)]
        public string KeyPointPrompt { get; set; }

        /// <summary>
        /// <para>Name of the custom model to use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quanmiao-max、quanmiao-plus</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>Session ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75bf82fa-b71b-45d7-ae40-0b00e496cd9e</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Custom prompt for the summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请简明扼要</para>
        /// </summary>
        [NameInMap("SummaryPrompt")]
        [Validation(Required=false)]
        public string SummaryPrompt { get; set; }

        /// <summary>
        /// <para>Unique identifier of the Alibaba Cloud Model Studio workspace. To get this ID, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get the workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-2setzb9x4ewsd</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
