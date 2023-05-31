// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockUpdateConfigRequest : TeaModel {
        /// <summary>
        /// The prevention mode. Valid values:
        /// 
        /// *   **block**: Interception Mode
        /// *   **audit**: Alert Mode
        /// </summary>
        [NameInMap("DefenceMode")]
        [Validation(Required=false)]
        public string DefenceMode { get; set; }

        /// <summary>
        /// The directory for which you want to enable web tamper proofing.
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
        /// The ID of the protected directory for which you want to change the status of web tamper proofing.
        /// 
        /// > You can call the [DescribeWebLockConfigList](~~DescribeWebLockConfigList~~) operation to query the IDs of protected directories.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The file for which you want to enable web tamper proofing.
        /// 
        /// > If you set **Mode** to **whitelist**, you must specify this parameter.
        /// </summary>
        [NameInMap("InclusiveFile")]
        [Validation(Required=false)]
        public string InclusiveFile { get; set; }

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
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The local path to the backup files of the protected directory.\
        /// The directory format of a Linux server is different from that of a Windows server. You must enter the directory in the required format based on your operating system. Examples:
        /// 
        /// *   Linux server: /usr/local/aegis/bak
        /// *   Windows server: C:\Program Files (x86)\Alibaba\Aegis\bak
        /// </summary>
        [NameInMap("LocalBackupDir")]
        [Validation(Required=false)]
        public string LocalBackupDir { get; set; }

        /// <summary>
        /// The protection mode of web tamper proofing. Valid values:
        /// 
        /// *   **whitelist**: In this mode, web tamper proofing is enabled for the specified directories and file types.
        /// *   **blacklist**: In this mode, web tamper proofing is enabled for the unspecified subdirectories, file types, and files in the protected directory.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The UUID of the server on which the protected directory is located.
        /// 
        /// > You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
