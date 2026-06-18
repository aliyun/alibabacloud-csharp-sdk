// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateChunkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the text chunk to modify. You can obtain this value by calling the <b>ListChunks</b> operation. The value is in the Node.Metadata._id field of the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-5ip55o1zrzxx_09fe52x_xxxxx_033b551e10024029992e79767b151fxx_10024xx_0</para>
        /// </summary>
        [NameInMap("ChunkId")]
        [Validation(Required=false)]
        public string ChunkId { get; set; }

        /// <summary>
        /// <para>The file ID. This is the <c>FileId</c> returned by the <b>AddFile</b> operation. You can also obtain it from the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a> - Files&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> - Files tab in the Model Studio console by clicking the ID icon next to the corresponding file.</para>
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
        /// <item><description>true: Participates.</description></item>
        /// <item><description>false: Does not participate.</description></item>
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
        /// <para>The knowledge base ID. This is the <c>Data.Id</c> returned by the <b>CreateIndex</b> operation, or you can obtain it from the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/knowledge-base">Knowledge Base</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/knowledge-base">Knowledge Base</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The new content of the text chunk. The content length must be between 10 and 6000 characters and cannot exceed the maximum segment length specified when the knowledge base was created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>在哲学中所获得的确定性类型不是科学的确定性(即对每个人的理智来说都一样的确定性)，而是一种要在人类的整体本质中才能获得的亲证。哲学的每一形态都不同于科学，因为所有的哲学都没有得到一致的认可...</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The new title of the text chunk. The length is limited to 0 to 50 characters. An empty string is allowed. If you pass an empty string, the existing title is cleared. If you do not pass this parameter, the original title is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>什么是哲学</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
