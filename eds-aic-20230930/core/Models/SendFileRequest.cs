// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class SendFileRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud phone instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

        [NameInMap("AutoInstall")]
        [Validation(Required=false)]
        public bool? AutoInstall { get; set; }

        /// <summary>
        /// <para>The path to which you want to upload the pushed file in the cloud phone instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/data</para>
        /// </summary>
        [NameInMap("SourceFilePath")]
        [Validation(Required=false)]
        public string SourceFilePath { get; set; }

        /// <summary>
        /// <para>The name of the file uploaded from the Object Storage Service (OSS) to the cloud phone instance.</para>
        /// <remarks>
        /// <para> If UploadType is set to OSS, you must specify TargetFileName. If TargetFileName is empty, the file uploaded from the OSS bucket to the cloud phone instance retains its original name. If TargetFileName is provided with a value, the uploaded file in the SourceFilePath directory uses the specified name (TargetFileName). If UploadType is set to DOWNLOAD_URL, TargetFileName does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test.txt</para>
        /// </summary>
        [NameInMap("TargetFileName")]
        [Validation(Required=false)]
        public string TargetFileName { get; set; }

        /// <summary>
        /// <para>The endpoint of the OSS bucket in which the file is stored.</para>
        /// <remarks>
        /// <para> Set the value to an internal endpoint when the cloud phone instance and the OSS bucket are in the same region to improve transfer speed without incurring public traffic fees. Sample endpoint: <c>oss-cn-hangzhou-internal.aliyuncs.com</c>. For more information, see <a href="https://help.aliyun.com/document_detail/31837.html">OSS regions and endpoints</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou.aliyuncs.com</para>
        /// </summary>
        [NameInMap("UploadEndpoint")]
        [Validation(Required=false)]
        public string UploadEndpoint { get; set; }

        /// <summary>
        /// <para>The storage type of the file that you want to upload.</para>
        /// <list type="bullet">
        /// <item><description>Set the value to OSS.</description></item>
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
        /// <para>The OSS URL of the file.</para>
        /// <remarks>
        /// <para> The OSS bucket name must start with &quot;cloudphone-saved-bucket-&quot;, for example, &quot;cloudphone-saved-bucket-example&quot;. You must also create an OSS directory to store the backup data. Set the value for UploadUrl in this format: oss://\<BucketName>/\<OSSDirectoryName>\<FileName>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UploadUrl")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
