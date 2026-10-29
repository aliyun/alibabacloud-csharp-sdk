// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class BackupAndroidInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

        /// <summary>
        /// <para>The name of the backup file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("BackupFileName")]
        [Validation(Required=false)]
        public string BackupFileName { get; set; }

        /// <summary>
        /// <para>The upload URL of the backup file.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BackupFilePath")]
        [Validation(Required=false)]
        public string BackupFilePath { get; set; }

        /// <summary>
        /// <para>The description of the full backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a backup android instance</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of application package names to exclude from the full backup. For matched applications, only APK collection is skipped, and user data is backed up as usual. If this parameter is not specified, no applications are excluded.</para>
        /// </summary>
        [NameInMap("ExcludeAppList")]
        [Validation(Required=false)]
        public List<string> ExcludeAppList { get; set; }

        /// <summary>
        /// <para>The backup region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
        /// </summary>
        [NameInMap("UploadEndpoint")]
        [Validation(Required=false)]
        public string UploadEndpoint { get; set; }

    }

}
