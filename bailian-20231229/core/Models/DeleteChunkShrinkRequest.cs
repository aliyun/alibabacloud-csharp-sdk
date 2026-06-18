// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class DeleteChunkShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of text chunks to delete. A maximum of 10 text chunk IDs can be specified in a single request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ChunkIds")]
        [Validation(Required=false)]
        public string ChunkIdsShrink { get; set; }

        /// <summary>
        /// <para>The knowledge base ID, which is the <c>Data.Id</c> returned by the <b>CreateIndex</b> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

    }

}
