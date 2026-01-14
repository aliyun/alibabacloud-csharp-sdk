// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class UpdateKnowledgeBaseChunkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>content</para>
        /// </summary>
        [NameInMap("ChunkContent")]
        [Validation(Required=false)]
        public string ChunkContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("ChunkStatus")]
        [Validation(Required=false)]
        public string ChunkStatus { get; set; }

    }

}
