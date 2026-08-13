// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UploadChatFileResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>文件 MIME 类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>文件名</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.pdf</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>文件公开访问 URL（有效期 1 小时）</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
        /// </summary>
        [NameInMap("filePublicUrl")]
        [Validation(Required=false)]
        public string FilePublicUrl { get; set; }

        /// <summary>
        /// <para>文件记录 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleFileRecordId</para>
        /// </summary>
        [NameInMap("fileRecordId")]
        [Validation(Required=false)]
        public string FileRecordId { get; set; }

        /// <summary>
        /// <para>文件 remote_url（入库路径）</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
        /// </summary>
        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>OSS 对象路径</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("objectName")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>签名上传 URL（本接口为后端直传，该字段为空）</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
        /// </summary>
        [NameInMap("uploadSignatureUrl")]
        [Validation(Required=false)]
        public string UploadSignatureUrl { get; set; }

    }

}
