// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class SendFileRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of one or more cloud phone instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically install the application after the file is uploaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoInstall")]
        [Validation(Required=false)]
        public bool? AutoInstall { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures request idempotence and prevents duplicate submissions. The token can contain up to 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("FileMd5")]
        [Validation(Required=false)]
        public string FileMd5 { get; set; }

        /// <summary>
        /// <para>The destination path on the cloud phone.</para>
        /// <remarks>
        /// <para>If <c>UploadType</c> is <c>OSS</c> or <c>OSS_BRIDGED</c>, <c>SourceFilePath</c> must specify a directory, for example, <c>/sdcard/Download/</c>. If <c>UploadType</c> is <c>DOWNLOAD_URL</c>, <c>SourceFilePath</c> must specify a full file path, for example, <c>/sdcard/Download/MyFile.txt</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/sdcard/Download</para>
        /// </summary>
        [NameInMap("SourceFilePath")]
        [Validation(Required=false)]
        public string SourceFilePath { get; set; }

        /// <summary>
        /// <para>The name for the destination file on the cloud phone.</para>
        /// <remarks>
        /// <para>This parameter is optional and takes effect only when <c>UploadType</c> is set to <c>OSS</c> or <c>OSS_BRIDGED</c>. If you specify this parameter, the file is saved with this name in the path specified by <c>SourceFilePath</c>. If you leave this parameter empty, the source file name is used. This parameter is ignored when <c>UploadType</c> is set to <c>DOWNLOAD_URL</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test.txt</para>
        /// </summary>
        [NameInMap("TargetFileName")]
        [Validation(Required=false)]
        public string TargetFileName { get; set; }

        /// <summary>
        /// <para>The service endpoint of Object Storage Service (OSS). This parameter is required if <c>UploadType</c> is <c>OSS</c> or <c>OSS_BRIDGED</c>.</para>
        /// <remarks>
        /// <para>If the cloud phone instance and the OSS bucket are in the same region, you can specify an internal endpoint to accelerate data transfer and avoid public data transfer costs. For example, the internal endpoint for the China (Hangzhou) region is <c>oss-cn-hangzhou-internal.aliyuncs.com</c>. For a complete list of endpoints, see <a href="https://help.aliyun.com/document_detail/31837.html">OSS regions and endpoints</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
        /// </summary>
        [NameInMap("UploadEndpoint")]
        [Validation(Required=false)]
        public string UploadEndpoint { get; set; }

        /// <summary>
        /// <para>The storage type of the source file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OSS</b>: The file is stored in Object Storage Service (OSS).</para>
        /// </description></item>
        /// <item><description><para><b>DOWNLOAD_URL</b>: The file is accessible via a public download link.</para>
        /// </description></item>
        /// <item><description><para><b>OSS_BRIDGED</b>: The service first downloads the file from a public download link to an internal OSS bucket, and then distributes it to the cloud phone instances over the internal network.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("UploadType")]
        [Validation(Required=false)]
        public string UploadType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If <c>UploadType</c> is <c>OSS</c>, this parameter specifies the URI of the source object in Object Storage Service (OSS).</description></item>
        /// </list>
        /// <remarks>
        /// <para>The URI must be in the <c>oss://&lt;bucket-name&gt;/&lt;object-key&gt;</c> format. The specified OSS bucket name must have the <c>cloudphone-saved-bucket-</c> prefix, for example, <c>cloudphone-saved-bucket-example</c>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If <c>UploadType</c> is <c>DOWNLOAD_URL</c> or <c>OSS_BRIDGED</c>, this parameter specifies the public download link of the source file.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://cloudphone-saved-bucket-example/send/a.txt</para>
        /// </summary>
        [NameInMap("UploadUrl")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
