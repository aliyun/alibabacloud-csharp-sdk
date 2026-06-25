// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class FetchFileRequest : TeaModel {
        /// <summary>
        /// <para>A list of cloud phone instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

        /// <summary>
        /// <para>A client-generated token, up to 100 characters long, that ensures the idempotency of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The path of the file or folder to fetch from the cloud phone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/data/a.txt</para>
        /// </summary>
        [NameInMap("SourceFilePath")]
        [Validation(Required=false)]
        public string SourceFilePath { get; set; }

        /// <summary>
        /// <para>The endpoint for uploading files to OSS.</para>
        /// <remarks>
        /// <para>If the cloud phone and the destination OSS bucket are in the same region, you can use an internal endpoint to accelerate the transfer and avoid public network charges. For example, in the China (Hangzhou) region, use <c>oss-cn-hangzhou-internal.aliyuncs.com</c>. For a complete list of endpoints, see <a href="https://help.aliyun.com/document_detail/31837.html">OSS regions and endpoints</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
        /// </summary>
        [NameInMap("UploadEndpoint")]
        [Validation(Required=false)]
        public string UploadEndpoint { get; set; }

        /// <summary>
        /// <para>The type of storage service for the fetched file.</para>
        /// <remarks>
        /// <para>Currently, only Object Storage Service (OSS) is supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("UploadType")]
        [Validation(Required=false)]
        public string UploadType { get; set; }

        /// <summary>
        /// <para>The destination URL in OSS.</para>
        /// <remarks>
        /// <para>The destination bucket name must be prefixed with <c>cloudphone-saved-bucket-</c>. For example, <c>cloudphone-saved-bucket-example</c>. You must also create a folder in the bucket to serve as the destination directory. The <c>UploadUrl</c> must follow the format: <c>oss://&lt;bucket_name&gt;/&lt;folder_name&gt;</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://cloudphone-saved-bucket-example/received</para>
        /// </summary>
        [NameInMap("UploadUrl")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
