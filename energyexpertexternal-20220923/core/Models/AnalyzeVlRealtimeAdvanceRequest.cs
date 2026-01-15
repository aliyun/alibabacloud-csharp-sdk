// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class AnalyzeVlRealtimeAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>文件名需带文件类型后缀</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.png</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>Valid values: fileUrl and fileUrlObject.</para>
        /// <list type="bullet">
        /// <item><description>fileUrl: used as a document URL. A single document with not more than 1,000 pages and whose size does not exceed 100 MB is supported.</description></item>
        /// <item><description>fileUrlObject: used when the operation is called in local file upload mode. A single document with not more than 1,000 pages and whose size does not exceed 100 MB is supported.</description></item>
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
        /// <para>fileUrl: <a href="https://example.com/example.pdf">https://example.com/example.pdf</a> fileUrlObject: FileInputStream generated for a local file</para>
        /// </summary>
        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        /// <summary>
        /// <para>The language, which can be transferred. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN (default)</description></item>
        /// <item><description>en-US</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The unique ID of an extraction template, which is used to specify the content to be extracted from a document. You must log on to the Template Management page to configure the template and then obtain the corresponding template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>572d24k0c95a</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
