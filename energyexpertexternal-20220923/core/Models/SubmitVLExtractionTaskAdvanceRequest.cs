// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SubmitVLExtractionTaskAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The filename must include the file type suffix.</para>
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
        /// <item><description><para>fileUrl: Use by providing the document URL, for a single document (supports up to 1000 pages and 100MB in size)</para>
        /// </description></item>
        /// <item><description><para>fileUrlObject: Use when calling the interface with local file upload, for a single document (supports up to 1000 pages and 100 MB in size)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The relationship between file parsing methods and supported document types</para>
        /// <list type="bullet">
        /// <item><description>Long Text RAG: Supports pdf, doc/docx, up to 1000 pages</description></item>
        /// <item><description>Image Processing: Supports pdf, jpg, jpeg, png, bmp</description></item>
        /// <item><description>Long Text Understanding: Supports pdf, doc/docx, xls/xlsx</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>fileUrl：<a href="https://example.com/example.pdf">https://example.com/example.pdf</a>
        /// fileUrlObject：本地文件生成的FileInputStream</para>
        /// </summary>
        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Unique knowledge base folder ID, used when you need to categorize documents and control the scope of online Q&amp;A queries.</description></item>
        /// <item><description>The folder ID needs to be obtained from the intelligent document console after logging in.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>Unique parsing template ID, used to specify the key-value pairs to be extracted from the document. You need to configure the template on the template management page and then obtain the corresponding template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>572d24k0c95a</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
