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
        /// <para>The file ID, which is the <c>FileId</c> returned by the <b>AddFile</b> operation. You can also obtain it from the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">application data</a>-Files&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">application data</a>-Files tab in the Alibaba Cloud Model Studio console by clicking the ID icon next to the corresponding file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doc_c134aa2073204a5d936d870bf960f56axxxxxxxx</para>
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        /// <summary>
        /// <para>Specifies whether the text chunk participates in knowledge base retrieval. Valid values:</para>
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
        /// <para>The knowledge base ID, which is the <c>Data.Id</c> returned when you call the <b>CreateIndex</b> operation, or retrieved from the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/knowledge-base">knowledge base</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/knowledge-base">knowledge base</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The new content of the text chunk. The content length must be between 10 and 6,000 characters, and must not exceed the maximum segment length set when the knowledge base was created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The type of certainty obtained in philosophy is not scientific certainty (that is, certainty that is the same for every rational mind), but a kind of personal conviction that can only be obtained in the overall nature of humanity. Every form of philosophy differs from science in that no philosophy has received universal acceptance..</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The new title of the text chunk. The length limit is 0–50 characters. An empty string is allowed. If you pass an empty string, the existing title is cleared. If you do not pass this parameter, the original title is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What is philosophy</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
