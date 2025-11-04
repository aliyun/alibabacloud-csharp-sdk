// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class DeleteChunkShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of text chunks to be deleted. You can specify up to 10 chunk IDs at a time.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ChunkIds")]
        [Validation(Required=false)]
        public string ChunkIdsShrink { get; set; }

        /// <summary>
        /// <para>The knowledge base ID, which is the <c>Data.Id</c> parameter returned by <b>CreateIndex</b>.</para>
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
