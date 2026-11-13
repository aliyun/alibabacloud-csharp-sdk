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
        /// <para>Specifies whether to perform a full-device backup.</para>
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
        /// <para>The OSS address where the backup file is uploaded.
        /// <notice>Call the DescribeBuckets operation to obtain the bucket name, and select ossObjectList to obtain the key. The key is the path of the backup file. Concatenate them into the format &quot;oss://${bucketName}/${key}&quot;.</notice></para>
        /// </summary>
        [NameInMap("BackupFilePath")]
        [Validation(Required=false)]
        public string BackupFilePath { get; set; }

        /// <summary>
        /// <para>The custom restoration scripts. This parameter is optional. If this parameter is not specified, all instances use the built-in scripts of the platform, and the behavior remains exactly the same as before. Each item represents a script. If TestInstanceIds is specified, only the instances in the list use the script, which must be a subset of AndroidInstanceIdList. If TestInstanceIds is not specified, the script serves as the fallback script for all instances in the current task. A task can have at most one item without TestInstanceIds. The maximum array size is 11.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;OssBucket&quot;:&quot;my-bucket&quot;,&quot;OssObjectKey&quot;:&quot;script/recover.sh&quot;,&quot;OssEndpoint&quot;:&quot;oss-cn-hangzhou-internal.aliyuncs.com&quot;,&quot;OssRegion&quot;:&quot;cn-hangzhou&quot;}]</para>
        /// </summary>
        [NameInMap("CustomScripts")]
        [Validation(Required=false)]
        public List<RecoveryFileRequestCustomScripts> CustomScripts { get; set; }
        public class RecoveryFileRequestCustomScripts : TeaModel {
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
            /// <para>The internal endpoint of the user OSS. The endpoint must end with -internal.aliyuncs.com.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            /// <summary>
            /// <para>The object key of the user OSS, which is the path of the script in the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>script/recover.sh</para>
            /// </summary>
            [NameInMap("OssObjectKey")]
            [Validation(Required=false)]
            public string OssObjectKey { get; set; }

            /// <summary>
            /// <para>The region of the user OSS bucket. The region must be the same as the region of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("OssRegion")]
            [Validation(Required=false)]
            public string OssRegion { get; set; }

            /// <summary>
            /// <para>The list of instance IDs bound to the script. This parameter is optional. The IDs must be a subset of AndroidInstanceIdList. If this parameter is not specified, the script serves as the fallback script for all instances in the current task. You can specify up to 100 instance IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;acp-0n4k52uiyon472rq0&quot;]</para>
            /// </summary>
            [NameInMap("TestInstanceIds")]
            [Validation(Required=false)]
            public List<string> TestInstanceIds { get; set; }

        }

        /// <summary>
        /// <para>The list of excluded app package names for full-device restoration. Matched apps are not uninstalled and their APKs are not installed (compatible with legacy backups containing APKs), and only user data is replaced. Empty shells must be installed by the customer by running the pm install command. If this parameter is not specified, no apps are excluded.</para>
        /// </summary>
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
