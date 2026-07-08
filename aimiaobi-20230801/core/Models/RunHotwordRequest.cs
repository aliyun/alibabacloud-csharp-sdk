// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunHotwordRequest : TeaModel {
        /// <summary>
        /// <para>Document ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84ufBYEeLMZOjRFo84HJ7ySL3Efr55</para>
        /// </summary>
        [NameInMap("DocId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <para>Name of the custom model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quanmiao-max、quanmiao-plus</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>Prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>提示词</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>Document content to extract hotwords from. If not empty, extract hotwords from this content. If empty, extract hotwords using the DocId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>关联内容</para>
        /// </summary>
        [NameInMap("ReferenceContent")]
        [Validation(Required=false)]
        public string ReferenceContent { get; set; }

        /// <summary>
        /// <para>Session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e32a1a3f-1f7e-41dd-b888-ef1d91b96d1e</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Unique identifier of the Alibaba Cloud Model Studio workspace. To get this ID, see <a href="https://help.aliyun.com/document_detail/2782167.html">Workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-baw8as25ll3wnzjr</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
