// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateChunkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the text chunk to be modified. You can find it in the Node.Metadata._id field returned by <b>ListChunks</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-5ip55o1zrzxx_09fe52x_table_033b551e10024029992e79767b151fxx_10024xx_0</para>
        /// </summary>
        [NameInMap("ChunkId")]
        [Validation(Required=false)]
        public string ChunkId { get; set; }

        /// <summary>
        /// <para>The file ID, which is the <c>FileId</c> returned by <b>AddFile</b>. You can also go to the <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> page. Click the ID icon next to your file to get its ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc_c134aa2073204a5d936d870bf960f56axxxxxxxx</para>
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        /// <summary>
        /// <para>Specifies whether this text chunk participates in knowledge base retrieval. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDisplayedChunkContent")]
        [Validation(Required=false)]
        public bool? IsDisplayedChunkContent { get; set; }

        /// <summary>
        /// <para>The knowledge base ID, which is the <c>Data.Id</c> returned by <b>CreateIndex</b>. You can also get it on the <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/knowledge-base">Knowledge Base</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The new content of the chunk. The content must be between 10 and 6,000 characters in length and cannot exceed the maximum chunk length set when the knowledge base was created.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The new title of the chunk. The title must be 0 to 50 characters in length and can be an empty string. If you specify an empty string, the existing title is cleared. If you do not pass this parameter, the original title remains unchanged.</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
