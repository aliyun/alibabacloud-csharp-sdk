// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class BackupAppRequest : TeaModel {
        /// <summary>
        /// <para>A list of instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIdList { get; set; }

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
        /// <para>The URL of the backup file.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BackupFilePath")]
        [Validation(Required=false)]
        public string BackupFilePath { get; set; }

        /// <summary>
        /// <para>The description of the application backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a backup app</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A list of package names for the applications to back up.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceAppList")]
        [Validation(Required=false)]
        public List<string> SourceAppList { get; set; }

        /// <summary>
        /// <para>Specifies the region where the backup is created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-shanghai-internal.aliyuncs.com</para>
        /// </summary>
        [NameInMap("UploadEndpoint")]
        [Validation(Required=false)]
        public string UploadEndpoint { get; set; }

    }

}
