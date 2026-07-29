// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DtsAI20260401.Models
{
    public class CreateDocParserJobAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The format of the input file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>pdf</b>: PDF file.</para>
        /// </description></item>
        /// <item><description><para><b>docx</b>: Word file in DOCX format.</para>
        /// </description></item>
        /// <item><description><para><b>doc</b>: Word file in DOC format.</para>
        /// </description></item>
        /// <item><description><para><b>pptx</b>: PPT file in PPTX format.</para>
        /// </description></item>
        /// <item><description><para><b>ppt</b>: PPT file in PPT format.</para>
        /// </description></item>
        /// <item><description><para><b>txt</b>: plain text file.</para>
        /// </description></item>
        /// <item><description><para><b>md</b>: Markdown file.</para>
        /// </description></item>
        /// <item><description><para><b>png</b>: PNG image.</para>
        /// </description></item>
        /// <item><description><para><b>jpg</b>: JPG image.</para>
        /// </description></item>
        /// <item><description><para><b>jpeg</b>: JPEG image.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdf</para>
        /// </summary>
        [NameInMap("FileFormat")]
        [Validation(Required=false)]
        public string FileFormat { get; set; }

        /// <summary>
        /// <para>The file name, which must include the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document.pdf</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The HTTP or HTTPS URL of the file to be parsed.</para>
        /// <remarks>
        /// <para>The SDKs for various programming languages additionally provide a <c>CreateDocParserJobAdvance</c> method that supports passing a local file stream directly (such as InputStream in Java), without the need to upload the file to OSS and construct a FileUrl in advance. When using the Advance method, replace the <c>FileUrl</c> parameter (URL string) with the <c>FileUrlObject</c> parameter (file stream). All other request parameters remain unchanged. The SDK automatically performs the following operations:</para>
        /// <ol>
        /// <item><description>Obtains temporary OSS upload credentials.</description></item>
        /// <item><description>Uploads the file stream directly to OSS.</description></item>
        /// <item><description>Calls the CreateDocParserJob operation with the generated OSS URL.</description></item>
        /// </ol>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.oss-cn-beijing.aliyuncs.com/document.pdf?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://xxx.oss-cn-beijing.aliyuncs.com/document.pdf?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        [NameInMap("ImageMode")]
        [Validation(Required=false)]
        public string ImageMode { get; set; }

        /// <summary>
        /// <para>The OSS file URL.</para>
        /// </summary>
        [NameInMap("OssFileUrl")]
        [Validation(Required=false)]
        public string OssFileUrl { get; set; }

        /// <summary>
        /// <para>The output format of the parsing result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>markdown</b>: Markdown format.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>markdown</para>
        /// </summary>
        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("TableFormat")]
        [Validation(Required=false)]
        public string TableFormat { get; set; }

    }

}
