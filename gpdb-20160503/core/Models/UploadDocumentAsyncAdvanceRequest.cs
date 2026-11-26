// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UploadDocumentAsyncAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The size of overlapping data between consecutive chunks. The maximum value of this parameter cannot be greater than the value of the ChunkSize parameter.</para>
        /// <remarks>
        /// <para>This parameter is used to prevent context loss caused by data truncation. For example, when you upload long text, you can retain specific overlapping text content between consecutive chunks to better understand the context.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ChunkOverlap")]
        [Validation(Required=false)]
        public int? ChunkOverlap { get; set; }

        /// <summary>
        /// <para>The strategy for processing large amounts of data: the size of each chunk when data is split into smaller parts. Maximum value: 2048.</para>
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
        /// <para>Created by the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> operation. You can call the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> operation to view the created document collections.</para>
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
        /// <para>The ID of the instance for which vector engine optimization and acceleration is enabled. You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to view the details of all AnalyticDB for PostgreSQL instances in the target region, including the instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the document loader. If you do not specify this parameter, the system automatically selects the corresponding document loader in the following order based on the file name extension. Valid values:</para>
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
        /// <item><description>ADBPGLoader (paid, first 3,000 pages are free): .pdf, .doc, .docx, .ppt, .pptx, .xls, .xlsx, .xlsm, .csv, .txt, .jpg, .jpeg, .png, .bmp, .gif, .md, .html, .epub, .mobi, and .rtf</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PyMuPDFLoader</para>
        /// </summary>
        [NameInMap("DocumentLoaderName")]
        [Validation(Required=false)]
        public string DocumentLoaderName { get; set; }

        /// <summary>
        /// <para>Specifies whether to only perform document understanding and chunking without vectorization and storage. Default value: false.</para>
        /// <remarks>
        /// <para>You can set this parameter to true to check the chunking effect and then optimize it as needed.</para>
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
        /// <item><description>The file name must file name extension. Examples: .json, .md, and .pdf.</description></item>
        /// <item><description>Supported image file extensions include .bmp, .jpg, .jpeg, .png, and .tiff.</description></item>
        /// <item><description>You can use a compressed package to upload images. The file name of the compressed package must file name extension. Supported compressed package extensions include .tar, .gz, and .zip.</description></item>
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
        /// <para>The URL for public access to the document.</para>
        /// <remarks>
        /// <para>We recommend that you use an SDK to call this operation. The SDK provides a method named UploadDocumentAsyncAdvance, which allows you to directly upload local files.
        /// If the URL points to an image archive, the number of images in the current archive must not exceed 100.</para>
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
        public Stream FileUrlObject { get; set; }

        /// <summary>
        /// <para>The metadata. The value of this parameter must be the same as the Metadata parameter specified when the CreateDocumentCollection operation is called.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;title&quot;:&quot;mytitle&quot;,&quot;page&quot;:1}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <para>The namespace. Default value: public. You can call the CreateNamespace operation to create a namespace and call the ListNamespaces operation to view the namespace list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mynamespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The password corresponding to the namespace. This value is specified when the CreateNamespace operation is called.</para>
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
        /// <para>The separators used to split large amounts of data.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This is an important parameter that determines the effect of data chunking. This parameter is related to the splitter specified by the TextSplitterName parameter.</description></item>
        /// <item><description>In most cases, you do not need to specify this parameter. The server assigns separators based on the value of the TextSplitterName parameter.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Separators")]
        [Validation(Required=false)]
        public List<string> Separators { get; set; }

        /// <summary>
        /// <para>The splitting model. This parameter can be specified when ADBPGLoader is selected for DocumentLoaderName and LLMSplitter is selected for TextSplitterName. Default value: qwen3-8b.</para>
        /// <remarks>
        /// <para>Supported splitting models:
        /// qwq-plus, qwq-plus-latest,
        /// qwen-max, qwen-max-latest,
        /// qwen-plus, qwen-plus-latest,
        /// qwen-turbo, qwen-turbo-latest,
        /// qwen3-235b-a22b, qwen3-32b, qwen3-30b-a3b,
        /// qwen3-14b, qwen3-8b, qwen3-4b, qwen3-1.7b, qwen3-0.6b,
        /// qwq-32b,
        /// qwen2.5-14b-instruct-1m, qwen2.5-7b-instruct-1m,
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
        /// <para>The name of the splitter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ChineseRecursiveTextSplitter</b>: Inherits from RecursiveCharacterTextSplitter. By default, `[&quot;</description></item>
        /// </list>
        /// <para>&quot;,&quot;
        /// &quot;, &quot;。|!|?&quot;, &quot;.\s|!\s|?\s&quot;, &quot;;|;\s&quot;, &quot;,|,\s&quot;]` is used as the separator, and regular expressions are used to match text.</para>
        /// <list type="bullet">
        /// <item><description><b>RecursiveCharacterTextSplitter</b>: By default, `[&quot;</description></item>
        /// </list>
        /// <para>&quot;, &quot;
        /// &quot;, &quot; &quot;, &quot;&quot;]` is used as the separator. This splitter supports splitting code in languages such as C++, Go, Java, JS, PHP, Proto, Python, RST, Ruby, Rust, Scala, Swift, Markdown, LaTeX, HTML, Sol, and C Sharp.</para>
        /// <list type="bullet">
        /// <item><description><b>SpacyTextSplitter</b>: By default, `</description></item>
        /// </list>
        /// <para>` is used as the separator, and the en_core_web_sm model of spaCy is used. This splitter can achieve better splitting effects.</para>
        /// <list type="bullet">
        /// <item><description><b>MarkdownHeaderTextSplitter</b>: Splits text in the format of <c>[(&quot;#&quot;, &quot;head1&quot;), (&quot;##&quot;, &quot;head2&quot;), (&quot;###&quot;, &quot;head3&quot;), (&quot;####&quot;, &quot;head4&quot;)]</c>. This splitter is suitable for Markdown text.</description></item>
        /// <item><description><b>LLMSplitter</b>: Uses an LLM to split text. The default model is qwen3-8b. Currently, this splitter takes effect only when ADBPGLoader is selected.</description></item>
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
        /// <item><description>For complex documents with messy layouts and formats, we recommend that you enable VL-enhanced content recognition.</description></item>
        /// <item><description>After you enable VL-enhanced content recognition, document processing takes a longer time.</description></item>
        /// <item><description>After you enable VL-enhanced content recognition, images in the document cannot be stored or recalled.</description></item>
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
        /// <para>You can identify the title text, mark the text in the metadata, and then combine the text with the previous-level title to achieve text enhancement.</para>
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
