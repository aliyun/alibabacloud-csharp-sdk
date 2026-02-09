// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetPptArtifactRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5232136</para>
        /// </summary>
        [NameInMap("PptArtifactId")]
        [Validation(Required=false)]
        public int? PptArtifactId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-az2gglxxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
