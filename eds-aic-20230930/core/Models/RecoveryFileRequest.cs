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
        /// <para>Specifies whether it is a full-device backup.</para>
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
        /// <para>The OSS address to which the backup file is uploaded.
        /// <notice>Call the describeBuckets operation to obtain the bucketName, and select ossObjectList to obtain the key. The key is the path of the backup file. Concatenate them into &quot;oss://${bucketName}/${key}&quot;.</notice></para>
        /// </summary>
        [NameInMap("BackupFilePath")]
        [Validation(Required=false)]
        public string BackupFilePath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;OssBucket&quot;:&quot;my-bucket&quot;,&quot;OssObjectKey&quot;:&quot;script/recover.sh&quot;,&quot;OssEndpoint&quot;:&quot;oss-cn-hangzhou-internal.aliyuncs.com&quot;,&quot;OssRegion&quot;:&quot;cn-hangzhou&quot;}]</para>
        /// </summary>
        [NameInMap("CustomScripts")]
        [Validation(Required=false)]
        public List<RecoveryFileRequestCustomScripts> CustomScripts { get; set; }
        public class RecoveryFileRequestCustomScripts : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>my-bucket</para>
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>script/recover.sh</para>
            /// </summary>
            [NameInMap("OssObjectKey")]
            [Validation(Required=false)]
            public string OssObjectKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("OssRegion")]
            [Validation(Required=false)]
            public string OssRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;acp-0n4k52uiyon472rq0&quot;]</para>
            /// </summary>
            [NameInMap("TestInstanceIds")]
            [Validation(Required=false)]
            public List<string> TestInstanceIds { get; set; }

        }

        /// <summary>
        /// <para>The list of excluded app package names for full-device restore. Matched apps are not uninstalled, and their APKs are not installed (compatible with legacy backups that contain APKs). Only user data is replaced. The empty shell must be installed by the customer using pm install. If this parameter is not specified, no apps are excluded.</para>
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
