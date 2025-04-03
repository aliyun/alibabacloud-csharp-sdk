// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RecoveryFileRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

        /// <summary>
        /// <para>Specifies whether to back up the whole instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
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
        /// <para>The OSS path to which the backup file is uploaded.</para>
        /// <remarks>
        /// <para> When calling the describeBuckets operation to retrieve a bucket name, you must also call the ossObjectList operation to obtain the object key. Combine these to form the full path: oss://${bucketName}/${key}.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("BackupFilePath")]
        [Validation(Required=false)]
        public string BackupFilePath { get; set; }

        /// <summary>
        /// <para>The endpoint of the OSS bucket that stores the backup file.</para>
        /// <remarks>
        /// <para>: When calling the DescribeBuckets operation to query buckets, retrieve the IntranetEndpoint value if the cloud phone and the OSS bucket are in the same region. If they are in different regions, retrieve the ExtranetEndpoint value instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
        /// </summary>
        [NameInMap("UploadEndpoint")]
        [Validation(Required=false)]
        public string UploadEndpoint { get; set; }

        /// <summary>
        /// <para>The type of the backup.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS: backup files are stored in OSS buckets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("UploadType")]
        [Validation(Required=false)]
        public string UploadType { get; set; }

    }

}
