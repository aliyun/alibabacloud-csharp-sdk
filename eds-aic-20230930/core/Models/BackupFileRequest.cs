// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class BackupFileRequest : TeaModel {
        /// <summary>
        /// <para>A list of instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

        /// <summary>
        /// <para>Specifies whether to back up the entire instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BackupAll")]
        [Validation(Required=false)]
        public bool? BackupAll { get; set; }

        /// <summary>
        /// <para>The name of the backup file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyBackup</para>
        /// </summary>
        [NameInMap("BackupFileName")]
        [Validation(Required=false)]
        public string BackupFileName { get; set; }

        /// <summary>
        /// <para>The upload URL for the backup file.</para>
        /// <remarks>
        /// <para>If you upload the file to an OSS bucket, call the DescribeBuckets operation to get the bucketName. Then, select a key from ossObjectList. The key represents the folder path in the OSS bucket. Combine these values into the format <c>oss://${bucketName}/${key}</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BackupFilePath")]
        [Validation(Required=false)]
        public string BackupFilePath { get; set; }

        /// <summary>
        /// <para>The description of the backup file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a backup/data request.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ExcludeSourceFilePathList")]
        [Validation(Required=false)]
        public List<string> ExcludeSourceFilePathList { get; set; }

        /// <summary>
        /// <para>A list of application package names to back up.</para>
        /// </summary>
        [NameInMap("SourceAppList")]
        [Validation(Required=false)]
        public List<string> SourceAppList { get; set; }

        /// <summary>
        /// <para>A list of file paths to back up.</para>
        /// </summary>
        [NameInMap("SourceFilePathList")]
        [Validation(Required=false)]
        public List<string> SourceFilePathList { get; set; }

        /// <summary>
        /// <para>The domain name of the upload URL.</para>
        /// <remarks>
        /// <para>If you upload the file to an OSS bucket, call the DescribeBuckets operation to obtain the bucket information. If the cloud phone and the bucket are in the same region, use the value of the intranetEndpoint field. If they are in different regions, use the value of the extranetEndpoint field.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-shanghai-internal.aliyuncs.com</para>
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
