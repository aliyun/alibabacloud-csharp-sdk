// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class UploadDocumentAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>File metadata. You can use this to filter results during retrieval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;cateogry\&quot;: \&quot;报告\&quot;}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The full file name, including the extension. Supported formats are PDF, DOC, DOCX, Markdown, PPT, and PPTX. File size must not exceed 100 MB. PDF, DOC, DOCX, PPT, and PPTX files must not exceed 500 pages.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.pdf</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The OSS URL of the file. If the file is not publicly readable, include a signature in the URL.</para>
        /// <para>If you use the SDK to upload files, upload the file directly. You do not need to provide an OSS URL. For more information, see the SDK documentation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-xxx.hangzhou.com/test.pdf">https://oss-xxx.hangzhou.com/test.pdf</a></para>
        /// </summary>
        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        /// <summary>
        /// <para>The document library ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sjdhbcsj</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

    }

}
