// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDocumentResponseBody : TeaModel {
        /// <summary>
        /// <para>URL of the split file, valid for 2 hours. The file format is JSONL, with each line formatted as <c>{&quot;page_content&quot;:&quot;*****&quot;, &quot;metadata&quot;: {&quot;**&quot;:&quot;***&quot;,&quot;**&quot;:&quot;***&quot;}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oss.xxx/music_chunk.jsonl">http://oss.xxx/music_chunk.jsonl</a></para>
        /// </summary>
        [NameInMap("ChunkFileUrl")]
        [Validation(Required=false)]
        public string ChunkFileUrl { get; set; }

        /// <summary>
        /// <para>Number of documents after splitting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DocsCount")]
        [Validation(Required=false)]
        public int? DocsCount { get; set; }

        /// <summary>
        /// <para>Name of the document loader.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RapidOCRPDFLoader</para>
        /// </summary>
        [NameInMap("DocumentLoader")]
        [Validation(Required=false)]
        public string DocumentLoader { get; set; }

        /// <summary>
        /// <para>File extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>txt</para>
        /// </summary>
        [NameInMap("FileExt")]
        [Validation(Required=false)]
        public string FileExt { get; set; }

        /// <summary>
        /// <para>MD5 value of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b8078c9591413550f8963e37e24abcea</para>
        /// </summary>
        [NameInMap("FileMd5")]
        [Validation(Required=false)]
        public string FileMd5 { get; set; }

        /// <summary>
        /// <para>The last modified time of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-11-01 10:01:01.123456</para>
        /// </summary>
        [NameInMap("FileMtime")]
        [Validation(Required=false)]
        public string FileMtime { get; set; }

        /// <summary>
        /// <para>File name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>music.txt</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>File size, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>Download URL of the document, valid for 2 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oss.xxx/music.txt">http://oss.xxx/music.txt</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>Document version. This value increments by 1 each time the same document is updated and uploaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FileVersion")]
        [Validation(Required=false)]
        public int? FileVersion { get; set; }

        /// <summary>
        /// <para>Detailed information returned by the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Download URL for the plain text (without metadata) after splitting, each line is a chunk, valid for 2 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oss.xxx/music_plain_chunk.txt">http://oss.xxx/music_plain_chunk.txt</a></para>
        /// </summary>
        [NameInMap("PlainChunkFileUrl")]
        [Validation(Required=false)]
        public string PlainChunkFileUrl { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Source of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>API execution status, with values as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: Execution succeeded.</description></item>
        /// <item><description><b>fail</b>: Execution failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Name of the text splitter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChineseRecursiveTextSplitter</para>
        /// </summary>
        [NameInMap("TextSplitter")]
        [Validation(Required=false)]
        public string TextSplitter { get; set; }

    }

}
