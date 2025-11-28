// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UploadDocumentAsyncRequest : TeaModel {
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
        /// <para>Specifies the document loader to use for processing the file. If this parameter is omitted, the system automatically selects a loader based on the file\&quot;s extension.Valid Values:[List of valid loader names would go here] Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UnstructuredHTMLLoader: .html</description></item>
        /// <item><description>UnstructuredMarkdownLoader: .md</description></item>
        /// <item><description>PyMuPDFLoader: .pdf</description></item>
        /// <item><description>PyPDFLoader: .pdf</description></item>
        /// <item><description>RapidOCRPDFLoader: .pdf</description></item>
        /// <item><description>PDFWithImageRefLoader: .pdf (with the text-image association feature)</description></item>
        /// <item><description>JSONLoader: .json</description></item>
        /// <item><description>CSVLoader: .csv</description></item>
        /// <item><description>RapidOCRLoader: .png, .jpg, .jpeg, and .bmp</description></item>
        /// <item><description>UnstructuredFileLoader: .eml, .msg, .rst, .txt, .docx, .epub, .odt, .pptx, and .tsv</description></item>
        /// <item><description>ADBPGLoader (free of charge for the first 3,000 pages): .pdf, .doc, .docx, .ppt, .pptx, .xls, .xlsx, .xlsm, .csv, .txt, .jpg, .jpeg, .png, .bmp, .gif, .md, .html, .epub, .mobi, and .rtf</description></item>
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
        /// <para>The name of the file being uploaded.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>File name: .json, .md, and .pdf.</para>
        /// </description></item>
        /// <item><description><para>Images: .bmp,. jpg,. jpeg,. png, and. tiff.</para>
        /// </description></item>
        /// <item><description><para>Compressed packages. The package file name must contain an extension: .tar, .gz, and .zip.</para>
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
        public Dictionary<string, object> Metadata { get; set; }

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
        public List<string> Separators { get; set; }

        /// <summary>
        /// <para>When DocumentLoaderName is set to ADBPGLoader and TextSplitterName is set to LLMSplitter, you can specify the splitting model. Default Value: qwen3-8b.</para>
        /// <remarks>
        /// <para> Supported splitting models: qwq-plus, qwq-plus-latest, qwen-max, qwen-max-latest, qwen-plus, qwen-plus-latest, qwen-turbo, qwen-turbo-latest, qwen3-235b-a22b, qwen3-32b,qwen3-30b-a3b, qwen3-14b, qwen3-8b, qwen3-4b, qwen3-1.7b, qwen3-0.6b, qwq-32b qwen2.5-14b-instruct-1m, qwen2.5-7b-instruct-1m, qwen2.5-72b-Instruct, qwen2.5-32b-Instruct, qwen2.5-14b-Instruct, qwen2.5-7b-Instruct, qwen2.5-3b-instruct, qwen2.5-1.5b-instruct, qwen2.5-0.5b-instruct.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-8b</para>
        /// </summary>
        [NameInMap("SplitterModel")]
        [Validation(Required=false)]
        public string SplitterModel { get; set; }

        /// <summary>
        /// <para>The name of the separator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ChineseRecursiveTextSplitter</b>: Inherits from RecursiveCharacterTextSplitter and, by default, uses the delimiters<c>[&quot;\\n\\n&quot;,&quot;\\n&quot;, &quot;。 |! |?&quot;, &quot;\\.\\s|\\! \\s|\\?\\s&quot;, &quot;;|;\\s&quot;, &quot;,|,\\s&quot;] </c>, employing regular expressions to match text.</description></item>
        /// <item><description><b>RecursiveCharacterTextSplitter</b>: Uses the delimiters <c>[&quot;\\n\\n&quot;, &quot;\\n&quot;, &quot; &quot;, &quot;&quot;]</c> by default. The splitter supports splitting code in languages such as C++, Go, Java, JS, PHP, Proto, Python, RST, Ruby, Rust, Scala, Swift, Markdown, LaTeX, HTML, Sol, and C Sharp.</description></item>
        /// <item><description><b>SpacyTextSplitter</b>: Uses the delimiters <c>\\n\\n</c> by default and leverages the spaCy en_core_web_sm model. The splitter can achieve better text splitting performance.</description></item>
        /// <item><description><b>MarkdownHeaderTextSplitter</b>: Splits text in the [(&quot;#&quot;, &quot;head1&quot;), (&quot;##&quot;, &quot;head2&quot;), (&quot;###&quot;, &quot;head3&quot;), (&quot;####&quot;, &quot;head4&quot;) format. This splitter works well with Markdown text.</description></item>
        /// <item><description><b>LLMSplitter</b>: Use LLM to split text. The default model is qwen3-8b. Currently, this splitter works only when ADBPGLoader is selected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ChineseRecursiveTextSplitter</para>
        /// </summary>
        [NameInMap("TextSplitterName")]
        [Validation(Required=false)]
        public string TextSplitterName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable VL-enhanced content recognition for complex documents. Default value: false.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>For complex documents with confusing typesetting and formatting, we recommend that you enable VL-enhanced content recognition.</para>
        /// </description></item>
        /// <item><description><para>Document processing time is longer after VL-enhanced content recognition is enabled.</para>
        /// </description></item>
        /// <item><description><para>After VL-enhanced content recognition is enabled, images in documents cannot be stored or recalled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
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
