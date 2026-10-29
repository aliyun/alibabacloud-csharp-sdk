// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class SendFileRequest : TeaModel {
        /// <summary>
        /// <para>The list of instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically install the uploaded application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoInstall")]
        [Validation(Required=false)]
        public bool? AutoInstall { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. The token can be up to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The MD5 value of the input file.</para>
        /// </summary>
        [NameInMap("FileMd5")]
        [Validation(Required=false)]
        public string FileMd5 { get; set; }

        /// <summary>
        /// <para>The upload path inside the cloud phone to which the file is uploaded.</para>
        /// <remarks>
        /// <para>If UploadType is OSS or OSS_BRIDGED, the upload path SourceFilePath inside the cloud phone must be a directory, such as /sdcard/Download. If UploadType is DOWNLOAD_URL, the upload path SourceFilePath inside the cloud phone must be a file, such as /sdcard/Download/MyFile.txt.</para>
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
        /// <para>The name of the file uploaded from OSS to the cloud phone.</para>
        /// <remarks>
        /// <para>If UploadType is OSS or OSS_BRIDGED, the TargetFileName parameter is optional. If TargetFileName is empty, the original file name is retained when the OSS file is uploaded to the cloud phone. If TargetFileName is not empty, the file name in the SourceFilePath directory on the cloud phone is set to the value of TargetFileName. If UploadType is DOWNLOAD_URL, the TargetFileName parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test.txt</para>
        /// </summary>
        [NameInMap("TargetFileName")]
        [Validation(Required=false)]
        public string TargetFileName { get; set; }

        /// <summary>
        /// <para>The service domain name for uploading files to OSS. This parameter is required when UploadType is set to OSS or OSS_BRIDGED.</para>
        /// <remarks>
        /// <para>If the cloud phone and the OSS bucket are in the same region, you can use an internal endpoint to accelerate the transmission speed and avoid Internet traffic fees. For example, the internal endpoint for the China (Hangzhou) region is <c>oss-cn-hangzhou-internal.aliyuncs.com</c>. For more information about the mapping between regions and endpoints, see <a href="https://help.aliyun.com/document_detail/31837.html">Regions and endpoints</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
        /// </summary>
        [NameInMap("UploadEndpoint")]
        [Validation(Required=false)]
        public string UploadEndpoint { get; set; }

        /// <summary>
        /// <para>The storage type of the file to be uploaded.</para>
        /// <list type="bullet">
        /// <item><description>OSS: The file to be uploaded is an OSS resource.</description></item>
        /// <item><description>DOWNLOAD_URL: The file to be uploaded is a public download URL.</description></item>
        /// <item><description>OSS_BRIDGED: The file is synchronized to OSS through a public download URL and then distributed to cloud phone instances over the OSS internal network.</description></item>
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
        /// <item><description>If UploadType is OSS, UploadUrl is the cloud address of the file uploaded to OSS.<remarks>
        /// <para>The OSS bucket name must start with the prefix &quot;cloudphone-saved-bucket-&quot;, such as &quot;cloudphone-saved-bucket-example&quot;. You must create an OSS folder as the backup directory. The format of UploadUrl is &quot;oss://&quot; + &quot;Bucket name&quot; + &quot;/&quot; + &quot;Folder name&quot; + &quot;Uploaded file name&quot;.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>If UploadType is DOWNLOAD or OSS_BRIDGED, UploadUrl is the public download URL of the file.</description></item>
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
