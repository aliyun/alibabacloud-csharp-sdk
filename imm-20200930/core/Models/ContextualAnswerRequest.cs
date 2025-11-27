// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ContextualAnswerRequest : TeaModel {
        /// <summary>
        /// <para>The content of the files involved in the current Q&amp;A. It is recommended to use the return value of the ContextualRetrieval interface as input.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<ContextualFile> Files { get; set; }

        /// <summary>
        /// <para>Yes, the history of conversations and tool invocations. The latest message is at the end (index n-1), and the oldest message is at the beginning (index 0).
        /// It must be in the form of user-assistant pairs, with a total count of 2*n+1, and the length of the latest question should not exceed 1000 characters.
        /// The length of the historical conversation is limited to 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<ContextualMessage> Messages { get; set; }

        /// <summary>
        /// <para>Project name. For how to obtain it, see <a href="https://help.aliyun.com/zh/imm/getting-started/create-a-project-1?spm=a2c4g.11186623.help-menu-search-62354.d_0">Creating a Project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
