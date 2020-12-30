// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class ModifyBackupSetDownloadRulesRequest : TeaModel {
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        [NameInMap("OpenAutoDownload")]
        [Validation(Required=false)]
        public bool? OpenAutoDownload { get; set; }

        [NameInMap("BackupGatewayId")]
        [Validation(Required=false)]
        public long? BackupGatewayId { get; set; }

        [NameInMap("FullDataFormat")]
        [Validation(Required=false)]
        public string FullDataFormat { get; set; }

        [NameInMap("IncrementDataFormat")]
        [Validation(Required=false)]
        public string IncrementDataFormat { get; set; }

        [NameInMap("BackupSetDownloadDir")]
        [Validation(Required=false)]
        public string BackupSetDownloadDir { get; set; }

        [NameInMap("BackupSetDownloadTargetType")]
        [Validation(Required=false)]
        public string BackupSetDownloadTargetType { get; set; }

        [NameInMap("BackupSetDownloadTargetTypeLocation")]
        [Validation(Required=false)]
        public string BackupSetDownloadTargetTypeLocation { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
