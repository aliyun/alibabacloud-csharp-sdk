// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SubmitDocParsingTaskAdvanceRequest : TeaModel {
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
        /// <item><description><para>fileUrl: Use by providing the document URL, for a single document (supports up to 1000 pages and 100MB in size)</para>
        /// </description></item>
        /// <item><description><para>fileUrlObject: Use when calling the interface with local file upload, for a single document (supports up to 1000 pages and 100 MB in size)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The relationship between file parsing methods and supported document types</para>
        /// <list type="bullet">
        /// <item><description>Long Text RAG: Supports pdf, doc/docx, supports up to 1000 pages</description></item>
        /// <item><description>Image Processing: Supports pdf, jpg, jpeg, png, bmp</description></item>
        /// <item><description>Long Text Understanding: Supports pdf, doc/docx, xls/xlsx</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>fileUrl：<a href="https://example.com/example.pdf">https://example.com/example.pdf</a>
        /// fileUrlObject：FileInputStream generated from a local file</para>
        /// </summary>
        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Unique knowledge base folder ID, used when categorizing documents and controlling the scope of documents for online Q&amp;A queries.</description></item>
        /// <item><description>The folder ID needs to be obtained from the Intelligent Document Console after logging in.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>Whether to parse image content within the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("needAnalyzeImg")]
        [Validation(Required=false)]
        public bool? NeedAnalyzeImg { get; set; }

    }

}
