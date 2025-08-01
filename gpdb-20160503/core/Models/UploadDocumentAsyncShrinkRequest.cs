// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UploadDocumentAsyncShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The size of data that is overlapped between consecutive chunks. The maximum value of this parameter cannot be greater than the value of the ChunkSize parameter.</para>
        /// <remarks>
        /// <para> This parameter is used to prevent context missing that may occur due to data truncation. For example, when you upload a long text, you can retain specific overlapped text content between consecutive chunks to better understand the context.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ChunkOverlap")]
        [Validation(Required=false)]
        public int? ChunkOverlap { get; set; }

        /// <summary>
        /// <para>Strategy for processing large data: the size of each chunk when the data is split into smaller parts. Maximum value is 2048.</para>
        /// 
        /// <b>Example:</b>
        /// <para>250</para>
        /// </summary>
        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// <para>The name of the document library. </para>
        /// <remarks>
        /// <para>Created by the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> API. You can call the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> API to view the document libraries that have already been created.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document</para>
        /// </summary>
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        /// <summary>
        /// <para>Instance ID with vector engine optimization acceleration enabled. You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> API to view details of all AnalyticDB PostgreSQL instances in the target region, including the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the document loader. You do not need to specify this parameter. A document loader is automatically specified based on the file extension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UnstructuredHTMLLoader: <c>.html</c></description></item>
        /// <item><description>UnstructuredMarkdownLoader: <c>.md</c></description></item>
        /// <item><description>PyMuPDFLoader: <c>.pdf</c></description></item>
        /// <item><description>PyPDFLoader: <c>.pdf</c></description></item>
        /// <item><description>RapidOCRPDFLoader: <c>.pdf</c></description></item>
        /// <item><description>PDFWithImageRefLoader: <c>.pdf</c> (with the text-image association feature)</description></item>
        /// <item><description>JSONLoader: <c>.json</c></description></item>
        /// <item><description>CSVLoader: <c>.csv</c></description></item>
        /// <item><description>RapidOCRLoader: <c>.png</c>, <c>.jpg</c>, <c>.jpeg</c>, and <c>.bmp</c></description></item>
        /// <item><description>UnstructuredFileLoader: <c>.eml</c>, <c>.msg</c>, <c>.rst</c>, <c>.txt</c>, <c>.docx</c>, <c>.epub</c>, <c>.odt</c>, <c>.pptx</c>, and <c>.tsv</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PyMuPDFLoader</para>
        /// </summary>
        [NameInMap("DocumentLoaderName")]
        [Validation(Required=false)]
        public string DocumentLoaderName { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only document understanding and chunking, but not vectorization and storage. Default value: false.</para>
        /// <remarks>
        /// <para> You can set this parameter to true, check the chunking effect, and then perform optimization if needed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The file name of the document.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>We recommend that you add an extension to the file name. Examples: <c>.json</c>, <c>.md</c>, and <c>.pdf</c>. If you do not add an extension, the default loader designed for unstructured data is used.</para>
        /// </description></item>
        /// <item><description><para>If an image file is involved, the file name must contain an extension. The following extensions are supported: <c>.bmp</c>, <c>.jpg</c>, <c>.jpeg</c>, <c>.png</c>, and <c>.tiff</c>.</para>
        /// </description></item>
        /// <item><description><para>You can use a compressed package to upload images. The package file name must contain an extension. Supported package file extensions: <c>.tar</c>, <c>.gz</c>, and <c>.zip</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mydoc.txt</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The URL of the publicly accessible document.</para>
        /// <remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>It is recommended to call this interface using the SDK, which provides a method called UploadDocumentAsyncAdvance for directly uploading local files. &gt; - If the URL points to an image archive, the number of images in the archive should not exceed 100.</description></item>
        /// </list>
        /// </remarks>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xx/mydoc.txt">https://xx/mydoc.txt</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The metadata. The value of this parameter must be the same as the Metadata parameter that is specified when you call the CreateDocumentCollection operation.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string MetadataShrink { get; set; }

        /// <summary>
        /// <para>Namespace, default is public. You can create one through the CreateNamespace interface and view the list via the ListNamespaces interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mynamespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The password corresponding to the namespace.  &gt; This value is specified by the CreateNamespace interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpassword</para>
        /// </summary>
        [NameInMap("NamespacePassword")]
        [Validation(Required=false)]
        public string NamespacePassword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The separators that are used to split large amounts of data.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This is an important parameter that determines the chunking effect. This parameter is related to the splitter that is specified by the TextSplitterName parameter.</para>
        /// </description></item>
        /// <item><description><para>In most cases, you do not need to specify this parameter. The server assigns separators based on the value of the TextSplitterName parameter.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Separators")]
        [Validation(Required=false)]
        public string SeparatorsShrink { get; set; }

        /// <summary>
        /// <para>The name of the splitter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ChineseRecursiveTextSplitter</b>: inherits from RecursiveCharacterTextSplitter, uses <c>[&quot;\\n\\n&quot;,&quot;\\n&quot;, &quot;。|!|?&quot;, &quot;\\.\\s|\\!\\s|\\?\\s&quot;, &quot;;|;\\s&quot;, &quot;,|,\\s&quot;]</c> as separators by default, and uses regular expressions to match text.</description></item>
        /// <item><description><b>RecursiveCharacterTextSplitter</b>: uses <c>[&quot;\\n\\n&quot;, &quot;\\n&quot;, &quot; &quot;, &quot;&quot;]</c> as separators by default. The splitter supports splitting code in languages such as <c>C++, Go, Java, JS, PHP, Proto, Python, RST, Ruby, Rust, Scala, Swift, Markdown, LaTeX, HTML, Sol, and C Sharp</c>.</description></item>
        /// <item><description><b>SpacyTextSplitter</b>: uses <c>\\n\\n</c> as separators by default and uses the en_core_web_sm model of spaCy. The splitter can obtain better splitting effect.</description></item>
        /// <item><description><b>MarkdownHeaderTextSplitter</b>: splits text in the <c>[(&quot;#&quot;, &quot;head1&quot;), (&quot;##&quot;, &quot;head2&quot;), (&quot;###&quot;, &quot;head3&quot;), (&quot;####&quot;, &quot;head4&quot;)]</c> format. The splitter is suitable for Markdown text.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ChineseRecursiveTextSplitter</para>
        /// </summary>
        [NameInMap("TextSplitterName")]
        [Validation(Required=false)]
        public string TextSplitterName { get; set; }

        [NameInMap("VlEnhance")]
        [Validation(Required=false)]
        public bool? VlEnhance { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable title enhancement.</para>
        /// <remarks>
        /// <para> You can determine the title text, mark the text in the metadata, and then combine the text with the upper-level title to implement text enhancement.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ZhTitleEnhance")]
        [Validation(Required=false)]
        public bool? ZhTitleEnhance { get; set; }

    }

}
