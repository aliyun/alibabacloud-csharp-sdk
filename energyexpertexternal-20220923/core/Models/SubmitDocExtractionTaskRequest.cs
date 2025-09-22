// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SubmitDocExtractionTaskRequest : TeaModel {
        /// <summary>
        /// <para>Document extraction type:
        /// Supports rag and long text understanding types, default is rag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rag</para>
        /// </summary>
        [NameInMap("extractType")]
        [Validation(Required=false)]
        public string ExtractType { get; set; }

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
        /// <para>Choose one of fileUrl or fileUrlObject:</para>
        /// <list type="bullet">
        /// <item><description><para>fileUrl: Use by providing the document URL, for a single document (supports up to 1000 pages, 100MB in size)</para>
        /// </description></item>
        /// <item><description><para>fileUrlObject: Use when calling the interface with local file upload, for a single document (supports up to 1000 pages, 100 MB in size)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The relationship between file extraction methods and supported document types</para>
        /// <list type="bullet">
        /// <item><description>Long text RAG: Supports pdf, doc/docx, xlsx, csv, txt, up to 1000 pages</description></item>
        /// <item><description>Image processing: Supports pdf, jpg, jpeg, png, bmp, jpe, tif, tiff, webp, heic</description></item>
        /// <item><description>Long text understanding: Supports doc/docx, xlsx, pdf, csv, txt</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>fileUrl：<a href="https://example.com/example.pdf">https://example.com/example.pdf</a>
        /// fileUrlObject：FileInputStream generated from a local file</para>
        /// </summary>
        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>A unique knowledge base folder ID, used when you need to categorize documents and control the scope of documents for online Q&amp;A queries.</description></item>
        /// <item><description>The folder ID needs to be obtained by logging into the intelligent document console.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>A unique extraction template ID used to specify the content to be extracted from the document. You need to log in to the template management page to configure the template and obtain the corresponding template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>572d24k0c95a</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
