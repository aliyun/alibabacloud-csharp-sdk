// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateChunkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-5ip55o1zrzxx_09fe52x_table_033b551e10024029992e79767b151fxx_10024xx_0</para>
        /// </summary>
        [NameInMap("ChunkId")]
        [Validation(Required=false)]
        public string ChunkId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc_c134aa2073204a5d936d870bf960f56axxxxxxxx</para>
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDisplayedChunkContent")]
        [Validation(Required=false)]
        public bool? IsDisplayedChunkContent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
