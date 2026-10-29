// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RecoverAndroidInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

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
        /// <para>The OSS address to which the backup file is uploaded.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BackupFilePath")]
        [Validation(Required=false)]
        public string BackupFilePath { get; set; }

        /// <summary>
        /// <para>The list of app package names excluded from the full-device restore. Excluded apps are not uninstalled and their APKs are not installed, which is compatible with legacy backups that contain APKs. Only user data is replaced. Empty shells must be installed by the customer by using the pm install command. If this parameter is not specified, no apps are excluded.</para>
        /// </summary>
        [NameInMap("ExcludeAppList")]
        [Validation(Required=false)]
        public List<string> ExcludeAppList { get; set; }

        /// <summary>
        /// <para>The backup region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
        /// </summary>
        [NameInMap("UploadEndpoint")]
        [Validation(Required=false)]
        public string UploadEndpoint { get; set; }

        /// <summary>
        /// <para>The upload type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("UploadType")]
        [Validation(Required=false)]
        public string UploadType { get; set; }

    }

}
