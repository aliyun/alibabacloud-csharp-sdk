// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunDeepWritingRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Cursor")]
        [Validation(Required=false)]
        public int? Cursor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>95c2fbe6-5a20-4fc2-8a93-376ed05fbe13</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-ir8zkqry2fncaxwq</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
