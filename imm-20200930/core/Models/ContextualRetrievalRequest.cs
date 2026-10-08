// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ContextualRetrievalRequest : TeaModel {
        /// <summary>
        /// <para>The dataset used for retrieval.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The conversation history and tool calling history. The latest message is at the end (index n-1), and the oldest message is at the beginning (index 0). The messages must be in user-assistant pairs, with a total count of 2*n+1, and the length of the latest question cannot exceed 1,000 characters. The conversation history is limited to 100 messages.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<ContextualMessage> Messages { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information about how to obtain the project name, see <a href="https://www.alibabacloud.com/help/en/imm/getting-started/create-a-project-1">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable only the recall process (embedding search). If this parameter is set to true, the returned data is not reranked, which allows you to customize the reranking process. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RecallOnly")]
        [Validation(Required=false)]
        public bool? RecallOnly { get; set; }

        /// <summary>
        /// <para>The list of smart cluster IDs, which are used to retrieve files within specific smart clusters.</para>
        /// </summary>
        [NameInMap("SmartClusterIds")]
        [Validation(Required=false)]
        public List<string> SmartClusterIds { get; set; }

    }

}
