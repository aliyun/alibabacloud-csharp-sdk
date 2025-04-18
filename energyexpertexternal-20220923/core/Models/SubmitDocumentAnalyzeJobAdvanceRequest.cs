// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SubmitDocumentAnalyzeJobAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The default extraction method is &quot;doc&quot;, with the following optional values:</para>
        /// <list type="bullet">
        /// <item><description>vl: Image processing</description></item>
        /// <item><description>doc: Long text RAG (Retrieval-Augmented Generation)</description></item>
        /// <item><description>docUnderstanding: Long text comprehension</description></item>
        /// <item><description>recommender: Recommendation type</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>doc</para>
        /// </summary>
        [NameInMap("analysisType")]
        [Validation(Required=false)]
        public string AnalysisType { get; set; }

        /// <summary>
        /// <para>The filename must include the file type extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.pdf</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>Choose one between fileUrl and fileUrlObject:</para>
        /// <list type="bullet">
        /// <item><description><para>fileUrl: Use the document URL method for a single document (supports documents with up to 1000 pages and within 100MB).</para>
        /// </description></item>
        /// <item><description><para>fileUrlObject: Use when calling the API via local file upload, for a single document (supports documents with up to 1000 pages and 
        /// within 100MB).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Relationship between file parsing methods and supported document types. </para>
        /// <list type="bullet">
        /// <item><description>Long Text RAG: Supports pdf, doc/docx, and up to 1000 pages</description></item>
        /// <item><description>Image Processing: Supports pdf, jpg, jpeg, png, bmp</description></item>
        /// <item><description>Long Text Understanding: Supports pdf, doc/docx, xls/xlsx</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/example.pdf">https://example.com/example.pdf</a></para>
        /// </summary>
        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        /// <summary>
        /// <para>Unique knowledge base folder ID, used for categorizing documents and controlling the scope of online Q&amp;A queries. If empty, the document will be uploaded to the tenant\&quot;s root directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>folderCode</para>
        /// </summary>
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>The unique extraction template ID is used to specify the key-value pairs to be extracted from the document. You need to log in to the template management page to configure the template and obtain the corresponding template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>templateCode</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
