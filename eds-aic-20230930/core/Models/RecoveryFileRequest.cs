// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RecoveryFileRequest : TeaModel {
        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

        /// <summary>
        /// <para>Specifies whether to back up the entire device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BackupAll")]
        [Validation(Required=false)]
        public bool? BackupAll { get; set; }

        /// <summary>
        /// <para>The ID of the backup file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bf-azhps4rdyi2th****</para>
        /// </summary>
        [NameInMap("BackupFileId")]
        [Validation(Required=false)]
        public string BackupFileId { get; set; }

        /// <summary>
        /// <para>The OSS URL to which the backup file is uploaded.
        /// <notice>Call the describeBuckets operation to obtain the bucketName, and select ossObjectList to obtain the key. The key is the path of the backup file. Concatenate them into &quot;oss://${bucketName}/${key}&quot;.</notice></para>
        /// </summary>
        [NameInMap("BackupFilePath")]
        [Validation(Required=false)]
        public string BackupFilePath { get; set; }

        [NameInMap("ExcludeAppList")]
        [Validation(Required=false)]
        public List<string> ExcludeAppList { get; set; }

        /// <summary>
        /// <para>The domain name of the backup address.
        /// <notice>Call the DescribeBuckets operation to obtain the bucket. If the cloud phone and the bucket are in the same region, obtain the IntranetEndpoint field. If they are in different regions, obtain the ExtranetEndpoint field.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
        /// </summary>
        [NameInMap("UploadEndpoint")]
        [Validation(Required=false)]
        public string UploadEndpoint { get; set; }

        /// <summary>
        /// <para>The backup type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("UploadType")]
        [Validation(Required=false)]
        public string UploadType { get; set; }

    }

}
