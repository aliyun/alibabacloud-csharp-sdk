// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDocumentResponseBody : TeaModel {
        /// <summary>
        /// <para>The URL of the chunked file. The URL is valid for 2 hours. The file is in JSONL format, and each line is in the following format: {&quot;page_content&quot;:&quot;<em>****&quot;, &quot;metadata&quot;: {&quot;<b>&quot;:&quot;</b></em>&quot;,&quot;<b>&quot;:&quot;</b>*&quot;}</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oss.xxx/music_chunk.jsonl">http://oss.xxx/music_chunk.jsonl</a></para>
        /// </summary>
        [NameInMap("ChunkFileUrl")]
        [Validation(Required=false)]
        public string ChunkFileUrl { get; set; }

        /// <summary>
        /// <para>The number of chunks generated from the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DocsCount")]
        [Validation(Required=false)]
        public int? DocsCount { get; set; }

        /// <summary>
        /// <para>The name of the document loader.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RapidOCRPDFLoader</para>
        /// </summary>
        [NameInMap("DocumentLoader")]
        [Validation(Required=false)]
        public string DocumentLoader { get; set; }

        /// <summary>
        /// <para>The URL of the Markdown result file parsed by ADBPGLoader. The URL is valid for 2 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oss.xxx/adbpg_loader_result.md">http://oss.xxx/adbpg_loader_result.md</a></para>
        /// </summary>
        [NameInMap("DocumentLoaderResultFileUrl")]
        [Validation(Required=false)]
        public string DocumentLoaderResultFileUrl { get; set; }

        /// <summary>
        /// <para>The file name extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>txt</para>
        /// </summary>
        [NameInMap("FileExt")]
        [Validation(Required=false)]
        public string FileExt { get; set; }

        /// <summary>
        /// <para>The MD5 hash of the file.</para>
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
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>music.txt</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The file size in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>The download URL of the document. The URL is valid for 2 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oss.xxx/music.txt">http://oss.xxx/music.txt</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The document version. This value is incremented by 1 each time the same document is updated and uploaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FileVersion")]
        [Validation(Required=false)]
        public int? FileVersion { get; set; }

        /// <summary>
        /// <para>The detailed information returned by the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The download URL of the plain text chunks without metadata. Each line represents a chunk. The URL is valid for 2 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oss.xxx/music_plain_chunk.txt">http://oss.xxx/music_plain_chunk.txt</a></para>
        /// </summary>
        [NameInMap("PlainChunkFileUrl")]
        [Validation(Required=false)]
        public string PlainChunkFileUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The execution status of the API operation. Valid values:</para>
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
        /// <para>The name of the text splitter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChineseRecursiveTextSplitter</para>
        /// </summary>
        [NameInMap("TextSplitter")]
        [Validation(Required=false)]
        public string TextSplitter { get; set; }

    }

}
