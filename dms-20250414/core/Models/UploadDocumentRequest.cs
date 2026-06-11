// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UploadDocumentRequest : TeaModel {
        /// <summary>
        /// <para>The number of overlapping characters between adjacent chunks. This value cannot exceed <c>ChunkSize</c>. The default is 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ChunkOverlap")]
        [Validation(Required=false)]
        public long? ChunkOverlap { get; set; }

        /// <summary>
        /// <para>The size of each document chunk. The default is 250, and the maximum is 2,048.</para>
        /// 
        /// <b>Example:</b>
        /// <para>250</para>
        /// </summary>
        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public long? ChunkSize { get; set; }

        /// <summary>
        /// <para>The description of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the document loader. The default is <c>ADBPGLoader</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADBPGLoader</para>
        /// </summary>
        [NameInMap("DocumentLoaderName")]
        [Validation(Required=false)]
        public string DocumentLoaderName { get; set; }

        /// <summary>
        /// <para>The name of the document.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.md</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-***</para>
        /// </summary>
        [NameInMap("KbUuid")]
        [Validation(Required=false)]
        public string KbUuid { get; set; }

        /// <summary>
        /// <para>The OSS location of the input file. Construct this path by appending the file name to the <c>UploadDir</c> value returned by the <c>DescribeKnowledgeBaseUploadSignature</c> operation.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>An array of strings used to split text.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This critical parameter affects data chunking results and is related to the splitter specified by <c>TextSplitterName</c>.</para>
        /// </description></item>
        /// <item><description><para>In most cases, you can omit this parameter. The service automatically assigns default separators based on <c>TextSplitterName</c>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Separators")]
        [Validation(Required=false)]
        public List<string> Separators { get; set; }

        /// <summary>
        /// <para>The splitter model to use. The default is <c>qwen3-8b</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-8b</para>
        /// </summary>
        [NameInMap("SplitterModel")]
        [Validation(Required=false)]
        public string SplitterModel { get; set; }

        /// <summary>
        /// <para>The name of the text splitter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChineseRecursiveTextSplitter</para>
        /// </summary>
        [NameInMap("TextSplitterName")]
        [Validation(Required=false)]
        public string TextSplitterName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable visual-linguistic (VL) enhanced content recognition for complex documents. The default is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VlEnhance")]
        [Validation(Required=false)]
        public bool? VlEnhance { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable title enhancement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ZhTitleEnhance")]
        [Validation(Required=false)]
        public bool? ZhTitleEnhance { get; set; }

    }

}
