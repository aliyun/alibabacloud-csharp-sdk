// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetBackupConfigResponseBody : TeaModel {
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public int? BackupMode { get; set; }

        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("EnableBackup")]
        [Validation(Required=false)]
        public bool? EnableBackup { get; set; }

        [NameInMap("EnableBackupVoice")]
        [Validation(Required=false)]
        public bool? EnableBackupVoice { get; set; }

        [NameInMap("ExpireSeconds")]
        [Validation(Required=false)]
        public int? ExpireSeconds { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("PathVoice")]
        [Validation(Required=false)]
        public string PathVoice { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// UID。
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
