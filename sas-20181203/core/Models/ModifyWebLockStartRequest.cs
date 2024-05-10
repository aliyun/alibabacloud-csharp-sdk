// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockStartRequest : TeaModel {
        /// <summary>
        /// The prevention mode. Valid values:
        /// 
        /// *   **block**: Interception Mode
        /// *   **audit**: Alert Mode
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DefenceMode")]
        [Validation(Required=false)]
        public string DefenceMode { get; set; }

        /// <summary>
        /// The directory for which you want to enable web tamper proofing. Separate multiple directories with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Dir")]
        [Validation(Required=false)]
        public string Dir { get; set; }

        /// <summary>
        /// The directory for which you want to disable web tamper proofing.
        /// 
        /// > If you set **Mode** to **blacklist**, you must specify this parameter.
        /// </summary>
        [NameInMap("ExclusiveDir")]
        [Validation(Required=false)]
        public string ExclusiveDir { get; set; }

        /// <summary>
        /// The file for which you want to disable web tamper proofing.
        /// 
        /// > If you set **Mode** to **blacklist**, you must specify this parameter.
        /// </summary>
        [NameInMap("ExclusiveFile")]
        [Validation(Required=false)]
        public string ExclusiveFile { get; set; }

        /// <summary>
        /// The type of the file for which you want to disable web tamper proofing. Separate multiple types with semicolons (;). Valid values:
        /// 
        /// *   php
        /// *   jsp
        /// *   asp
        /// *   aspx
        /// *   js
        /// *   cgi
        /// *   html
        /// *   htm
        /// *   xml
        /// *   shtml
        /// *   shtm
        /// *   jpg
        /// *   gif
        /// *   png
        /// 
        /// > If you set **Mode** to **blacklist**, you must specify this parameter.
        /// </summary>
        [NameInMap("ExclusiveFileType")]
        [Validation(Required=false)]
        public string ExclusiveFileType { get; set; }

        /// <summary>
        /// The type of the file for which you want to enable web tamper proofing. Separate multiple types with semicolons (;). Valid values:
        /// 
        /// *   php
        /// *   jsp
        /// *   asp
        /// *   aspx
        /// *   js
        /// *   cgi
        /// *   html
        /// *   htm
        /// *   xml
        /// *   shtml
        /// *   shtm
        /// *   jpg
        /// *   gif
        /// *   png
        /// 
        /// > If you set **Mode** to **whitelist**, you must specify this parameter.
        /// </summary>
        [NameInMap("InclusiveFileType")]
        [Validation(Required=false)]
        public string InclusiveFileType { get; set; }

        /// <summary>
        /// The local path to the backup files of the protected directory.\\
        /// The directory format of a Linux server is different from that of a Windows server. You must enter the directory in the required format based on your operating system. Examples:
        /// 
        /// *   Linux server: /usr/local/aegis/bak
        /// *   Windows server: C:\\Program Files (x86)\\Alibaba\\Aegis\\bak
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LocalBackupDir")]
        [Validation(Required=false)]
        public string LocalBackupDir { get; set; }

        /// <summary>
        /// The protection mode of web tamper proofing. Valid values:
        /// 
        /// *   **whitelist**: In this mode, web tamper proofing is enabled for the specified directories and file types.
        /// *   **blacklist**: In this mode, web tamper proofing is enabled for the unspecified subdirectories, file types, and files in the protected directory.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The UUID of the server for which you want to enable web tamper proofing.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
