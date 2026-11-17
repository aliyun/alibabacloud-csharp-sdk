// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UploadChatFileByBase64Request : TeaModel {
        /// <summary>
        /// <para>文件 MIME 类型（可选，不传时按 application/octet-stream 处理）</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/pdf</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>标准 Base64 文件内容，不含 data URI 前缀</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YWJj</para>
        /// </summary>
        [NameInMap("fileContentBase64")]
        [Validation(Required=false)]
        public string FileContentBase64 { get; set; }

        /// <summary>
        /// <para>原始文件名（含后缀）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>report.pdf</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数，缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
