// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class FetchFileRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud phone instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

        /// <summary>
        /// <para>The path to the file that you want to pull from the cloud phone instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/data/a.txt</para>
        /// </summary>
        [NameInMap("SourceFilePath")]
        [Validation(Required=false)]
        public string SourceFilePath { get; set; }

        /// <summary>
        /// <para>The endpoint of the OSS bucket in which you want to store the pulled file.</para>
        /// <remarks>
        /// <para> Set the value to an internal endpoint when the cloud phone instance and the OSS bucket are in the same region to improve upload speed without incurring public traffic fees. Sample endpoint: <c>oss-cn-hangzhou-internal.aliyuncs.com</c>. For more information, see <a href="https://help.aliyun.com/document_detail/31837.html">OSS regions and endpoints</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou.aliyuncs.com</para>
        /// </summary>
        [NameInMap("UploadEndpoint")]
        [Validation(Required=false)]
        public string UploadEndpoint { get; set; }

        /// <summary>
        /// <para>The type of the storage service.</para>
        /// <remarks>
        /// <para> Currently, only OSS is supported.</para>
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
        /// <para>The OSS URL of the pulled file.</para>
        /// <remarks>
        /// <para> The OSS bucket name must start with &quot;cloudphone-saved-bucket-&quot;, for example, &quot;cloudphone-saved-bucket-example&quot;. You must also create an OSS directory to store the backup data. Set the value for UploadUrl in this format: oss://\<BucketName>/\<OSSDirectoryName>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UploadUrl")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
