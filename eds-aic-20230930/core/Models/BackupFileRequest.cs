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
        /// 
        /// <b>Example:</b>
        /// <para>acp-bhiqzl82zfebta****</para>
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
        /// <para>The upload path for the backup file.</para>
        /// <remarks>
        /// <para>If you upload the file to an OSS bucket, call the describeBuckets operation to obtain the bucketName, and select ossObjectList to obtain the key. The key is the folder path in the OSS bucket. Concatenate them into <c>oss://${bucketName}/${key}</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BackupFilePath")]
        [Validation(Required=false)]
        public string BackupFilePath { get; set; }

        /// <summary>
        /// <para>The user-defined backup scripts (optional). If this parameter is not specified, all instances use the built-in scripts of the platform, and the behavior remains exactly the same as before. Each item represents a script. If TestInstanceIds is specified, only the instances in the list use this script, and the list must be a subset of AndroidInstanceIdList. If TestInstanceIds is not specified, the script serves as the full fallback script for this task, and at most one item without TestInstanceIds is allowed per task. The array limit is 11. Contact Wuying technical support to use this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;OssBucket&quot;:&quot;my-bucket&quot;,&quot;OssObjectKey&quot;:&quot;script/backup.sh&quot;,&quot;OssEndpoint&quot;:&quot;oss-cn-hangzhou-internal.aliyuncs.com&quot;,&quot;OssRegion&quot;:&quot;cn-hangzhou&quot;}]</para>
        /// </summary>
        [NameInMap("CustomScripts")]
        [Validation(Required=false)]
        public List<BackupFileRequestCustomScripts> CustomScripts { get; set; }
        public class BackupFileRequestCustomScripts : TeaModel {
            /// <summary>
            /// <para>The name of the user OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-bucket</para>
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// <para>The internal endpoint of the user OSS, which must end with -internal.aliyuncs.com.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            /// <summary>
            /// <para>The objectKey of the user OSS, which is the path of the script in the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>script/backup.sh</para>
            /// </summary>
            [NameInMap("OssObjectKey")]
            [Validation(Required=false)]
            public string OssObjectKey { get; set; }

            /// <summary>
            /// <para>The region of the user OSS bucket, which must be the same as the instance region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("OssRegion")]
            [Validation(Required=false)]
            public string OssRegion { get; set; }

            /// <summary>
            /// <para>Optional. The list of instance IDs bound to this script, which must be a subset of the current AndroidInstanceIdList. If this parameter is not specified, the script serves as the full fallback script for the current task. The maximum number of instance IDs is 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;acp-0n4k52uiyon472rq0&quot;]</para>
            /// </summary>
            [NameInMap("TestInstanceIds")]
            [Validation(Required=false)]
            public List<string> TestInstanceIds { get; set; }

        }

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
        /// <para>The list of application package names excluded from full-instance backup. For matched applications, only APK collection is skipped, and user data is backed up as usual. If this parameter is not specified, no applications are excluded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.android.chrome</para>
        /// </summary>
        [NameInMap("ExcludeAppList")]
        [Validation(Required=false)]
        public List<string> ExcludeAppList { get; set; }

        /// <summary>
        /// <para>The list of file paths in the Android container to exclude from the backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/data/exclude.txt</para>
        /// </summary>
        [NameInMap("ExcludeSourceFilePathList")]
        [Validation(Required=false)]
        public List<string> ExcludeSourceFilePathList { get; set; }

        /// <summary>
        /// <para>The list of application package names to back up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.example.xhs</para>
        /// </summary>
        [NameInMap("SourceAppList")]
        [Validation(Required=false)]
        public List<string> SourceAppList { get; set; }

        /// <summary>
        /// <para>The list of file paths to back up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/data</para>
        /// </summary>
        [NameInMap("SourceFilePathList")]
        [Validation(Required=false)]
        public List<string> SourceFilePathList { get; set; }

        /// <summary>
        /// <para>The domain name of the backup endpoint.</para>
        /// <remarks>
        /// <para>If you upload the file to an OSS bucket, call the describeBuckets operation to obtain the bucket. If the cloud phone and the bucket are in the same region, obtain the intranetEndpoint field. If they are in different regions, obtain the extranetEndpoint field.</para>
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
