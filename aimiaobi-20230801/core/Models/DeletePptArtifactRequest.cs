// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class DeletePptArtifactRequest : TeaModel {
        [NameInMap("PptArtifactId")]
        [Validation(Required=false)]
        public string PptArtifactId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-xx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
