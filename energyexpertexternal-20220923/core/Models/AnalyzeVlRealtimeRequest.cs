// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class AnalyzeVlRealtimeRequest : TeaModel {
        /// <summary>
        /// <para>Choose one of fileUrl or fileUrlObject:</para>
        /// <list type="bullet">
        /// <item><description><para>fileUrl: Use in the form of a document URL, for a single document (supports up to 1000 pages and 100MB)</para>
        /// </description></item>
        /// <item><description><para>fileUrlObject: Use when calling the interface with local file upload, for a single document (supports up to 1000 pages and 100 MB)</para>
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
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>Language, parameters that can be passed</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese (default)</description></item>
        /// <item><description>en-US: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>A unique parsing template ID used to specify the key-value pairs to be extracted from the document. You need to log in to the template management page, configure the template, and then get the corresponding template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>572d24k0c95a</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
