// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class BackupFileRequest : TeaModel {
        /// <summary>
        /// <para>The list of instance IDs.</para>
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
        /// <para>The upload address of the backup file.</para>
        /// <remarks>
        /// <para>If you upload the backup file to an OSS bucket, call the describeBuckets operation to obtain the bucketName, and select ossObjectList to obtain the key. The key is the folder path in the OSS bucket. Concatenate them into <c>oss://${bucketName}/${key}</c>.</para>
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
        /// <para>This is a request to back up /data</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of application package names excluded from full instance backup. Matched applications only skip APK collection, and user data is backed up as usual. If this parameter is not specified, no applications are excluded.</para>
        /// </summary>
        [NameInMap("ExcludeAppList")]
        [Validation(Required=false)]
        public List<string> ExcludeAppList { get; set; }

        /// <summary>
        /// <para>The list of file paths in the Android container to exclude from the backup.</para>
        /// </summary>
        [NameInMap("ExcludeSourceFilePathList")]
        [Validation(Required=false)]
        public List<string> ExcludeSourceFilePathList { get; set; }

        /// <summary>
        /// <para>The list of package names of the applications to back up.</para>
        /// </summary>
        [NameInMap("SourceAppList")]
        [Validation(Required=false)]
        public List<string> SourceAppList { get; set; }

        /// <summary>
        /// <para>The list of file paths to back up.</para>
        /// </summary>
        [NameInMap("SourceFilePathList")]
        [Validation(Required=false)]
        public List<string> SourceFilePathList { get; set; }

        /// <summary>
        /// <para>The domain name of the backup address.</para>
        /// <remarks>
        /// <para>If you upload the backup file to an OSS bucket, call the describeBuckets operation to obtain the bucket. If the Cloud Phone instance and the bucket are in the same region, obtain the intranetEndpoint field. If they are in different regions, obtain the extranetEndpoint field.</para>
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
