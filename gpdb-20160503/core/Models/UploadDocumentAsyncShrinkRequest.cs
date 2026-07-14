// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UploadDocumentAsyncShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The size of overlapping data between consecutive chunks. The maximum value of this parameter cannot be greater than the value of the ChunkSize parameter.</para>
        /// <remarks>
        /// <para> This parameter prevents context loss caused by data truncation. For example, when you upload long text, you can retain specific overlapping text content between consecutive chunks for better context understanding.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ChunkOverlap")]
        [Validation(Required=false)]
        public int? ChunkOverlap { get; set; }

        /// <summary>
        /// <para>The strategy for processing large data: the size of each chunk when data is split into smaller parts. Maximum value: 2048.</para>
        /// 
        /// <b>Example:</b>
        /// <para>250</para>
        /// </summary>
        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// <para>The name of the document collection.</para>
        /// <remarks>
        /// <para>Created by the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> operation. You can call the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> operation to query the created document collections.</para>
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
        /// <para>The ID of the instance that has vector engine optimization enabled. You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in the target region, including instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the document loader. If you do not specify this parameter, the system automatically selects the corresponding document loader based on the file name extension in the following order. Valid values:</para>
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
        /// <item><description>ADBPGLoader (paid, first 3,000 pages free): .pdf, .doc, .docx, .ppt, .pptx, .xls, .xlsx, .xlsm, .csv, .txt, .jpg, .jpeg, .png, .bmp, .gif, .md, .html, .epub, .mobi, and .rtf</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PyMuPDFLoader</para>
        /// </summary>
        [NameInMap("DocumentLoaderName")]
        [Validation(Required=false)]
        public string DocumentLoaderName { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only document understanding and chunking without vectorization and storage. Default value: false.</para>
        /// <remarks>
        /// <para> You can set this parameter to true to check the chunking results and then optimize as needed.</para>
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
        /// <list type="bullet">
        /// <item><description>The file name must include file name extension, such as .json, .md, or .pdf.</description></item>
        /// <item><description>Supported image file extensions include .bmp, .jpg, .jpeg, .png, and .tiff.</description></item>
        /// <item><description>You can upload images by using an archive. The archive file name must include file name extension. Supported archive extensions include .tar, .gz, and .zip.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mydoc.txt</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The publicly accessible URL of the document.</para>
        /// <remarks>
        /// <para>Use the SDK to call this operation. The SDK provides a method named UploadDocumentAsyncAdvance that allows you to directly upload local files.
        /// If the URL points to an image archive, the number of images in the archive cannot exceed 100.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: 
        /// The maximum size of an image uploaded by using multimodal-embedding-v1 is 3 MB.</para>
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
        /// <para>The metadata. The value of this parameter must be the same as the Metadata parameter specified when you call the CreateDocumentCollection operation.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string MetadataShrink { get; set; }

        /// <summary>
        /// <para>The namespace. Default value: public. You can call the CreateNamespace operation to create a namespace and call the ListNamespaces operation to query the list of namespaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mynamespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The password of the namespace. The value is specified by the CreateNamespace operation.</para>
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
        /// <para>The separators used to split large data.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This is an important parameter that determines the effectiveness of data chunking. This parameter is related to the splitter specified by the TextSplitterName parameter.</description></item>
        /// <item><description>In most cases, you do not need to specify this parameter. The server assigns separators based on the value of the TextSplitterName parameter.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Separators")]
        [Validation(Required=false)]
        public string SeparatorsShrink { get; set; }

        /// <summary>
        /// <para>The splitting model to use when DocumentLoaderName is set to ADBPGLoader and TextSplitterName is set to LLMSplitter. Default value: qwen3-8b.</para>
        /// <remarks>
        /// <para>Currently supported splitting models:
        /// qwq-plus, qwq-plus-latest,
        /// qwen-max, qwen-max-latest,
        /// qwen-plus, qwen-plus-latest,
        /// qwen-turbo, qwen-turbo-latest,
        /// qwen3-235b-a22b, qwen3-32b, qwen3-30b-a3b,
        /// qwen3-14b, qwen3-8b, qwen3-4b, qwen3-1.7b, qwen3-0.6b,
        /// qwq-32b
        /// qwen2.5-14b-instruct-1m, qwen2.5-7b-instruct-1m
        /// qwen2.5-72b-instruct, qwen2.5-32b-instruct,
        /// qwen2.5-14b-instruct, qwen2.5-7b-instruct,
        /// qwen2.5-3b-instruct, qwen2.5-1.5b-instruct, qwen2.5-0.5b-instruct</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-8b</para>
        /// </summary>
        [NameInMap("SplitterModel")]
        [Validation(Required=false)]
        public string SplitterModel { get; set; }

        /// <summary>
        /// <para>The name of the text splitter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ChineseRecursiveTextSplitter</b>: inherits from RecursiveCharacterTextSplitter and uses `[&quot;</description></item>
        /// </list>
        /// <para>&quot;,&quot;
        /// &quot;, &quot;。|!|?&quot;, &quot;\.\s|\!\s|\?\s&quot;, &quot;;|;\s&quot;, &quot;,|,\s&quot;]` as the default separators with regular expression matching.</para>
        /// <list type="bullet">
        /// <item><description><b>RecursiveCharacterTextSplitter</b>: uses `[&quot;</description></item>
        /// </list>
        /// <para>&quot;, &quot;
        /// &quot;, &quot; &quot;, &quot;&quot;]` as the default separators. This splitter supports splitting code in languages such as C++, Go, Java, JS, PHP, Proto, Python, RST, Ruby, Rust, Scala, Swift, Markdown, LaTeX, HTML, Sol, and C Sharp.</para>
        /// <list type="bullet">
        /// <item><description><b>SpacyTextSplitter</b>: uses `</description></item>
        /// </list>
        /// <para>` as the default separator and the spaCy en_core_web_sm model. This splitter provides better splitting results.</para>
        /// <list type="bullet">
        /// <item><description><b>MarkdownHeaderTextSplitter</b>: splits text in the format of [(&quot;#&quot;, &quot;head1&quot;), (&quot;##&quot;, &quot;head2&quot;), (&quot;###&quot;, &quot;head3&quot;), (&quot;####&quot;, &quot;head4&quot;)]. This splitter is suitable for Markdown text.</description></item>
        /// <item><description><b>LLMSplitter</b>: uses an LLM to split text. The default model is qwen3-8b. This splitter takes effect only when ADBPGLoader is selected as the document loader.</description></item>
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
        /// <list type="bullet">
        /// <item><description>For complex documents with disorganized layouts and formats, enable VL-enhanced content recognition.</description></item>
        /// <item><description>After VL-enhanced content recognition is enabled, document processing takes longer.</description></item>
        /// <item><description>After VL-enhanced content recognition is enabled, images in the document cannot be stored or recalled.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>You can identify the title text, mark the text in the metadata, and then combine the text with the upper-level title for text enhancement.</para>
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
